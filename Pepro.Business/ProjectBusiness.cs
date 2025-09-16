using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class ProjectBusiness {
    private static ProjectBusiness? _instance;

    public static ProjectBusiness Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private ProjectBusiness() { }

    public ProjectDto? GetProjectByProjectId(int projectId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByProjectId(projectId);
        return project?.ToDto();
    }

    public IEnumerable<ProjectDto> GetProjects() {
        IEnumerable<Project> projects = ProjectDataAccess.Instance.GetProjects();
        return projects.ToDtos();
    }

    public IEnumerable<ProjectView> GetProjectViews()
    {
        IEnumerable<Project> projects = ProjectDataAccess.Instance.GetProjects();
        return MapProjectsToViews(projects);
    }

    public IEnumerable<ProjectView> SearchProjectViews(string searchValue)
    {
        IEnumerable<Project> projects = ProjectDataAccess.Instance.SearchProjects(searchValue);
        return MapProjectsToViews(projects);
    }

    private IEnumerable<ProjectView> MapProjectsToViews(IEnumerable<Project> projects)
    {
        IEnumerable<int> managerIds = projects
            .Select(p => p.ManagerId)
            .OfType<int>()
            .Distinct();

        Dictionary<int, string> managers = EmployeeBusiness
            .Instance.GetEmployeesByEmployeeIds(managerIds)
            .ToDictionary(e => e.EmployeeId, e => e.FullName);

        Dictionary<int, string> statuses = StatusDataAccess
            .Instance.GetStatuses()
            .ToDictionary(s => s.StatusId, s => s.Name);

        return projects.Select(project => new ProjectView()
        {
            ProjectId = project.ProjectId,
            Name = project.Name,
            CustomerName = project.CustomerName,
            StartDate = project.StartDate,
            EndDate = project.EndDate,
            ManagerId = project.ManagerId,
            StatusId = project.StatusId,
            ManagerFullName =
                project.ManagerId.HasValue
                && managers.TryGetValue(
                    project.ManagerId.Value,
                    out var managerFullName
                )
                    ? managerFullName
                    : "",
            StatusName = statuses.TryGetValue(
                project.StatusId,
                out var statusName
            )
                ? statusName
                : "",
        });
    }

    public List<ProjectProgressView> GetProjectProgressViews() {
        IEnumerable<Project> projects = ProjectDataAccess.Instance.GetProjects();
        List<ProjectProgressView> projectsProgress = [];

        foreach (Project project in projects) {
            IEnumerable<Assignment> assignments = AssignmentDataAccess.Instance.GetAssignmentsByProjectId(project.ProjectId);
            int total = assignments.Count();
            int completed = assignments.Count(assignment => assignment.StatusId == 4);
            decimal percent = total != 0
                ? Math.Round(completed * 100m / total, 2)
                : 0;

            projectsProgress.Add(new ProjectProgressView {
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
        IEnumerable<Project> projects = ProjectDataAccess.Instance.GetProjectsByEmployeeId(employeeId);
        return [.. projects.Select(project => project.Name)];
    }

    public ProjectDto? GetProjectByAssignmentId(int assignmentId) {
        Project? project = ProjectDataAccess.Instance.GetProjectByAssignmentId(assignmentId);
        return project?.ToDto();
    }

    public int DeleteProject(int projectId)
    {
        return ProjectDataAccess.Instance.DeleteProject(projectId);
    }
    
    public int UpdateProject(ProjectDto dto)
    {
        Project? entity = ProjectDataAccess.Instance.GetProjectByProjectId(dto.ProjectId);
        if (entity == null)
        {
            return 0;
        }

        ProjectUpdate updateInfo = new()
        {
            Name = new(dto.Name, entity.Name != dto.Name),
            CustomerName = new(dto.CustomerName, entity.CustomerName != dto.CustomerName),
            ManagerId = new(dto.ManagerId, entity.ManagerId != dto.ManagerId),
            StartDate = new(dto.StartDate, entity.StartDate != dto.StartDate),
            EndDate = new(dto.EndDate, entity.EndDate != dto.EndDate),
            StatusId = new(dto.StatusId, entity.StatusId != dto.StatusId),
        };
        return ProjectDataAccess.Instance.UpdateProject(dto.ProjectId, updateInfo);
    }

    public int InsertProject(ProjectDto dto)
    {
        Project entity = dto.ToEntity();
        return ProjectDataAccess.Instance.InsertProject(entity);
    }
}
