using Microsoft.Data.SqlClient;

namespace Pepro.DataAccess.Utilities;

public readonly record struct QueryBuildResult(
    string Query,
    List<SqlParameter> Parameters
);
