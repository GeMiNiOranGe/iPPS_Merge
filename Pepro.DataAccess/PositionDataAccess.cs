using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
using System.Data;

namespace Pepro.DataAccess;

public class PositionDataAccess {
    private static PositionDataAccess? instance;

    public static PositionDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionDataAccess() { }

    public List<Position> GetPositions() {
        string query = @"
            SELECT PositionId
                , Title
                , AllowanceCoefficient
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

    public Position? GetPositionByEmployeeId(string employeeId) {
        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowanceCoefficient
            FROM Position
            INNER JOIN Employee
                    ON Employee.PositionId = Position.PositionId
            WHERE EmployeeId = @EmployeeId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.VarChar, 10, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return PositionMapper.FromDataRow(row);
    }
}
