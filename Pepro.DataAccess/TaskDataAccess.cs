using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class TaskDataAccess {
    private static TaskDataAccess? instance;

    public static TaskDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private TaskDataAccess() { }

    public int GetRequiredDocumentCount(int taskId) {
        string query = "SELECT RequiredDocumentCount FROM Task WHERE TaskId = @TaskId";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "TaskId",
                SqlDbType = SqlDbType.Int,
                Value = taskId
            }
        ];

        return (int)DataProvider.Instance.ExecuteScalar(query, parameters);
    }

    public List<ProjectTask> GetTasksByProjectId(string projectId) {
        string query = @"
            SELECT TaskId
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , ProjectId
                , StatusId
            FROM Task 
            WHERE ProjectId = @ProjectId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "ProjectId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = projectId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

        List<ProjectTask> tasks = [];
        foreach (DataRow row in dataTable.Rows) {
            ProjectTask task = new() {
                TaskId = row.Field<int>("TaskId"),
                Name = row.Field<string>("Name") ?? "",
                IsPublicToProject = row.Field<bool>("IsPublicToProject"),
                IsPublicToDepartment = row.Field<bool>("IsPublicToDepartment"),
                ManagerId = row.Field<string>("ManagerId") ?? "",
                StartDate = row.Field<DateTime>("StartDate"),
                EndDate = row.Field<DateTime>("EndDate"),
                ProjectId = row.Field<string>("ProjectId") ?? "",
                StatusId = row.Field<int>("StatusId")
            };
            tasks.Add(task);
        }
        return tasks;
    }

    /// <summary>
    ///     Retrieve all jobs engaged by employees
    /// </summary>
    /// <param name="strEmployeeId">Employee id</param>
    /// <returns>
    ///     List of jobs by a employee
    /// </returns>
    public DataTable GetAllByEmployee(string strEmployeeId) {
        string strQuery = string.Format(@"
            SELECT PROJECT_ID, ID JOB_ID, NAME JOB_NAME, STATUS JOB_STATUS 
            FROM JOB 
            WHERE JOB_MANAGER_ID = '{0}'
        ", strEmployeeId);
        return DataProvider.Instance.ExecuteQuery(strQuery);
    }

    /// <summary>
    ///     Take out the manager of the job
    /// </summary>
    /// <param name="strJobId">Job id</param>
    /// <returns>
    ///     Manager
    /// </returns>
    public DataTable GetManager(string strJobId) {
        string strQuery = string.Format(@"
            SELECT EMPLOYEE.ID EMPLOYEE_ID, LAST_NAME + ' ' + MIDDLE_NAME + ' ' + FIRST_NAME EMPLOYEE_FULLNAME 
            FROM EMPLOYEE, JOB 
            WHERE EMPLOYEE.ID = JOB.JOB_MANAGER_ID AND JOB.ID = '{0}'
        ", strJobId);
        return DataProvider.Instance.ExecuteQuery(strQuery);
    }
}
