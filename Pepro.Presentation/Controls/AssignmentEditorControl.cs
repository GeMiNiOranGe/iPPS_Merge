using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class AssignmentEditorControl : PeproEditorControlBase, IEditorUserControl<AssignmentDto>
{
    private AssignmentDto _item = null!;
    private EditorMode _mode;

    public AssignmentEditorControl()
    {
        Initialize();
    }

    public AssignmentEditorControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public AssignmentDto Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            assignmentNameInputField.Text = _item.Name;
            isPublicToProjectCheckBox.Checked = _item.IsPublicToProject;
            isPublicToDepartmentCheckBox.Checked = _item.IsPublicToDepartment;
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
                EditorMode.Create => "Create a new assignment",
                EditorMode.Edit => "Edit assignment",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize()
    {
        InitializeComponent();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        /*
        if (projectIdTextBox.Text == "" || taskIdTextBox.Text == "" 
            || managerIdTextBox.Text == "" || accessTextBox.Text == "" 
            || publicDepartmentTextBox.Text == "" || publicProjectTextBox.Text == "")
        {
            MessageBox.Show("Không được để trống thông tin!");
            return;
        }
        try
        {
            if (MessageBox.Show("Bạn có muốn lưu công việc này?", "Xác nhận",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SqlCommand("INSERT INTO JOB VALUES (@idJob,@idMng,@name,@access,@status,@prjPub,@depPub,@idPrj)", conn);
                cmd.Parameters.AddWithValue("@idJob", taskIdTextBox.Text);
                cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                cmd.Parameters.AddWithValue("@name", taskNameTextBox.Text);
                cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@prjPub", publicProjectTextBox.Text);
                cmd.Parameters.AddWithValue("@depPub", publicDepartmentTextBox.Text);
                cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ResetTextBox();
                MessageBox.Show("Lưu công việc thành công!");
                this.Dispose();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        */
    }

    /*
    private void UpdateButton_Click(object sender, EventArgs e)
    {
        if (projectIdTextBox.Text == "" || taskIdTextBox.Text == ""
            || managerIdTextBox.Text == "" || accessTextBox.Text == ""
            || publicDepartmentTextBox.Text == "" || publicProjectTextBox.Text == "")
        {
            MessageBox.Show("Không được để trống thông tin!");
            return;
        }
        try
        {
            if (MessageBox.Show("Bạn có muốn cập nhật công việc này?", "Xác nhận",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd = new SqlCommand($"UPDATE JOB SET ID=@idJob, JOB_MANAGER_ID=@idMng, NAME=@name, ACCESS_RIGHT=@access, STATUS=@status, PROJECT_PUBLIC=@prjPub, DEPARTMENT_PUBLIC=@depPub, PROJECT_ID=@idPrj WHERE ID='{taskIdTextBox.Text}'", conn);
                cmd.Parameters.AddWithValue("@idJob", taskIdTextBox.Text);
                cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                cmd.Parameters.AddWithValue("@name", taskNameTextBox.Text);
                cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                cmd.Parameters.AddWithValue("@prjPub", publicProjectTextBox.Text);
                cmd.Parameters.AddWithValue("@depPub", publicDepartmentTextBox.Text);
                cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                ResetTextBox();
                MessageBox.Show("Sửa công việc thành công!");
                this.Dispose();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ResetTextBox();
        saveButton.Enabled = true;
        updateButton.Enabled = false;
    }

    private void ResetTextBox()
    {
        taskNameTextBox.ResetText();
        taskIdTextBox.ResetText();
        managerIdTextBox.ResetText();
        accessTextBox.ResetText();
        statusTextBox.ResetText();
        publicProjectTextBox.ResetText();
        publicDepartmentTextBox.ResetText();
        projectIdTextBox.ResetText();
    }

    private void ClosePictureBox_Click(object sender, EventArgs e)
    {
        this.Dispose();
    }
    */
}
