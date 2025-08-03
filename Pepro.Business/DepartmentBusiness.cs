using Pepro.DataAccess;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Business;

public class DepartmentBusiness
{
    private static DepartmentBusiness? instance;

    public static DepartmentBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private DepartmentBusiness() { }

    public Department GetDepartmentByDepartmentId(string departmentID) {
        Department? department = DepartmentDataAccess.Instance.GetDepartmentByDepartmentId(departmentID);
        if (department == null) {
            return new Department();
        }
        return department;
    }

    public List<Department> GetDepartments()
    {
        return DepartmentDataAccess.Instance.GetDepartments();
    }

    public DataTable GetDepartmentList()
    {
        return DepartmentDataAccess.Instance.GetDepartmentList();
    }

    public DataTable GetAllDepartments()
    {
        return DepartmentDataAccess.Instance.GetAllDepartments();
    }
}
