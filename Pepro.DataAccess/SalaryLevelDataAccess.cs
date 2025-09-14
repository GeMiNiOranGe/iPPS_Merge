using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class SalaryLevelDataAccess {
    private static SalaryLevelDataAccess? instance;

    public static SalaryLevelDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryLevelDataAccess() { }

    public List<SalaryLevel> GetSalaryLevelsBySalaryLevelIds(List<int> salaryLevelIds)
    {
        if (salaryLevelIds == null || salaryLevelIds.Count == 0)
        {
            return [];
        }

        string query = @"
            SELECT SalaryLevel.SalaryLevelId
                , SalaryLevel.Level
                , SalaryLevel.Coefficient
                , SalaryLevel.SalaryScaleId
            FROM SalaryLevel
            INNER JOIN @SalaryLevelIds AS SalaryLevelIds
                    ON SalaryLevelIds.Id = SalaryLevel.SalaryLevelId
        ";
        List<SqlParameter> parameters = [];

        DataTable entityIds = TableParameters.CreateEntityIds(salaryLevelIds);
        parameters.AddTableValued("SalaryLevelIds", "EntityIds", entityIds);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<SalaryLevel> salaryLevels = [];
        foreach (DataRow row in dataTable.Rows)
        {
            SalaryLevel salaryLevel = SalaryLevelMapper.FromDataRow(row);
            salaryLevels.Add(salaryLevel);
        }
        return salaryLevels;
    }

    public List<SalaryLevel> GetSalaryLevelsBySalaryScaleId(int salaryScaleId) {
        string query = @"
            SELECT SalaryLevel.SalaryLevelId
                , SalaryLevel.Level
                , SalaryLevel.Coefficient
                , SalaryLevel.SalaryScaleId
            FROM SalaryLevel
            WHERE SalaryLevel.SalaryScaleId = @SalaryScaleId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SalaryScaleId", SqlDbType.Int, salaryScaleId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<SalaryLevel> salaryLevels = [];
        foreach (DataRow row in dataTable.Rows) {
            SalaryLevel salaryLevel = SalaryLevelMapper.FromDataRow(row);
            salaryLevels.Add(salaryLevel);
        }
        return salaryLevels;
    }
}
