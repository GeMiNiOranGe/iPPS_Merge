using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class ProjectBusiness {
    private static ProjectBusiness? instance;

    public static ProjectBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private ProjectBusiness() { }

    public ProjectDto? GetProjectByProjectId(string projectId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByProjectId(projectId);
        return project?.ToDto();
    }

    public List<ProjectDto> GetProjects() {
        List<Project> projects = ProjectDataAccess.Instance.GetProjects();
        return projects.ToDtos();
    }

    public List<ProjectDto> SearchProjects(string searchValue) {
        List<Project> projects = ProjectDataAccess.Instance.SearchProjects(searchValue);
        return projects.ToDtos();
    }

    public List<ProjectProgress> GetProjectsWithProgress() {
        List<Project> projects = ProjectDataAccess.Instance.GetProjects();
        List<ProjectProgress> projectsProgress = [];

        foreach (Project project in projects) {
            List<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(project.ProjectId);
            int total = assignments.Count;
            int completed = assignments.Count(assignment => assignment.StatusId == 4);
            decimal percent = total != 0
                ? Math.Round(completed * 100m / total, 2)
                : 0;

            projectsProgress.Add(new ProjectProgress {
                ProjectId = project.ProjectId,
                Name = project.Name,
                CustomerName = project.CustomerName,
                ManagerId = project.ManagerId,
                StartDate = project.StartDate,
                EndDate = project.EndDate,
                StatusId = project.StatusId,
                ProgressPercent = percent
            });
        }

        return projectsProgress;
    }

    public string[] GetProjectNamesByEmployeeId(int employeeId) {
        List<Project> projects = ProjectDataAccess.Instance.GetProjectsByEmployeeId(employeeId);
        List<string> projectNames = [];
        foreach (Project project in projects) {
            projectNames.Add(project.Name);
        }
        return [.. projectNames];
    }

    public ProjectDto? GetProjectByAssignmentId(int assignmentId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByAssignmentId(assignmentId);
        return project?.ToDto();
    }

    public int DeleteProject(string projectId)
    {
        return ProjectDataAccess.Instance.DeleteProject(projectId);
    }
}
