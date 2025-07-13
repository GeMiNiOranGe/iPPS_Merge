using System.Data;

namespace Pepro.DataAccess;

public class TaskDataAccess {
    private static TaskDataAccess? instance;

    public static TaskDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private TaskDataAccess() { }

    /// <summary>
    ///     Retrieve all project jobs
    /// </summary>
    /// <param name="strProjectId">Project id</param>
    /// <returns>
    ///     List of jobs of a project
    /// </returns>
    public DataTable GetAllFromProject(string strProjectId) {
        string strQuery = string.Format(@"
            SELECT ID JOB_ID, NAME JOB_NAME, STATUS JOB_STATUS 
            FROM JOB 
            WHERE PROJECT_ID = '{0}'
        ", strProjectId);
        return DataProvider.Instance.ExecuteQuery(strQuery);
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
