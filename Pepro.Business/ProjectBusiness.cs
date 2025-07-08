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

    public DataTable GetProjectList() {
        return ProjectDataAccess.Instance.GetProjectList();
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
}
