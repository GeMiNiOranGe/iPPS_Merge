using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;

namespace Pepro.DataAccess;

public class AccountDataAccess {
    private static AccountDataAccess? _instance;

    public static AccountDataAccess Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private AccountDataAccess() { }

    public int InsertAccount(Account account) {
        string query = @"
            INSERT INTO [Account]
            (
                [Username]
                , [Password]
                , [Salt]
                , [IsActive]
                , [EmployeeId]
            )
            VALUES
            (
                @Username
                , @Password
                , @Salt
                , @IsActive
                , @EmployeeId
            )
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("Username", SqlDbType.VarChar, 255, account.Username);
        parameters.Add("Password", SqlDbType.VarBinary, DatabaseConstants.MAX_SIZE, account.Password);
        parameters.Add("Salt", SqlDbType.VarBinary, DatabaseConstants.MAX_SIZE, account.Salt);
        parameters.Add("IsActive", SqlDbType.Bit, account.IsActive);
        parameters.Add("EmployeeId", SqlDbType.VarChar, 10, account.EmployeeId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    /// <summary>
    ///     Finds an account using a flexible search value (e.g., username, or email).
    /// </summary>
    /// <param name="searchValue">
    ///     The string value used to search across multiple account fields.
    /// </param>
    /// <returns>
    ///     The matching <see cref="Account"/>, or null if not found.
    /// </returns>
    public Account? FindAccount(string searchValue)
    {
        string query = @"
            SELECT Account.AccountId
                , Account.Username
                , Account.Salt
                , Account.Password
                , Account.EmployeeId
                , Account.IsActive
            FROM Account
            WHERE Account.Username = @SearchValue
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapToSingleOrDefault(AccountMapper.FromDataRow);
    }
}
