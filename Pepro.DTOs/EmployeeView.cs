namespace Pepro.DTOs;

public class EmployeeView : EmployeeDto
{
    private string _departmentName = "";
    private string _positionTitle = "";

    public string DepartmentName
    {
        get => _departmentName;
        set => _departmentName = value;
    }

    public string PositionTitle
    {
        get => _positionTitle;
        set => _positionTitle = value;
    }
}