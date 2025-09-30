using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class RoleMapper
{
    public static RoleDto ToDto(this Role entity)
    {
        return new RoleDto()
        {
            RoleId = entity.RoleId,
            Name = entity.Name,
        };
    }

    public static IEnumerable<RoleDto> ToDtos(this IEnumerable<Role> entities)
    {
        return entities.Select(entity => entity.ToDto());
    }
}
