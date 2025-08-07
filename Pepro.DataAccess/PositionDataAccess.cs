using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class PositionDataAccess {
    private static PositionDataAccess? instance;

    public static PositionDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionDataAccess() { }

    public List<EmployeePosition> GetPositions() {
        string query = @"
            SELECT PositionId
                , Title
                , AllowanceCoefficient
            FROM Position
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<EmployeePosition> positions = [];
        foreach (DataRow row in dataTable.Rows) {
            EmployeePosition position = new() {
                PositionId = row.Field<int>("PositionId"),
                Title = row.Field<string>("Title") ?? "",
                AllowanceCoefficient = row.Field<decimal>("AllowanceCoefficient"),
            };
            positions.Add(position);
        }
        return positions;
    }

    public EmployeePosition? GetPositionByEmployeeId(string employeeId) {
        string query = @"
            SELECT Position.PositionId
                , Position.Title
                , Position.AllowanceCoefficient
            FROM Position
            INNER JOIN Employee
                    ON Employee.PositionId = Position.PositionId
            WHERE EmployeeId = @EmployeeId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "EmployeeId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = employeeId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        EmployeePosition employeePosition = new() {
            PositionId = row.Field<int>("PositionId"),
            Title = row.Field<string>("Title") ?? "",
            AllowanceCoefficient = row.Field<decimal>("AllowanceCoefficient"),
        };
        return employeePosition;
    }
}
