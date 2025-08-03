using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class SalaryLevelDataAccess {
    private static SalaryLevelDataAccess? instance;

    public static SalaryLevelDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryLevelDataAccess() { }

    public List<SalaryLevel> GetSalaryLevelsBySalaryScaleId(int salaryScaleId) {
        string query = @"
            SELECT SalaryLevelId
                , Level
                , Coefficient
                , SalaryScaleId
            FROM SalaryLevel
            WHERE SalaryScaleId = @SalaryScaleId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "SalaryScaleId",
                SqlDbType = SqlDbType.Int,
                Value = salaryScaleId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

        List<SalaryLevel> salaryLevels = [];
        foreach (DataRow row in dataTable.Rows) {
            SalaryLevel salaryLevel = new() {
                SalaryLevelId = row.Field<int>("SalaryLevelId"),
                Level = row.Field<string>("Level") ?? "",
                Coefficient = row.Field<decimal>("Coefficient"),
                SalaryScaleId = row.Field<int>("SalaryScaleId"),
            };
            salaryLevels.Add(salaryLevel);
        }
        return salaryLevels;
    }
}
