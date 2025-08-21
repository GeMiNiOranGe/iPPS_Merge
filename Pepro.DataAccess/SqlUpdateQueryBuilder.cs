using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Contracts;

namespace Pepro.DataAccess;

class SqlUpdateQueryBuilder(string tableName)
{
    private readonly string _tableName = tableName;
    private readonly List<string> _setClauses = [];
    private readonly List<string> _whereClauses = [];
    private readonly List<SqlParameter> _parameters = [];

    public SqlUpdateQueryBuilder Set<T>(
        string columnName,
        SqlDbType dbType,
        TrackedValue<T> value
    )
    {
        if (value.IsModified)
        {
            _setClauses.Add($"{columnName} = @{columnName}");
            _parameters.Add(columnName, dbType, value.Value);
        }
        return this;
    }

    public SqlUpdateQueryBuilder Set<T>(
        string columnName,
        SqlDbType dbType,
        int size,
        TrackedValue<T> value
    )
    {
        if (value.IsModified)
        {
            _setClauses.Add($"{columnName} = @{columnName}");
            _parameters.Add(columnName, dbType, size, value.Value);
        }
        return this;
    }

    public SqlUpdateQueryBuilder Where(
        string columnName,
        SqlDbType dbType,
        object? value
    )
    {
        _whereClauses.Add($"{columnName} = @{columnName}");
        _parameters.Add(columnName, dbType, value);
        return this;
    }

    public SqlUpdateQueryBuilder Where(
        string columnName,
        SqlDbType dbType,
        int size,
        object? value
    )
    {
        _whereClauses.Add($"{columnName} = @{columnName}");
        _parameters.Add(columnName, dbType, size, value);
        return this;
    }

    public (string query, List<SqlParameter> parameters) Build()
    {
        if (_setClauses.Count == 0)
        {
            return ("", []);
        }

        string query = $@"
            UPDATE {_tableName}
            SET {string.Join(", ", _setClauses)}
            WHERE {string.Join(", ", _whereClauses)}
        ";

        return (query, _parameters);
    }
}
