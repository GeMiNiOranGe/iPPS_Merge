using Pepro.DataAccess;
using System.Data;

namespace Pepro.Business;

public class TaskBusiness {
    private static TaskBusiness? instance;

    public static TaskBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private TaskBusiness() { }

    public DataTable GetAllFromProject(string strProjectId) {
        return TaskDataAccess.Instance.GetAllFromProject(strProjectId);
    }
    
    public DataTable GetAllByEmployee(string strEmployeeId) {
        return TaskDataAccess.Instance.GetAllByEmployee(strEmployeeId);
    }
    
    public DataTable GetManager(string strJobId) {
        return TaskDataAccess.Instance.GetManager(strJobId);
    }
}
