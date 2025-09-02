using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
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

    public DepartmentDto? GetDepartmentByDepartmentId(int departmentID) {
        Department? department = DepartmentDataAccess.Instance.GetDepartmentByDepartmentId(departmentID);
        return department?.ToDto();
    }

    public List<DepartmentDto> GetDepartments()
    {
        List<Department> departments = DepartmentDataAccess.Instance.GetDepartments();
        return departments.ToDtos();
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
