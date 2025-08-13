using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class EmployeePhoneNumberMapper
{
    public static EmployeePhoneNumber FromDataRow(DataRow row)
    {
        return new EmployeePhoneNumber()
        {
            EmployeePhoneNumberId = row.Field<int>("EmployeePhoneNumberId"),
            PhoneNumber = row.Field<string>("PhoneNumber") ?? "",
            EmployeeId = row.Field<string>("EmployeeId") ?? ""
        };
    }
}
