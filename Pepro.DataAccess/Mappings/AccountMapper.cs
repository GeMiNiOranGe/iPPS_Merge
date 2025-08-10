using System.Data;

namespace Pepro.DataAccess.Mappings;

static class AccountMapper
{
    public static Entities.Account FromDataRow(DataRow row)
    {
        return new Entities.Account()
        {
            AccountId = row.Field<int>("AccountId"),
            Username = row.Field<string>("Username") ?? "",
            Salt = row.Field<byte[]>("Salt") ?? [],
            Password = row.Field<byte[]>("Password") ?? [],
            IsActive = row.Field<bool>("IsActive"),
            EmployeeId = row.Field<string>("EmployeeId") ?? "",
        };
    }
}
