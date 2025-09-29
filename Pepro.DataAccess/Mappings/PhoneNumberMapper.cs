using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class PhoneNumberMapper
{
    public static PhoneNumber FromDataRow(DataRow row)
    {
        return new PhoneNumber()
        {
            PhoneNumberId = row.Field<int>("PhoneNumberId"),
            Number = row.Field<string>("Number") ?? "",
            EmployeeId = row.Field<int>("EmployeeId"),
        };
    }
}
