using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class SalaryScaleMapper
{
    public static SalaryScale FromDataRow(DataRow row)
    {
        return new SalaryScale()
        {
            SalaryScaleId = row.Field<int>("SalaryScaleId"),
            Group = row.Field<string>("Group") ?? "",
            Name = row.Field<string>("Name") ?? "",
        };
    }
}
