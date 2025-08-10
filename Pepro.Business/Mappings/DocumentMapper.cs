using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business.Mappings;

static class DocumentMapper
{
    public static DocumentDto ToDto(this Document entity)
    {
        return new DocumentDto()
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

    public static List<DocumentDto> ToDtos(this List<Document> entities)
    {
        List<DocumentDto> dtos = [];
        foreach (Document entity in entities)
        {
            dtos.Add(entity.ToDto());
        }
        return dtos;
    }
}
