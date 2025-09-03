using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class DepartmentEditorControl
    : PeproEditorControlBase,
    IEditorUserControl<DepartmentDto>
{
    private DepartmentDto _item = null!;
    private EditorMode _mode;

    public DepartmentEditorControl()
    {
        InitializeComponent();

        saveButton.ApplyFlatStyle();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DepartmentDto Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            departmentNameInputField.Text = _item.Name;
            managerInputField.Text = _item.ManagerId.ToString();
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
                EditorMode.Create => "Create a new department",
                EditorMode.Edit => "Edit department",
                _ => throw new InvalidEnumArgumentException(
                    nameof(Mode),
                    (int)_mode,
                    typeof(EditorMode)
                ),
            };
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs())
        {
            MessageBoxWrapper.ShowInformation("FillInformation");
            return;
        }

        if (!int.TryParse(managerInputField.Text, out int managerId))
        {
            return;
        }

        DepartmentDto department = new()
        {
            DepartmentId = _item.DepartmentId,
            Name = departmentNameInputField.Text,
            ManagerId = managerId,
        };

        int result = _mode switch
        {
            EditorMode.Create => DepartmentBusiness.Instance.InsertDepartment(department),
            EditorMode.Edit => DepartmentBusiness.Instance.UpdateDepartment(department),
            _ => throw new InvalidEnumArgumentException(
                nameof(Mode),
                (int)_mode,
                typeof(EditorMode)
            ),
        };

        if (result > 0)
        {
            NotifyDataChanged();
            Close();
            MessageBoxWrapper.ShowInformation("SaveSuccess");
        }
        else
        {
            MessageBoxWrapper.ShowError("SaveFailed");
        }
    }

    private bool ValidateInputs()
    {
        return !string.IsNullOrWhiteSpace(departmentNameInputField.Text)
            && !string.IsNullOrWhiteSpace(managerInputField.Text);
    }
}
