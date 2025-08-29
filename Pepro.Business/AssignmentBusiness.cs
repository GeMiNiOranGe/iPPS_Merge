using Pepro.Business.Mappings;
using Pepro.DataAccess;
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

    public List<AssignmentView> GetAssignmentViews() {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignments();
        Dictionary<int, string> statuses = StatusDataAccess.Instance
            .GetStatuses()
            .ToDictionary(s => s.StatusId, s => s.Name);
        List<AssignmentView> assignmentViews = [];

        foreach (Assignment assignment in assignments) {
            if (statuses.TryGetValue(assignment.StatusId, out var statusName)) {
                AssignmentView assignmentView = new() {
                    AssignmentId = assignment.AssignmentId,
                    Name = assignment.Name,
                    IsPublicToProject = assignment.IsPublicToProject,
                    IsPublicToDepartment = assignment.IsPublicToDepartment,
                    ManagerId = assignment.ManagerId,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    RequiredDocumentCount = assignment.RequiredDocumentCount,
                    ProjectId = assignment.ProjectId,
                    StatusId = assignment.StatusId,
                    StatusName = statusName
                };
                assignmentViews.Add(assignmentView);
            }
        }
        return assignmentViews;
    }

    public List<AssignmentView> SearchAssignmentViews(string searchValue) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.SearchAssignments(searchValue);
        Dictionary<int, string> statuses = StatusDataAccess.Instance
            .GetStatuses()
            .ToDictionary(s => s.StatusId, s => s.Name);
        List<AssignmentView> assignmentViews = [];

        foreach (Assignment assignment in assignments) {
            if (statuses.TryGetValue(assignment.StatusId, out var statusName)) {
                AssignmentView assignmentView = new() {
                    AssignmentId = assignment.AssignmentId,
                    Name = assignment.Name,
                    IsPublicToProject = assignment.IsPublicToProject,
                    IsPublicToDepartment = assignment.IsPublicToDepartment,
                    ManagerId = assignment.ManagerId,
                    StartDate = assignment.StartDate,
                    EndDate = assignment.EndDate,
                    RequiredDocumentCount = assignment.RequiredDocumentCount,
                    ProjectId = assignment.ProjectId,
                    StatusId = assignment.StatusId,
                    StatusName = statusName
                };
                assignmentViews.Add(assignmentView);
            }
        }
        return assignmentViews;
    }

    public List<AssignmentDto> GetAssignmentsByProjectId(int projectId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(projectId);
        return assignments.ToDtos();
    }

    public List<AssignmentProgress> GetAssignmentsWithProgressByProjectId(int projectId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(projectId);
        List<AssignmentProgress> assignmentsProgress = [];

        foreach (Assignment assignment in assignments) {
            int requiredDocumentCount = assignment.RequiredDocumentCount;
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByAssignmentId(assignment.AssignmentId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            assignmentsProgress.Add(new AssignmentProgress {
                AssignmentId = assignment.AssignmentId,
                Name = assignment.Name,
                IsPublicToProject = assignment.IsPublicToProject,
                IsPublicToDepartment = assignment.IsPublicToDepartment,
                ManagerId = assignment.ManagerId,
                StartDate = assignment.StartDate,
                EndDate = assignment.EndDate,
                ProjectId = assignment.ProjectId,
                StatusId = assignment.StatusId,
                ProgressPercent = percent
            });
        }

        return assignmentsProgress;
    }

    public List<AssignmentProgress> GetAssignmentsWithProgressByEmployeeId(int employeeId) {
        List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByEmployeeId(employeeId);
        List<AssignmentProgress> assignmentsProgress = [];

        foreach (Assignment assignment in assignments) {
            int requiredDocumentCount = assignment.RequiredDocumentCount;
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByAssignmentId(assignment.AssignmentId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            assignmentsProgress.Add(new AssignmentProgress {
                AssignmentId = assignment.AssignmentId,
                Name = assignment.Name,
                IsPublicToProject = assignment.IsPublicToProject,
                IsPublicToDepartment = assignment.IsPublicToDepartment,
                ManagerId = assignment.ManagerId,
                StartDate = assignment.StartDate,
                EndDate = assignment.EndDate,
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
}
