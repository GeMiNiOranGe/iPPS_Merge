using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class SalaryLevelMapper
{
    public static SalaryLevelDto ToDto(this SalaryLevel entity)
    {
        return new SalaryLevelDto()
        {
            SalaryLevelId = entity.SalaryLevelId,
            Level = entity.Level,
            Coefficient = entity.Coefficient,
            SalaryScaleId = entity.SalaryScaleId,
        };
    }

    public static List<SalaryLevelDto> ToDtos(this List<SalaryLevel> entities)
    {
        List<SalaryLevelDto> dtos = [];
        foreach (SalaryLevel entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
