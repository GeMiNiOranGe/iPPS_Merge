using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Mappings;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class ProjectDataAccess {
    private static ProjectDataAccess? instance;

    public static ProjectDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private ProjectDataAccess() { }

    public Project? GetProjectByProjectId(string projectId) {
        string query = @"
            SELECT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM Project
            WHERE ProjectId = @ProjectId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.VarChar, 10, projectId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return ProjectMapper.FromDataRow(row);
    }

    /// <summary>
    ///     Retrieve all projects
    /// </summary>
    /// <returns>
    ///     List of projects
    /// </returns>
    public List<Project> GetProjects() {
        string query = @"
            SELECT ProjectId
                , Name
                , CustomerName
                , ManagerId
                , StartDate
                , EndDate
                , StatusId
            FROM Project
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Project> projects = [];
        foreach (DataRow row in dataTable.Rows)
        {
            Project project = ProjectMapper.FromDataRow(row);
            projects.Add(project);
        }
        return projects;
    }

    public List<Project> GetProjectsByEmployeeId(string employeeId) {
        string query = @"
            SELECT DISTINCT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM TaskDetail
            INNER JOIN Task
                    ON TaskDetail.TaskId = Task.TaskId
            INNER JOIN Project
                    ON Task.ProjectId = Project.ProjectId
            WHERE EmployeeId = @EmployeeId
            ORDER BY Project.ProjectId DESC;
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.VarChar, 10, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Project> projects = [];
        foreach (DataRow row in dataTable.Rows) {
            Project project = ProjectMapper.FromDataRow(row);
            projects.Add(project);
        }
        return projects;
    }

    public Project? GetProjectByTaskId(int taskId) {
        string query = @"
            SELECT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM Project
            INNER JOIN Task
                    ON Task.ProjectId = Project.ProjectId
            WHERE Task.TaskId = @TaskId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("TaskId", SqlDbType.Int, taskId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return ProjectMapper.FromDataRow(row);
    }
}
