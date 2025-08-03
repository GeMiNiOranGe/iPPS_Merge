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
}
