using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeInformationControl : PeproMediatedUserControl
{
    private string _employeeId = "";

    public EmployeeInformationControl()
    {
        Initialize();
    }

    public EmployeeInformationControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required string EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    private void Initialize()
    {
        InitializeComponent();
    }

    private void EmployeeInformationControl_Load(object sender, EventArgs e)
    {
        Employee employee = EmployeeBusiness.Instance.GetEmployeeByEmployeeId(_employeeId);
        employeeIdInputField.Text = employee.EmployeeId;
        fullNameInputField.Text = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;

        RadioButton genderRadioButton = employee.Gender switch {
            true => maleRadioButton,
            false => femaleRadioButton,
            _ => otherRadioButton,
        };
        genderRadioButton.Checked = true;

        dateOfBirthDateTimePicker.Value = employee.DateOfBirth;
        citizenIdInputField.Text = employee.CitizenId;
        /*
        CRole getRole = EmployeeBusiness.Instance.GetRolebyEmployeeID(_employeeId);
        roleTextBox.Text = getRole.Name;
        */
        Department department = DepartmentBusiness.Instance.GetDepartmentByDepartmentId(employee.DepartmentId);
        departmentInputField.Text = department.Name;

        string[] projectNames = ProjectBusiness.Instance.GetProjectNamesByEmployeeId(_employeeId);
        assignedProjectsComboBoxField.DataSource = projectNames.Length != 0 ? projectNames : ["Không tìm thấy"];

        string[] phoneNumbers = EmployeeBusiness.Instance.GetPhoneNumbersByEmployeeId(_employeeId);
        phoneNumberComboBoxField.DataSource = phoneNumbers.Length != 0 ? phoneNumbers : ["Không tìm thấy"];
    }
}
