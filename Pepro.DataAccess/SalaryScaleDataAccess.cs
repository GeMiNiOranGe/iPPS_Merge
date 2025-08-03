using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class SalaryScaleDataAccess {
    private static SalaryScaleDataAccess? instance;

    public static SalaryScaleDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryScaleDataAccess() { }

    public List<SalaryScale> GetSalaryScales() {
        string query = @"
            SELECT SalaryScaleId
                , [Group]
                , Name
            FROM SalaryScale
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<SalaryScale> salaryScales = [];
        foreach (DataRow row in dataTable.Rows) {
            SalaryScale salaryScale = new() {
                SalaryScaleId = row.Field<int>("SalaryScaleId"),
                Group = row.Field<string>("Group") ?? "",
                Name = row.Field<string>("Name") ?? "",
            };
            salaryScales.Add(salaryScale);
        }
        return salaryScales;
    }
}
