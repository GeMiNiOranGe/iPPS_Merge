using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
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

    public List<DepartmentDto> SearchDepartments(string searchValue)
    {
        List<Department> departments = DepartmentDataAccess.Instance.SearchDepartments(searchValue);
        return departments.ToDtos();
    }

    public int DeleteDepartment(int departmentId)
    {
        return DepartmentDataAccess.Instance.DeleteDepartment(departmentId);
    }

    public int UpdateDepartment(DepartmentDto dto)
    {
        Department? entity = DepartmentDataAccess.Instance.GetDepartmentByDepartmentId(dto.DepartmentId);
        if (entity == null)
        {
            return 0;
        }

        DepartmentUpdate updateInfo = new()
        {
            Name = new(dto.Name, entity.Name != dto.Name),
            ManagerId = new(dto.ManagerId, entity.ManagerId != dto.ManagerId)
        };
        return DepartmentDataAccess.Instance.UpdateDepartment(dto.DepartmentId, updateInfo);
    }

    public int InsertDepartment(DepartmentDto dto)
    {
        Department entity = dto.ToEntity();
        return DepartmentDataAccess.Instance.InsertDepartment(entity);
    }

    public DataTable GetDepartmentList()
    {
        return DepartmentDataAccess.Instance.GetDepartmentList();
    }
}
