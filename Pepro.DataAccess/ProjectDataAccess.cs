using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
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
            SELECT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
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

    public List<Project> SearchProjects(string searchValue) {
        string query = @"
            SELECT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM Project
            WHERE
                (
                    ProjectId LIKE '%' + @SearchValue + '%'
                    OR Name LIKE '%' + @SearchValue + '%'
                    OR CustomerName LIKE '%' + @SearchValue + '%'
                )
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Project> projects = [];
        foreach (DataRow row in dataTable.Rows) {
            Project project = ProjectMapper.FromDataRow(row);
            projects.Add(project);
        }
        return projects;
    }

    public List<Project> GetProjectsByEmployeeId(int employeeId) {
        string query = @"
            SELECT DISTINCT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM AssignmentDetail
            INNER JOIN Assignment
                    ON AssignmentDetail.AssignmentId = Assignment.AssignmentId
            INNER JOIN Project
                    ON Assignment.ProjectId = Project.ProjectId
            WHERE EmployeeId = @EmployeeId
            ORDER BY Project.ProjectId DESC;
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Project> projects = [];
        foreach (DataRow row in dataTable.Rows) {
            Project project = ProjectMapper.FromDataRow(row);
            projects.Add(project);
        }
        return projects;
    }

    public Project? GetProjectByAssignmentId(int assignmentId) {
        string query = @"
            SELECT Project.ProjectId
                , Project.Name
                , Project.CustomerName
                , Project.ManagerId
                , Project.StartDate
                , Project.EndDate
                , Project.StatusId
            FROM Project
            INNER JOIN Assignment
                    ON Assignment.ProjectId = Project.ProjectId
            WHERE Assignment.AssignmentId = @AssignmentId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("AssignmentId", SqlDbType.Int, assignmentId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return ProjectMapper.FromDataRow(row);
    }
}
