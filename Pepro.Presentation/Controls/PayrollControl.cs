namespace Pepro.Presentation.Controls;

public partial class PayrollControl : PeproMediatedUserControl
{
    public PayrollControl()
    {
        InitializeComponent();
        payrollDataGridView.SetupCellStyle();

        exportButton.ApplyFlatStyle();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new()
        {
            FileName = "Payroll-" + DateTime.Now.ToString("ddMMyyyy-HHmmss"),
            Filter = "Excel Files|*.xlsx",
            Title = "Save Excel File"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            ExcelExporter.Export(saveFileDialog.FileName, payrollDataGridView);
        }
    }
}
