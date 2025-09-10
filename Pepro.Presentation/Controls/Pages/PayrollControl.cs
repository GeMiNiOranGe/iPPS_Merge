using Pepro.Business;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class PayrollControl : PeproMediatedUserControl
{
    public PayrollControl()
    {
        InitializeComponent();
        payrollDataGridView.SetupCellStyle();
        fullNameColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        exportButton.ApplyFlatStyle();
    }

    private void LoadPayroll()
    {
        payrollDataGridView.DataSource = SalaryBusiness.Instance.GetPayroll();
    }

    private void PayrollControl_Load(object sender, EventArgs e)
    {
        LoadPayroll();
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
