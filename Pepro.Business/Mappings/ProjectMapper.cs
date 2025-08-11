using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class ProjectMapper
{
    public static ProjectDto ToDto(this Project entity)
    {
        return new ProjectDto()
        {
            ProjectId = entity.ProjectId,
            Name = entity.Name,
            CustomerName = entity.CustomerName,
            ManagerId = entity.ManagerId,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            StatusId = entity.StatusId,
        };
    }

    public static List<ProjectDto> ToDtos(this List<Project> entities)
    {
        List<ProjectDto> dtos = [];
        foreach (Project entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
