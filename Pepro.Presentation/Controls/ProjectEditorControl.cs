using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class ProjectEditorControl : PeproEditorControlBase, IEditorUserControl<ProjectDto>
{
    private ProjectDto _item = null!;
    private EditorMode _mode;

    public ProjectEditorControl()
    {
        Initialize();
    }

    public ProjectEditorControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ProjectDto Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            projectNameInputField.Text = _item.Name;
            customerNameInputField.Text = _item.CustomerName;
            managerIdInputField.Text = _item.ManagerId.ToString();
            startDateTimePicker.SetValue(_item.StartDate);
            endDateTimePicker.SetValue(_item.EndDate);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EditorMode Mode
    {
        get => _mode;
        set
        {
            _mode = value;
            HeaderText = _mode switch
            {
                EditorMode.Create => "Create a new project",
                EditorMode.Edit => "Edit project",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize()
    {
        InitializeComponent();

        saveButton.ApplyFlatStyle();
    }

    private void ProjectEditorControl_Load(object sender, EventArgs e)
    {
        statusComboBoxField.DisplayMember = nameof(StatusDto.Name);
        statusComboBoxField.ValueMember = nameof(StatusDto.StatusId);

        statusComboBoxField.DataSource = StatusBusiness.Instance.GetStatuses();

        switch (_mode) {
        case EditorMode.Create:
            SetupCreateMode();
            break;
        case EditorMode.Edit:
            SetupEditMode();
            break;
        }
    }

    private void SetupCreateMode()
    {
        statusComboBoxField.SelectedIndex = -1;
    }

    private void SetupEditMode()
    {
        statusComboBoxField.SelectedValue = _item.StatusId;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs())
        {
            MessageBoxWrapper.ShowInformation("FillInformation");
            return;
        }
        /*
        try
        {
            if(MessageBox.Show("Bạn có muốn lưu dự án này?", "Xác nhận",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SqlCommand("INSERT INTO PROJECT VALUES(@idPrj,@name,@access,@status,@cus,@idMng)", conn);
                cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                cmd.Parameters.AddWithValue("@name", projectNameTextBox.Text);
                cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@cus", customerTextBox.Text);
                cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);

                cmd2 = new SqlCommand("INSERT INTO IMPLEMENT_PROJECT VALUES(@idDep,@idPrj2,@start,@end)", conn);
                cmd2.Parameters.AddWithValue("@idDep", departmentTextBox.Text);
                cmd2.Parameters.AddWithValue("@idPrj2", projectIdTextBox.Text);
                cmd2.Parameters.AddWithValue("@start", startDateTimePicker.Text);
                cmd2.Parameters.AddWithValue("@end", endDateTimePicker.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                ResetTextBox();
                MessageBox.Show("Lưu dự án thành công!");
                this.Dispose();
            }
        }
        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message);
        }
        */
        if (
            !int.TryParse(managerIdInputField.Text, out int managerId)
            || !int.TryParse(
                statusComboBoxField.SelectedValue?.ToString(),
                out int statusId
            )
        )
        {
            return;
        }

        ProjectDto project = new()
        {
            ProjectId = _item.ProjectId,
            Name = projectNameInputField.Text.Trim(),
            CustomerName = customerNameInputField.Text.Trim(),
            ManagerId = managerId,
            StartDate = startDateTimePicker.Value,
            EndDate = endDateTimePicker.Value,
            StatusId = statusId,
        };

        switch (Mode)
        {
            case EditorMode.Create:
                HandleCreateMode(project);
                break;
            case EditorMode.Edit:
                HandleEditMode(project);
                break;
        }
    }

    private void HandleCreateMode(ProjectDto project)
    {
        // _ = ProjectBusiness.Instance.InsertProject(project);

        NotifyDataChanged();
        Close();
        MessageBoxWrapper.ShowInformation("InsertSuccess");
    }

    private void HandleEditMode(ProjectDto project)
    {
        int result = ProjectBusiness.Instance.UpdateProject(project);
        if (result == 0)
        {
            return;
        }

        NotifyDataChanged();
        Close();
        MessageBoxWrapper.ShowInformation("UpdateSuccess");
    }

    private bool ValidateInputs()
    {
        return !string.IsNullOrWhiteSpace(projectNameInputField.Text)
            && !string.IsNullOrWhiteSpace(customerNameInputField.Text)
            && !string.IsNullOrWhiteSpace(
                statusComboBoxField.SelectedValue?.ToString()
            );
    }

    /*
    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (projectIdTextBox.Text == "" || projectNameTextBox.Text == ""
            || accessTextBox.Text == "" || statusTextBox.Text == ""
            || customerTextBox.Text == "" || managerIdTextBox.Text == ""
            || departmentTextBox.Text == "" || startDateTimePicker.Text == "" || endDateTimePicker.Text == "")
        {
            MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
            return;
        }
        try
        {
            if (MessageBox.Show("Bạn có muốn cập nhật dự án này?", "Xác nhận",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.Open();
                string updateProjectQuery = @"
                        UPDATE PROJECT
                        SET NAME = @name,
                            ACCESS_RIGHT = @access,
                            STATUS = @status,
                            CUSTOMER_NAME = @cus,
                            PROJECT_MANAGER_ID = @idMng
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                cmd = new SqlCommand(updateProjectQuery, conn);
                cmd.Parameters.AddWithValue("@name", projectNameTextBox.Text);
                cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@cus", customerTextBox.Text);
                cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                cmd.ExecuteNonQuery();

                string updateImplementProjectQuery = @"
                        UPDATE IMPLEMENT_PROJECT
                        SET DEPARTMENT_ID = @idDep,
                            PROJECT_START_DATE = @start,
                            PROJECT_END_DATE = @end
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                cmd = new SqlCommand(updateImplementProjectQuery, conn);
                cmd.Parameters.AddWithValue("@idDep", departmentTextBox.Text);
                cmd.Parameters.AddWithValue("@start", startDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@end", endDateTimePicker.Text);
                cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sửa dự án thành công!");
                this.Dispose();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    */
}
