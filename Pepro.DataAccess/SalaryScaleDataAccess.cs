using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class SalaryScaleDataAccess {
    private static SalaryScaleDataAccess? _instance;

    public static SalaryScaleDataAccess Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private SalaryScaleDataAccess() { }

    public List<SalaryScale> GetSalaryScales() {
        string query = @"
            SELECT SalaryScale.SalaryScaleId
                , SalaryScale.[Group]
                , SalaryScale.Name
            FROM SalaryScale
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<SalaryScale> salaryScales = [];
        foreach (DataRow row in dataTable.Rows) {
            SalaryScale salaryScale = SalaryScaleMapper.FromDataRow(row);
            salaryScales.Add(salaryScale);
        }
        return salaryScales;
    }

    public List<SalaryScale> GetSalaryScalesBySalaryScaleIds(List<int> salaryScaleIds)
    {
        if (salaryScaleIds == null || salaryScaleIds.Count == 0)
        {
            return [];
        }

        string query = @"
            SELECT SalaryScale.SalaryScaleId
                , SalaryScale.[Group]
                , SalaryScale.Name
            FROM SalaryScale
            INNER JOIN @SalaryScaleIds AS SalaryScaleIds
                    ON SalaryScaleIds.Id = SalaryScale.SalaryScaleId
        ";
        List<SqlParameter> parameters = [];

        DataTable entityIds = TableParameters.CreateEntityIds(salaryScaleIds);
        parameters.AddTableValued("SalaryScaleIds", "EntityIds", entityIds);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<SalaryScale> salaryScales = [];
        foreach (DataRow row in dataTable.Rows)
        {
            SalaryScale salaryScale = SalaryScaleMapper.FromDataRow(row);
            salaryScales.Add(salaryScale);
        }
        return salaryScales;
    }

    public SalaryScale? GetSalaryScaleBySalaryLevelId(int salaryLevelId) {
        string query = @"
            SELECT SalaryScale.SalaryScaleId
                , SalaryScale.[Group]
                , SalaryScale.Name
            FROM SalaryScale
            INNER JOIN SalaryLevel
                    ON SalaryLevel.SalaryScaleId = SalaryScale.SalaryScaleId
            WHERE SalaryLevel.SalaryLevelId = @SalaryLevelId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SalaryLevelId", SqlDbType.Int, salaryLevelId);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapToSingleOrDefault(SalaryScaleMapper.FromDataRow);
    }
}
