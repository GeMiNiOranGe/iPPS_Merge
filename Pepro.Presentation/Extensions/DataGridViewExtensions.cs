namespace Pepro.Presentation.Extensions;

public static class DataGridViewExtensions
{
    public static void SetupCellStyle(this DataGridView dataGridView)
    {
        dataGridView.AlternatingRowsDefaultCellStyle = new()
        {
            BackColor = ThemeColors.Background.Lighter,
        };

        dataGridView.ColumnHeadersDefaultCellStyle = new()
        {
            BackColor = ThemeColors.Accent.Base,
            Font = new Font(
                "Segoe UI",
                14F,
                FontStyle.Bold,
                GraphicsUnit.Pixel
            ),
            WrapMode = DataGridViewTriState.False,
        };

        dataGridView.DefaultCellStyle = new()
        {
            BackColor = ThemeColors.Background.Base,
            Font = new Font(
                "Segoe UI",
                14F,
                FontStyle.Regular,
                GraphicsUnit.Pixel
            ),
            ForeColor = Color.White,
            SelectionBackColor = ThemeColors.Accent.Dark,
            SelectionForeColor = ThemeColors.Text,
            WrapMode = DataGridViewTriState.True,
        };

        dataGridView.RowHeadersDefaultCellStyle = new()
        {
            BackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor,
            ForeColor = dataGridView.DefaultCellStyle.ForeColor,
        };

        // Applies to newly created rows (typically when binding data or adding
        // a row manually). It can also override DefaultCellStyle.Padding.
        dataGridView.RowTemplate.DefaultCellStyle.Padding = new Padding(4);
    }
}
