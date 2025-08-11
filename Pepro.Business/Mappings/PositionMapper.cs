using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class PositionMapper
{
    public static EmployeePositionDto ToDto(this EmployeePosition entity)
    {
        return new EmployeePositionDto()
        {
            PositionId = entity.PositionId,
            Title = entity.Title,
            AllowanceCoefficient = entity.AllowanceCoefficient,
        };
    }

    public static List<EmployeePositionDto> ToDtos(this List<EmployeePosition> entities)
    {
        List<EmployeePositionDto> dtos = [];
        foreach (EmployeePosition entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
