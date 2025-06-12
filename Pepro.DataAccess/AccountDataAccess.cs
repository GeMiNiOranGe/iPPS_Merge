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

    public void Login(
        string username,
        string password,
        out int result,
        out int roleID,
        out string name
    ) {
        string procedureName = "spLogin";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "USERNAME",
                SqlDbType = SqlDbType.VarChar,
                Value = username
            },
            new()
            {
                ParameterName = "PASSWORD",
                SqlDbType = SqlDbType.VarChar,
                Value = password
            },
            new()
            {
                ParameterName = "KETQUA",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            },
            new()
            {
                ParameterName = "ROLEID",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            },
            new()
            {
                ParameterName = "NAME",
                SqlDbType = SqlDbType.VarChar,
                Size = DatabaseConstants.MAX_SIZE,
                Direction = ParameterDirection.Output
            }
        ];
        _ = DataProvider.Instance.ExecuteProcedure(procedureName, parameters);

        // Lấy kết quả đăng nhập, roleID và name từ kết quả trả về của stored procedure
        result = Convert.ToInt32(parameters[2].Value);
        roleID = parameters[3].Value == DBNull.Value ? 0 : Convert.ToInt32(parameters[3].Value);
        name = parameters[4].Value.ToString() ?? "";
    }

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
