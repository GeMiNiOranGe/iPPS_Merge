using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Pepro.Business;

// TODO: Switch to a different Excel library since this one depends on having
// Microsoft Excel installed
public static class ExcelExporter {
    public static void Export(string outputFilePath, DataGridView dataGridView) {
        Excel.Application? excelApp = null;
        Excel.Workbook? workbook = null;
        Excel.Worksheet? worksheet = null;

        try {
            excelApp = new() {
                Visible = true
            };
            workbook = excelApp.Workbooks.Add();
            worksheet = (Excel.Worksheet)workbook.Sheets[1];

            int rowIndex = 1;
            int columnIndex = 1;

            foreach (DataGridViewColumn header in dataGridView.Columns) {
                worksheet.Cells[rowIndex, columnIndex++] = header.HeaderText;
            }

            foreach (DataGridViewRow row in dataGridView.Rows) {
                rowIndex++;
                columnIndex = 1;
                foreach (DataGridViewCell cell in row.Cells) {
                    worksheet.Cells[rowIndex, columnIndex++] = cell.Value?.ToString();
                }
            }

            worksheet.Columns.AutoFit();

            // Save the workbook and close Excel
            workbook.SaveAs(outputFilePath);
            workbook.Close();
            excelApp.Quit();
        }
        finally {
            // Release COM objects to prevent memory leaks
            ReleaseComObject(worksheet);
            ReleaseComObject(workbook);
            ReleaseComObject(excelApp);

            worksheet = null;
            workbook = null;
            excelApp = null;

            // Force garbage collection to finalize any remaining COM references
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }

    private static void ReleaseComObject(object? obj) {
        try {
            if (obj != null && Marshal.IsComObject(obj)) {
                Marshal.ReleaseComObject(obj);
            }
        }
        catch {
            // Ignore errors when releasing COM
        }
    }
}
