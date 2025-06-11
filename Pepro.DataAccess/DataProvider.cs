using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace Pepro.DataAccess {
    internal class DataProvider {
        private const string CONNECTION_STRING = @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private static DataProvider instance;

        public static DataProvider Instance {
            get => instance ?? (instance = new DataProvider());
            private set => instance = value;
        }

        private DataProvider() { }

        public SqlConnection CreateConnection() {
            return new SqlConnection(CONNECTION_STRING);
        }

        public SqlCommand CreateCommand(string query) {
            var connection = CreateConnection();
            return new SqlCommand(query, connection);
        }

        public void OpenConnection(SqlConnection connection) {
            var state = connection.State;
            if (state == ConnectionState.Closed || state == ConnectionState.Broken) {
                try {
                    connection.Open();
                }
                catch (SqlException ex) {
                    throw ex;
                }
            }
        }

        public void CloseConnection(SqlConnection connection) {
            if (connection == null) {
                return;
            }
            try {
                connection.Close();
            }
            catch (SqlException ex) {
                throw ex;
            }
        }

        public DataTable ExecuteQuery(string query) {
            var dataTable = new DataTable();
            using (SqlCommand command = CreateCommand(query)) {
                using (var dataAdapter = new SqlDataAdapter(command)) {
                    try {
                        dataAdapter.Fill(dataTable);
                    }
                    catch (SqlException ex) {
                        throw ex;
                    }
                }
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

        public int ExecuteNonQuery(string query, object[] parameters = null) {
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
                var sqlCommand = new SqlCommand(query, connection);

                // Get data 
                try {
                    objData = sqlCommand.ExecuteScalar();
                }
                catch (SqlException ex) {
                    throw ex;
                }

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

        public DataTable ExecuteProcedure(string query, SqlParameter[] parameters = null) {
            var dataTable = new DataTable();
            using (SqlCommand command = CreateCommand(query)) {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null) {
                    command.Parameters.AddRange(parameters);
                }

                using (var dataAdapter = new SqlDataAdapter(command)) {
                    try {
                        dataAdapter.Fill(dataTable);
                    }
                    catch (SqlException ex) {
                        throw ex;
                    }
                }
            }
            return dataTable;
        }
    }
}
