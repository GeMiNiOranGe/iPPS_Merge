using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class AssignmentBusiness {
    private static AssignmentBusiness? instance;

    public static AssignmentBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private AssignmentBusiness() { }

    public List<AssignmentView> GetAssignmentViews()
    {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignments();
        return MapAssignmentsToViews(assignments);
    }

    public List<AssignmentView> SearchAssignmentViews(string searchValue)
    {
        List<Assignment> assignments = AssignmentDataAccess.Instance.SearchAssignments(searchValue);
        return MapAssignmentsToViews(assignments);
    }

    private List<AssignmentView> MapAssignmentsToViews(List<Assignment> assignments)
    {
        List<int> managerIds =
        [
            .. assignments.Select(a => a.ManagerId).OfType<int>().Distinct(),
        ];

        Dictionary<int, string> managers = EmployeeBusiness
            .Instance.GetEmployeesByEmployeeIds(managerIds)
            .ToDictionary(e => e.EmployeeId, e => e.FullName);

        List<int> projectIds =
        [
            .. assignments.Select(a => a.ProjectId).Distinct(),
        ];

        Dictionary<int, string> projects = ProjectDataAccess
            .Instance.GetProjectsByProjectIds(projectIds)
            .ToDictionary(e => e.ProjectId, e => e.Name);

        Dictionary<int, string> statuses = StatusDataAccess.Instance
            .GetStatuses()
            .ToDictionary(s => s.StatusId, s => s.Name);

        return
        [
            .. assignments.Select(assignment => new AssignmentView()
            {
                AssignmentId = assignment.AssignmentId,
                Name = assignment.Name,
                IsPublicToProject = assignment.IsPublicToProject,
                IsPublicToDepartment = assignment.IsPublicToDepartment,
                StartDate = assignment.StartDate,
                EndDate = assignment.EndDate,
                RequiredDocumentCount = assignment.RequiredDocumentCount,
                ManagerId = assignment.ManagerId,
                ProjectId = assignment.ProjectId,
                StatusId = assignment.StatusId,
                ManagerFullName =
                    assignment.ManagerId.HasValue
                    && managers.TryGetValue(
                        assignment.ManagerId.Value,
                        out var managerFullName
                    )
                        ? managerFullName
                        : "",
                ProjectName = projects.TryGetValue(
                    assignment.ProjectId,
                    out var projectName
                )
                    ? projectName
                    : "",
                StatusName = statuses.TryGetValue(
                    assignment.StatusId,
                    out var statusName
                )
                    ? statusName
                    : "",
            })
        ];
    }

    public List<AssignmentDto> GetAssignmentsByProjectId(int projectId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(projectId);
        return assignments.ToDtos();
    }

    public List<AssignmentProgressView> GetAssignmentProgressViewsByProjectId(int projectId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(projectId);
        List<AssignmentProgressView> assignmentsProgress = [];

        foreach (Assignment assignment in assignments) {
            int requiredDocumentCount = assignment.RequiredDocumentCount;
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByAssignmentId(assignment.AssignmentId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            assignmentsProgress.Add(new AssignmentProgressView {
                AssignmentId = assignment.AssignmentId,
                Name = assignment.Name,
                IsPublicToProject = assignment.IsPublicToProject,
                IsPublicToDepartment = assignment.IsPublicToDepartment,
                StartDate = assignment.StartDate,
                EndDate = assignment.EndDate,
                RequiredDocumentCount = assignment.RequiredDocumentCount,
                ManagerId = assignment.ManagerId,
                ProjectId = assignment.ProjectId,
                StatusId = assignment.StatusId,
                ProgressPercent = percent
            });
        }

        return assignmentsProgress;
    }

    public List<AssignmentProgressView> GetAssignmentProgressViewsByEmployeeId(int employeeId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByEmployeeId(employeeId);
        List<AssignmentProgressView> assignmentsProgress = [];

        foreach (Assignment assignment in assignments) {
            int requiredDocumentCount = assignment.RequiredDocumentCount;
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByAssignmentId(assignment.AssignmentId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            assignmentsProgress.Add(new AssignmentProgressView {
                AssignmentId = assignment.AssignmentId,
                Name = assignment.Name,
                IsPublicToProject = assignment.IsPublicToProject,
                IsPublicToDepartment = assignment.IsPublicToDepartment,
                StartDate = assignment.StartDate,
                EndDate = assignment.EndDate,
                RequiredDocumentCount = assignment.RequiredDocumentCount,
                ManagerId = assignment.ManagerId,
                ProjectId = assignment.ProjectId,
                StatusId = assignment.StatusId,
                ProgressPercent = percent
            });
        }

        return assignmentsProgress;
    }

    public EmployeeDto? GetAssignmentManager(int assignmentId) {
        Employee? employee = AssignmentDataAccess.Instance.GetAssignmentManager(assignmentId);
        return employee?.ToDto();
    }

    public AssignmentDto? GetAssignmentByDocumentId(int documentId) {
        Assignment? assignment = AssignmentDataAccess.Instance.GetAssignmentByDocumentId(documentId);
        return assignment?.ToDto();
    }

    public int DeleteAssignment(int assignmentId) {
        return AssignmentDataAccess.Instance.DeleteAssignment(assignmentId);
    }

    public int UpdateAssignment(AssignmentDto dto)
    {
        Assignment? entity = AssignmentDataAccess.Instance.GetAssignmentByAssignmentId(dto.AssignmentId);
        if (entity == null)
        {
            return 0;
        }

        AssignmentUpdate updateInfo = new()
        {
            Name = new(dto.Name, entity.Name != dto.Name),
            IsPublicToProject = new(dto.IsPublicToProject, entity.IsPublicToProject != dto.IsPublicToProject),
            IsPublicToDepartment = new(dto.IsPublicToDepartment, entity.IsPublicToDepartment != dto.IsPublicToDepartment),
            StartDate = new(dto.StartDate, entity.StartDate != dto.StartDate),
            EndDate = new(dto.EndDate, entity.EndDate != dto.EndDate),
            RequiredDocumentCount = new(dto.RequiredDocumentCount, entity.RequiredDocumentCount != dto.RequiredDocumentCount),
            ManagerId = new(dto.ManagerId, entity.ManagerId != dto.ManagerId),
            ProjectId = new(dto.ProjectId, entity.ProjectId != dto.ProjectId),
            StatusId = new(dto.StatusId, entity.StatusId != dto.StatusId),
        };
        return AssignmentDataAccess.Instance.UpdateAssignment(dto.AssignmentId, updateInfo);
    }

    public int InsertAssignment(AssignmentDto dto)
    {
        Assignment entity = dto.ToEntity();
        return AssignmentDataAccess.Instance.InsertAssignment(entity);
    }
}
