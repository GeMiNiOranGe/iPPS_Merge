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

    public static List<SalaryScaleDto> ToDtos(this List<SalaryScale> entities)
    {
        List<SalaryScaleDto> dtos = [];
        foreach (SalaryScale entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
