using System.Data;

namespace Pepro.DataAccess.Extensions;

static class DataTableExtensions
{
    public static TSource? MapToSingleOrDefault<TSource>(
        this DataTable dataTable,
        Func<DataRow, TSource> map
    )
        where TSource : class
    {
        if (dataTable.Rows.Count == 0)
        {
            return default;
        }

        if (dataTable.Rows.Count == 1)
        {
            return map(dataTable.Rows[0]);
        }

        throw new InvalidOperationException(
            "Sequence contains more than one element"
        );
    }

    public static IEnumerable<TSource> MapMany<TSource>(
        this DataTable dataTable,
        Func<DataRow, TSource> map
    )
    {
        return dataTable.Rows.Cast<DataRow>().Select(map);
    }
}
