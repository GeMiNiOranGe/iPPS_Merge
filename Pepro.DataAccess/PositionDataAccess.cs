using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class PositionDataAccess {
    private static PositionDataAccess? _instance;

    public static PositionDataAccess Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private PositionDataAccess() { }

    public IEnumerable<Position> GetPositionsByPositionIds(List<int> positionIds)
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

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapMany(PositionMapper.FromDataRow);
    }

    public IEnumerable<Position> GetPositions() {
        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowancePercent
            FROM Position
        ";

        return DataProvider
            .Instance.ExecuteQuery(query)
            .MapMany(PositionMapper.FromDataRow);
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

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapToSingleOrDefault(PositionMapper.FromDataRow);
    }
}
