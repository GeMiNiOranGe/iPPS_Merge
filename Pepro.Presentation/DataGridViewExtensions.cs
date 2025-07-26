namespace Pepro.Presentation;

public static class DataGridViewExtensions {
    public static void SetupCellStyle(this DataGridView dataGridView) {
        dataGridView.AlternatingRowsDefaultCellStyle = new() {
            BackColor = ThemeColors.Background.Lighter,
        };

        dataGridView.ColumnHeadersDefaultCellStyle = new() {
            Alignment = DataGridViewContentAlignment.MiddleCenter,
            BackColor = ThemeColors.Accent.Base,
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel),
            ForeColor = Color.White,
        };

        dataGridView.DefaultCellStyle = new () {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = ThemeColors.Background.Base,
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
            ForeColor = Color.White,
            SelectionBackColor = ThemeColors.Accent.Dark,
            SelectionForeColor = ThemeColors.Text,
            WrapMode = DataGridViewTriState.True,
        };
    }
}
