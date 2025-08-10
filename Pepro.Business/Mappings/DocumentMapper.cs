using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class DocumentMapper
{
    public static TaskDocumentDto ToDto(this TaskDocument entity)
    {
        return new TaskDocumentDto()
        {
            DocumentId = entity.DocumentId,
            Title = entity.Title,
            CreateAt = entity.CreateAt,
            RevisionNumber = entity.RevisionNumber,
            RevisionStatus = entity.RevisionStatus,
            DocumentUrl = entity.DocumentUrl,
            NativeFileFormat = entity.NativeFileFormat,
            PreparedBy = entity.PreparedBy,
            CheckedBy = entity.CheckedBy,
            ApprovedBy = entity.ApprovedBy,
            TaskId = entity.TaskId,
        };
    }

    public static List<TaskDocumentDto> ToDtos(this List<TaskDocument> entities)
    {
        List<TaskDocumentDto> dtos = [];
        foreach (TaskDocument entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
