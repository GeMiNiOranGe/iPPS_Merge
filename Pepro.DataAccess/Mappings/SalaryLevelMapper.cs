using System.Data;
using Pepro.DTOs;

namespace Pepro.DataAccess.Mappings;

static class SalaryLevelMapper
{
    public static SalaryLevel FromDataRow(DataRow row)
    {
        return new SalaryLevel()
        {
            SalaryLevelId = row.Field<int>("SalaryLevelId"),
            Level = row.Field<string>("Level") ?? "",
            Coefficient = row.Field<decimal>("Coefficient"),
            SalaryScaleId = row.Field<int>("SalaryScaleId"),
        };
    }
}
