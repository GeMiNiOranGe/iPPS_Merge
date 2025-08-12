using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class TaskMapper
{
    public static ProjectTaskDto ToDto(this ProjectTask entity)
    {
        return new ProjectTaskDto()
        {
            TaskId = entity.TaskId,
            Name = entity.Name,
            IsPublicToProject = entity.IsPublicToProject,
            IsPublicToDepartment = entity.IsPublicToDepartment,
            ManagerId = entity.ManagerId,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            ProjectId = entity.ProjectId,
            StatusId = entity.StatusId,
        };
    }

    public static List<ProjectTaskDto> ToDtos(this List<ProjectTask> entities)
    {
        List<ProjectTaskDto> dtos = [];
        foreach (ProjectTask entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
