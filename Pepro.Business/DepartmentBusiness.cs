using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Business;

public class DepartmentBusiness
{
    private static DepartmentBusiness? _instance;

    public static DepartmentBusiness Instance {
        get => _instance ??= new();
        private set => _instance = value;
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

    public List<DepartmentView> GetDepartmentViews()
    {
        List<Department> departments = DepartmentDataAccess.Instance.GetDepartments();
        return MapDepartmentsToViews(departments);
    }

    public List<DepartmentView> SearchDepartmentViews(string searchValue)
    {
        List<Department> departments = DepartmentDataAccess.Instance.SearchDepartments(searchValue);
        return MapDepartmentsToViews(departments);
    }

    private List<DepartmentView> MapDepartmentsToViews(List<Department> departments)
    {
        List<int> managerIds =
        [
            .. departments.Select(d => d.ManagerId).OfType<int>().Distinct(),
        ];

        Dictionary<int, string> managers = EmployeeBusiness
            .Instance.GetEmployeesByEmployeeIds(managerIds)
            .ToDictionary(e => e.EmployeeId, e => e.FullName);

        return
        [
            .. departments.Select(department => new DepartmentView()
            {
                DepartmentId = department.DepartmentId,
                Name = department.Name,
                ManagerId = department.ManagerId,
                ManagerFullName =
                    department.ManagerId.HasValue
                    && managers.TryGetValue(
                        department.ManagerId.Value,
                        out string? managerFullName
                    )
                        ? managerFullName
                        : "",
            }),
        ];
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
