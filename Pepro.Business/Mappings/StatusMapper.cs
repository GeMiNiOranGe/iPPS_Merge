using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class StatusMapper
{
    public static StatusDto ToDto(this Status entity)
    {
        return new StatusDto()
        {
            StatusId = entity.StatusId,
            Name = entity.Name,
        };
    }

    public static List<StatusDto> ToDtos(this List<Status> entities)
    {
        List<StatusDto> dtos = [];
        foreach (Status entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
