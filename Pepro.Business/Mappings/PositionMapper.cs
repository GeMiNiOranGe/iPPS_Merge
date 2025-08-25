using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class PositionMapper
{
    public static PositionDto ToDto(this Position entity)
    {
        return new PositionDto()
        {
            PositionId = entity.PositionId,
            Title = entity.Title,
            AllowanceCoefficient = entity.AllowanceCoefficient,
        };
    }

    public static List<PositionDto> ToDtos(this List<Position> entities)
    {
        List<PositionDto> dtos = [];
        foreach (Position entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
