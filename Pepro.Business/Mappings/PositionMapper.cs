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
            AllowancePercent = entity.AllowancePercent,
        };
    }

    public static IEnumerable<PositionDto> ToDtos(this IEnumerable<Position> entities)
    {
        return entities.Select(entity => entity.ToDto());
    }
}
