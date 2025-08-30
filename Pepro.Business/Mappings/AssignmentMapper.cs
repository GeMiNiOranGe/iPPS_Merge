using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class AssignmentMapper
{
    public static Assignment ToEntity(this AssignmentDto dto)
    {
        return new Assignment()
        {
            AssignmentId = dto.AssignmentId,
            Name = dto.Name,
            IsPublicToProject = dto.IsPublicToProject,
            IsPublicToDepartment = dto.IsPublicToDepartment,
            ManagerId = dto.ManagerId,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate,
            RequiredDocumentCount = dto.RequiredDocumentCount,
            ProjectId = dto.ProjectId,
            StatusId = dto.StatusId,
        };
    }

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
            RequiredDocumentCount = entity.RequiredDocumentCount,
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
