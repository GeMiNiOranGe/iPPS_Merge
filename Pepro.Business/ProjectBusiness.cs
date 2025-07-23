using Pepro.DataAccess;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Business;

public class ProjectBusiness {
    private static ProjectBusiness? instance;

    public static ProjectBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private ProjectBusiness() { }

    public Project GetProjectByProjectId(string projectId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByProjectId(projectId);
        if (project == null) {
            return new Project();
        }
        return project;
    }

    public List<Project> GetProjects() {
        return ProjectDataAccess.Instance.GetProjects();
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

    public string[] GetProjectsByEmployeeId(string employeeId) {
        List<Project> projects = ProjectDataAccess.Instance.GetProjectsByEmployeeId(employeeId);

        if (projects.Count == 0) {
            return ["Không tìm thấy"];
        }

        List<string> projectNames = [];
        foreach (Project project in projects) {
            projectNames.Add(project.Name);
        }
        return [.. projectNames];
    }

    public Project GetProjectByTaskId(int taskId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByTaskId(taskId);
        if (project == null) {
            return new Project();
        }
        return project;
    }

    public Project GetProjectByTaskId(string taskId) {
        int id = Convert.ToInt32(taskId);
        return Instance.GetProjectByTaskId(id);
    }
}
