using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Contracts;
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
                , Project.IsDeleted
                , Project.CreatedAt
                , Project.UpdatedAt
                , Project.DeletedAt
            FROM Project
            WHERE ProjectId = @ProjectId
                AND IsDeleted = 0
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
                , Project.IsDeleted
                , Project.CreatedAt
                , Project.UpdatedAt
                , Project.DeletedAt
            FROM Project
            WHERE IsDeleted = 0
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
                , Project.IsDeleted
                , Project.CreatedAt
                , Project.UpdatedAt
                , Project.DeletedAt
            FROM Project
            WHERE
                (
                    ProjectId LIKE '%' + @SearchValue + '%'
                    OR Name LIKE '%' + @SearchValue + '%'
                    OR CustomerName LIKE '%' + @SearchValue + '%'
                )
                AND IsDeleted = 0
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
                , Project.IsDeleted
                , Project.CreatedAt
                , Project.UpdatedAt
                , Project.DeletedAt
            FROM AssignmentDetail
            INNER JOIN Assignment
                    ON AssignmentDetail.AssignmentId = Assignment.AssignmentId
            INNER JOIN Project
                    ON Assignment.ProjectId = Project.ProjectId
            WHERE EmployeeId = @EmployeeId
                AND IsDeleted = 0
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
                , Project.IsDeleted
                , Project.CreatedAt
                , Project.UpdatedAt
                , Project.DeletedAt
            FROM Project
            INNER JOIN Assignment
                    ON Assignment.ProjectId = Project.ProjectId
            WHERE Assignment.AssignmentId = @AssignmentId
                AND IsDeleted = 0
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

    public int DeleteProject(string projectId) {
        string query = @"
            UPDATE Project
            SET IsDeleted = 1,
                DeletedAt = GetDate()
            WHERE ProjectId = @ProjectId;
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.VarChar, 10, projectId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int UpdateProject(string projectId, ProjectUpdate info) {
        SqlUpdateQueryBuilder builder = new SqlUpdateQueryBuilder("Project")
            .Set("Name", SqlDbType.NVarChar, 50, info.Name)
            .Set("CustomerName", SqlDbType.NVarChar, 50, info.CustomerName)
            .Set("ManagerId", SqlDbType.Int, info.ManagerId)
            .Set("StartDate", SqlDbType.Date, info.StartDate)
            .Set("EndDate", SqlDbType.Date, info.EndDate)
            .Set("StatusId", SqlDbType.Int, info.StatusId)
            .SetDirect("UpdatedAt", SqlDbType.DateTime, DateTime.Now)
            .Where("ProjectId", SqlDbType.VarChar, 10, projectId);

        (string query, List<SqlParameter> parameters) = builder.Build();

        if (string.IsNullOrEmpty(query) || parameters.Count == 0)
        {
            return 0;
        }
        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }
}
