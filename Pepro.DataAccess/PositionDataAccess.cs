using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class PositionDataAccess {
    private static PositionDataAccess? instance;

    public static PositionDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionDataAccess() { }

    public List<Position> GetPositionsByPositionIds(List<int> positionIds)
    {
        if (positionIds == null || positionIds.Count == 0)
        {
            return [];
        }

        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowancePercent
            FROM Position
            INNER JOIN @PositionIds AS PositionIds
                    ON PositionIds.Id = Position.PositionId
        ";
        List<SqlParameter> parameters = [];

        DataTable entityIds = TableParameters.CreateEntityIds(positionIds);
        parameters.AddTableValued("PositionIds", "EntityIds", entityIds);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Position> positions = [];
        foreach (DataRow row in dataTable.Rows)
        {
            Position employee = PositionMapper.FromDataRow(row);
            positions.Add(employee);
        }
        return positions;
    }

    public List<Position> GetPositions() {
        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowancePercent
            FROM Position
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Position> positions = [];
        foreach (DataRow row in dataTable.Rows) {
            Position position = PositionMapper.FromDataRow(row);
            positions.Add(position);
        }
        return positions;
    }

    public Position? GetPositionByEmployeeId(int employeeId) {
        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowancePercent
            FROM Position
            INNER JOIN Employee
                    ON Employee.PositionId = Position.PositionId
            WHERE Employee.EmployeeId = @EmployeeId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return PositionMapper.FromDataRow(row);
    }
}
