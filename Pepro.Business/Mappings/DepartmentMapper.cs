using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class DepartmentMapper
{
    public static DepartmentDto ToDto(this Department entity)
    {
        return new DepartmentDto()
        {
            DepartmentId = entity.DepartmentId,
            Name = entity.Name,
            ManagerId = entity.ManagerId,
        };
    }

    public static List<DepartmentDto> ToDtos(this List<Department> entities)
    {
        List<DepartmentDto> dtos = [];
        foreach (Department item in entities)
        {
            dtos.Add(item.ToDto());
        }
        return dtos;
    }
}
