using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class SalaryScaleMapper
{
    public static SalaryScaleDto ToDto(this SalaryScale entity)
    {
        return new SalaryScaleDto()
        {
            SalaryScaleId = entity.SalaryScaleId,
            Group = entity.Group,
            Name = entity.Name,
        };
    }

    public static IEnumerable<SalaryScaleDto> ToDtos(this IEnumerable<SalaryScale> entities)
    {
        return entities.Select(entity => entity.ToDto());
    }
}
