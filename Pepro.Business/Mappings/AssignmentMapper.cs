using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class AssignmentMapper
{
    public static AssignmentDto ToDto(this Assignment entity)
    {
        return new AssignmentDto()
        {
            AssignmentId = entity.AssignmentId,
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

    public static List<AssignmentDto> ToDtos(this List<Assignment> entities)
    {
        List<AssignmentDto> dtos = [];
        foreach (Assignment entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
