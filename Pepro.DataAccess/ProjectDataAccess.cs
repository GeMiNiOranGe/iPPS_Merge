using Microsoft.Data.SqlClient;
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

    /// <summary>
    ///     Retrieve all projects
    /// </summary>
    /// <returns>
    ///     List of projects
    /// </returns>
    public DataTable GetProjectList() {
        string strQuery = string.Format(@"
            SELECT PROJECT_ID, PROJECT.NAME PROJECT_NAME, DEPARTMENT.NAME DEPARTMENT_NAME, STATUS PROJECT_STATUS 
            FROM IMPLEMENT_PROJECT, PROJECT, DEPARTMENT 
            WHERE IMPLEMENT_PROJECT.PROJECT_ID = PROJECT.ID AND IMPLEMENT_PROJECT.DEPARTMENT_ID = DEPARTMENT.ID
        ");
        return DataProvider.Instance.ExecuteQuery(strQuery);
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
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "EmployeeId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = employeeId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

        List<Project> projects = [];
        foreach (DataRow row in dataTable.Rows) {
            Project project = new() {
                ProjectId = row.Field<string>("ProjectId") ?? "",
                Name = row.Field<string>("Name") ?? "",
                CustomerName = row.Field<string>("CustomerName") ?? "",
                ManagerId = row.Field<string>("ManagerId") ?? "",
                StartDate = row.Field<DateTime>("StartDate"),
                EndDate = row.Field<DateTime>("EndDate"),
                StatusId = row.Field<int>("StatusId")
            };
            projects.Add(project);
        }
        return projects;
    }
}
