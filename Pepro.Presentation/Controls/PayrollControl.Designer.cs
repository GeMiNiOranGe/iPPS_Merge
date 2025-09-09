namespace Pepro.Presentation.Controls;

partial class PayrollControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        payrollDataGridView = new PeproDataGridView();
        fullNameColumn = new DataGridViewTextBoxColumn();
        scaleNameColumn = new DataGridViewTextBoxColumn();
        scaleGroupColumn = new DataGridViewTextBoxColumn();
        levelColumn = new DataGridViewTextBoxColumn();
        coefficientColumn = new DataGridViewTextBoxColumn();
        basicSalaryColumn = new DataGridViewTextBoxColumn();
        positionAllowancePercentColumn = new DataGridViewTextBoxColumn();
        positionAllowanceColumn = new DataGridViewTextBoxColumn();
        grossSalaryColumn = new DataGridViewTextBoxColumn();
        exportButton = new Button();
        ((System.ComponentModel.ISupportInitialize)payrollDataGridView).BeginInit();
        SuspendLayout();
        // 
        // payrollDataGridView
        // 
        payrollDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        payrollDataGridView.Columns.AddRange(new DataGridViewColumn[] { fullNameColumn, scaleNameColumn, scaleGroupColumn, levelColumn, coefficientColumn, basicSalaryColumn, positionAllowancePercentColumn, positionAllowanceColumn, grossSalaryColumn });
        payrollDataGridView.Location = new Point(16, 120);
        payrollDataGridView.Margin = new Padding(16);
        payrollDataGridView.Name = "payrollDataGridView";
        payrollDataGridView.Size = new Size(1032, 545);
        payrollDataGridView.TabIndex = 2;
        // 
        // fullNameColumn
        // 
        fullNameColumn.DataPropertyName = "EmployeeFullName";
        fullNameColumn.HeaderText = "Full name";
        fullNameColumn.Name = "fullNameColumn";
        fullNameColumn.ReadOnly = true;
        fullNameColumn.Width = 86;
        // 
        // scaleNameColumn
        // 
        scaleNameColumn.DataPropertyName = "SalaryScaleName";
        scaleNameColumn.HeaderText = "Scale name";
        scaleNameColumn.Name = "scaleNameColumn";
        scaleNameColumn.ReadOnly = true;
        scaleNameColumn.Width = 94;
        // 
        // scaleGroupColumn
        // 
        scaleGroupColumn.DataPropertyName = "SalaryScaleGroup";
        scaleGroupColumn.HeaderText = "Scale group";
        scaleGroupColumn.Name = "scaleGroupColumn";
        scaleGroupColumn.ReadOnly = true;
        scaleGroupColumn.Width = 97;
        // 
        // levelColumn
        // 
        levelColumn.DataPropertyName = "SalaryLevel";
        levelColumn.HeaderText = "Level";
        levelColumn.Name = "levelColumn";
        levelColumn.ReadOnly = true;
        levelColumn.Width = 65;
        // 
        // coefficientColumn
        // 
        coefficientColumn.DataPropertyName = "SalaryLevelCoefficient";
        coefficientColumn.HeaderText = "Coefficient";
        coefficientColumn.Name = "coefficientColumn";
        coefficientColumn.ReadOnly = true;
        coefficientColumn.Width = 98;
        // 
        // basicSalaryColumn
        // 
        basicSalaryColumn.DataPropertyName = "BasicSalary";
        basicSalaryColumn.HeaderText = "Basic salary";
        basicSalaryColumn.Name = "basicSalaryColumn";
        basicSalaryColumn.ReadOnly = true;
        basicSalaryColumn.Width = 95;
        // 
        // positionAllowancePercentColumn
        // 
        positionAllowancePercentColumn.DataPropertyName = "PositionAllowancePercent";
        positionAllowancePercentColumn.HeaderText = "Position allowance percent";
        positionAllowancePercentColumn.Name = "positionAllowancePercentColumn";
        positionAllowancePercentColumn.ReadOnly = true;
        positionAllowancePercentColumn.Width = 178;
        // 
        // positionAllowanceColumn
        // 
        positionAllowanceColumn.DataPropertyName = "PositionAllowance";
        positionAllowanceColumn.HeaderText = "Position allowance";
        positionAllowanceColumn.Name = "positionAllowanceColumn";
        positionAllowanceColumn.ReadOnly = true;
        positionAllowanceColumn.Width = 133;
        // 
        // grossSalaryColumn
        // 
        grossSalaryColumn.DataPropertyName = "GrossSalary";
        grossSalaryColumn.HeaderText = "Gross salary";
        grossSalaryColumn.Name = "grossSalaryColumn";
        grossSalaryColumn.ReadOnly = true;
        grossSalaryColumn.Width = 99;
        // 
        // exportButton
        // 
        exportButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        exportButton.Location = new Point(16, 64);
        exportButton.Margin = new Padding(16, 16, 0, 0);
        exportButton.Name = "exportButton";
        exportButton.Size = new Size(112, 40);
        exportButton.TabIndex = 1;
        exportButton.Text = "Export";
        exportButton.Click += ExportButton_Click;
        // 
        // PayrollControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(exportButton);
        Controls.Add(payrollDataGridView);
        HeaderText = "Payroll";
        Name = "PayrollControl";
        ReturnButtonVisible = false;
        Load += PayrollControl_Load;
        Controls.SetChildIndex(payrollDataGridView, 0);
        Controls.SetChildIndex(exportButton, 0);
        ((System.ComponentModel.ISupportInitialize)payrollDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PeproDataGridView payrollDataGridView;
    private Button exportButton;
    private DataGridViewTextBoxColumn fullNameColumn;
    private DataGridViewTextBoxColumn scaleNameColumn;
    private DataGridViewTextBoxColumn scaleGroupColumn;
    private DataGridViewTextBoxColumn levelColumn;
    private DataGridViewTextBoxColumn coefficientColumn;
    private DataGridViewTextBoxColumn basicSalaryColumn;
    private DataGridViewTextBoxColumn positionAllowancePercentColumn;
    private DataGridViewTextBoxColumn positionAllowanceColumn;
    private DataGridViewTextBoxColumn grossSalaryColumn;
}
