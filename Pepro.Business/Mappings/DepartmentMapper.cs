using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class DepartmentMapper
{
    public static DepartmentDto ToDto(this Department department)
    {
        return new DepartmentDto()
        {
            DepartmentId = department.DepartmentId,
            Name = department.Name,
            ManagerId = department.ManagerId,
        };
    }

    public static List<DepartmentDto> ToDtos(this List<Department> departments)
    {
        List<DepartmentDto> dtos = [];
        foreach (Department item in departments)
        {
            dtos.Add(item.ToDto());
        }
        return dtos;
    }
}
