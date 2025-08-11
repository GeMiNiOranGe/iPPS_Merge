using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
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

    public List<ProjectProgress> GetProjectsWithProgress() {
        List<Project> projects = ProjectDataAccess.Instance.GetProjects();
        List<ProjectProgress> projectsProgress = [];

        foreach (Project project in projects) {
            List<ProjectTask> tasks = TaskDataAccess.Instance.GetTasksByProjectId(project.ProjectId);
            int total = tasks.Count;
            int completed = tasks.Count(task => task.StatusId == 4);
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

    public string[] GetProjectNamesByEmployeeId(string employeeId) {
        List<Project> projects = ProjectDataAccess.Instance.GetProjectsByEmployeeId(employeeId);
        List<string> projectNames = [];
        foreach (Project project in projects) {
            projectNames.Add(project.Name);
        }
        return [.. projectNames];
    }

    public ProjectDto? GetProjectByTaskId(int taskId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByTaskId(taskId);
        return project?.ToDto();
    }
}
