using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Mappings;
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
            ProjectTask task = TaskMapper.FromDataRow(row);
            tasks.Add(task);
        }
        return tasks;
    }

    public List<ProjectTask> GetTasksByEmployeeId(string employeeId) {
        string query = @"
            SELECT Task.TaskId
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , ProjectId
                , StatusId
            FROM Task
            INNER JOIN TaskDetail
                    ON TaskDetail.TaskId = Task.TaskId
            WHERE EmployeeId = @EmployeeId
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

        List<ProjectTask> tasks = [];
        foreach (DataRow row in dataTable.Rows) {
            ProjectTask task = TaskMapper.FromDataRow(row);
            tasks.Add(task);
        }
        return tasks;
    }

    /// <summary>
    ///     Take out the manager of the task
    /// </summary>
    /// <param name="taskId">Task id</param>
    /// <returns>
    ///     Manager
    /// </returns>
    public Employee? GetTaskManager(int taskId) {
        string query = @"
            SELECT EmployeeId
                , FirstName
                , MiddleName
                , LastName
                , DateOfBirth
                , Gender
                , TaxCode
                , CitizenId
                , DepartmentId
                , PositionId
                , SalaryLevelId
            FROM Task
            INNER JOIN Employee
                    ON Employee.EmployeeId = Task.ManagerId
            WHERE TaskId = @TaskId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "TaskId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = taskId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return EmployeeMapper.FromDataRow(row);
    }

    public ProjectTask? GetTaskByDocumentId(int documentId) {
        string query = @"
            SELECT Task.TaskId
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , ProjectId
                , StatusId
            FROM Task
            INNER JOIN Document
                    ON Document.TaskId = Task.TaskId
            WHERE Document.DocumentId = @DocumentId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "DocumentId",
                SqlDbType = SqlDbType.Int,
                Value = documentId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return TaskMapper.FromDataRow(row);
    }
}
