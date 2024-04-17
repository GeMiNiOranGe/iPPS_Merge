using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DataAccess {
    internal class DataProvider {
        private const string CONNECTION_STRING = @"";

        #region Singleton Design Pattern
        private static DataProvider instance;

        public static DataProvider Instance {
            get => instance ?? (instance = new DataProvider());
            private set => instance = value;
        }

        private DataProvider() { }
        #endregion

        public SqlConnection GetConnection() {
            return new SqlConnection(CONNECTION_STRING);
        }
        public SqlCommand GetCommand(string query) {
            var sqlConnection = GetConnection();
            return new SqlCommand(query, sqlConnection);
        }

        public void OpenConnection(SqlConnection sqlConnection) {
            var state = sqlConnection.State;
            if (state == ConnectionState.Closed ||
                state == ConnectionState.Broken) {
                try { sqlConnection.Open(); }
                catch (SqlException ex) { throw ex; }
            }
        }
        public void OpenConnection(SqlCommand sqlCommand) {
            OpenConnection(sqlCommand.Connection);
        }

        public void CloseConnection(SqlConnection sqlConnection) {
            if (sqlConnection != null) {
                try { sqlConnection.Close(); }
                catch (SqlException ex) { throw ex; }
            }
        }
        public void CloseConnection(SqlCommand sqlCommand) {
            CloseConnection(sqlCommand.Connection);
        }

        public DataTable ExecuteQuery(string query) {
            var dataTable = new DataTable();
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);
                var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // Fill dataTable with returned query
                try { sqlDataAdapter.Fill(dataTable); }
                catch (SqlException ex) { throw ex; }

                CloseConnection(sqlConnection);
            }
            return dataTable;
        }

        /*public int ExecuteNonQuery(string query)
        {
            int iData = 0;
            using (var sqlConnection = GetConnection())
            {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);

                // Execute CRUD
                try { iData = sqlCommand.ExecuteNonQuery(); }
                catch (SqlException ex) { throw ex; }

                iData = sqlCommand.ExecuteNonQuery();
                CloseConnection(sqlConnection);
            }
            return iData;
        }*/
        public int ExecuteNonQuery(string query, object[] parameter = null) {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null) {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara) {
                        if (item.Contains('@')) {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
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
            using (var sqlConnection = GetConnection()) {
                OpenConnection(sqlConnection);
                var sqlCommand = new SqlCommand(query, sqlConnection);

                // Get data 
                try { objData = sqlCommand.ExecuteScalar(); }
                catch (SqlException ex) { throw ex; }

                CloseConnection(sqlConnection);
            }
            return objData;
        }

        public void OpenConnection() {
            throw new NotImplementedException();
        }
    }
}
