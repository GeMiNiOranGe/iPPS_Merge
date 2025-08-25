using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class AccountMapper
{
    public static Account FromDataRow(DataRow row)
    {
        return new Account()
        {
            AccountId = row.Field<int>("AccountId"),
            Username = row.Field<string>("Username") ?? "",
            Salt = row.Field<byte[]>("Salt") ?? [],
            Password = row.Field<byte[]>("Password") ?? [],
            IsActive = row.Field<bool>("IsActive"),
            EmployeeId = row.Field<int>("EmployeeId"),
        };
    }
}
