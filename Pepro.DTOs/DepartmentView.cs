namespace Pepro.DTOs;

public class DepartmentView : DepartmentDto
{
    private string _managerFullName = "";

    public string ManagerFullName
    {
        get => _managerFullName;
        set => _managerFullName = value;
    }
}
