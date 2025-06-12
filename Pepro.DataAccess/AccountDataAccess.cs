using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.DTOs;

namespace Pepro.DataAccess;

public class AccountDataAccess {
    private static AccountDataAccess? instance;

    public static AccountDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private AccountDataAccess() { }

    public Account? GetAccountDetails(string accountName) {
        string procedureName = "usp_GetAccountDetails";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "AccountName",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = accountName
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteProcedure(procedureName, parameters);
        if (dataTable.Rows.Count == 0)
        {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        Account? account = new() {
            AccountId = row.Field<int?>("AccountId") ?? 0,
            Username = row.Field<string>("Username") ?? "",
            Salt = row.Field<byte[]>("Salt") ?? [],
            Password = row.Field<byte[]>("Password") ?? [],
            IsActive = row.Field<bool?>("IsActive") ?? false,
            EmployeeId = row.Field<string>("EmployeeId") ?? ""
        };
        return account;
    }
}
