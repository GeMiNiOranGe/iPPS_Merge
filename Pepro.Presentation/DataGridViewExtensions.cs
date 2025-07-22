namespace Pepro.Presentation;

public static class DataGridViewExtensions {
    public static void SetupCellStyle(this DataGridView dataGridView) {
        dataGridView.AlternatingRowsDefaultCellStyle = new() {
            BackColor = Color.FromArgb(70, 70, 70),
        };

        dataGridView.ColumnHeadersDefaultCellStyle = new() {
            Alignment = DataGridViewContentAlignment.MiddleCenter,
            BackColor = Color.FromArgb(34, 130, 253),
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel),
            ForeColor = Color.White,
        };

        dataGridView.DefaultCellStyle = new () {
            Alignment = DataGridViewContentAlignment.MiddleLeft,
            BackColor = Color.FromArgb(25, 25, 25),
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
            ForeColor = Color.White,
            SelectionBackColor = SystemColors.Highlight,
            SelectionForeColor = SystemColors.HighlightText,
            WrapMode = DataGridViewTriState.True,
        };
    }
}
