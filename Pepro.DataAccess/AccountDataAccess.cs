using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;

namespace Pepro.DataAccess;

public class AccountDataAccess {
    private static AccountDataAccess? instance;

    public static AccountDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private AccountDataAccess() { }

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
            SELECT AccountId
                , Username
                , Salt
                , Password
                , EmployeeId
                , IsActive
            FROM Account
            WHERE Username = @SearchValue
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(
            query,
            [.. parameters]
        );
        if (dataTable.Rows.Count == 0)
        {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return AccountMapper.FromDataRow(row);
    }
}
