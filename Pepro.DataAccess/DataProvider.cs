using System.Data;
using Microsoft.Data.SqlClient;

namespace Pepro.DataAccess;

internal class DataProvider {
    private const string CONNECTION_STRING = @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

    private static DataProvider? instance;

    private DataProvider() { }

    public static DataProvider Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    public SqlConnection CreateConnection() {
        return new SqlConnection(CONNECTION_STRING);
    }

    public SqlCommand CreateCommand(string query) {
        SqlConnection connection = CreateConnection();
        return new SqlCommand(query, connection);
    }

    public void OpenConnection(SqlConnection connection) {
        ConnectionState state = connection.State;
        if (state == ConnectionState.Closed || state == ConnectionState.Broken) {
            connection.Open();
        }
    }

    public void CloseConnection(SqlConnection connection) {
        if (connection == null) {
            return;
        }
        connection.Close();
    }

    public DataTable ExecuteQuery(string query) {
        DataTable dataTable = new();
        using (SqlCommand command = CreateCommand(query)) {
            using SqlDataAdapter dataAdapter = new(command);
            dataAdapter.Fill(dataTable);
        }
        return dataTable;
    }

    /* 
    public int ExecuteNonQuery(string query) {
        int iData = 0;
        using (var connection = CreateConnection()) {
            OpenConnection(connection);
            var sqlCommand = new SqlCommand(query, connection);

            // Execute CRUD
            try { iData = sqlCommand.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }

            iData = sqlCommand.ExecuteNonQuery();
            CloseConnection(connection);
        }
        return iData;
    }
     */

    public int ExecuteNonQuery(string query, object[]? parameters = null) {
        int numberOfRowsAffected = 0;
        using (SqlCommand command = CreateCommand(query)) {
            if (parameters != null) {
                string[] listParam = query.Split(' ');
                int i = 0;
                foreach (string item in listParam) {
                    if (item.Contains('@')) {
                        command.Parameters.AddWithValue(item, parameters[i]);
                        i++;
                    }
                }
            }

            OpenConnection(command.Connection);
            numberOfRowsAffected = command.ExecuteNonQuery();
            CloseConnection(command.Connection);
        }
        return numberOfRowsAffected;
    }

    /// <summary>
    ///     Executes the query, and returns the first column of the first row in the result
    ///     set returned by the query. Additional columns or rows are ignored.
    /// </summary>
    /// <param name="query">query script.</param>
    /// <returns>
    ///     The first column of the first row in the result set, or a null reference (Nothing
    ///     in Visual Basic) if the result set is empty. Returns a maximum of 2033 characters.
    /// </returns>
    public object ExecuteScalar(string query) {
        object objData = 0;
        using (SqlConnection connection = CreateConnection()) {
            OpenConnection(connection);
            SqlCommand sqlCommand = new(query, connection);

            // Get data 
            objData = sqlCommand.ExecuteScalar();

            CloseConnection(connection);
        }
        return objData;
    }

    public void ExecuteReader(string query, out SqlDataReader dataReader) {
        throw new NotImplementedException();
        /*
        using (var connection = CreateConnection()) {
            OpenConnection(connection);
            var sqlCommand = new SqlCommand(query, connection);
            try {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (SqlException ex) {
                throw ex;
            }
            CloseConnection(connection);
        }
        */
    }

    public DataTable ExecuteProcedure(string query, SqlParameter[]? parameters = null) {
        DataTable dataTable = new();
        using (SqlCommand command = CreateCommand(query)) {
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null) {
                command.Parameters.AddRange(parameters);
            }

            using SqlDataAdapter dataAdapter = new(command);
            dataAdapter.Fill(dataTable);
        }
        return dataTable;
    }
}
