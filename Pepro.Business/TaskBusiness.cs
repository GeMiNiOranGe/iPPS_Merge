using Pepro.DataAccess;
using Pepro.DTOs;
using System.Data;
using System.Threading.Tasks;

namespace Pepro.Business;

public class TaskBusiness {
    private static TaskBusiness? instance;

    public static TaskBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private TaskBusiness() { }

    public List<ProjectTask> GetTasksByProjectId(string projectId) {
        return TaskDataAccess.Instance.GetTasksByProjectId(projectId);
    }

    public List<ProjectTaskProgress> GetTasksWithProgressByProjectId(string projectId) {
        List<ProjectTask> tasks = TaskDataAccess.Instance.GetTasksByProjectId(projectId);
        List<ProjectTaskProgress> tasksProgress = [];

        foreach (ProjectTask task in tasks) {
            int requiredDocumentCount = TaskDataAccess.Instance.GetRequiredDocumentCount(task.TaskId);
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByTaskId(task.TaskId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            tasksProgress.Add(new ProjectTaskProgress {
                TaskId = task.TaskId,
                Name = task.Name,
                IsPublicToProject = task.IsPublicToProject,
                IsPublicToDepartment = task.IsPublicToDepartment,
                ManagerId = task.ManagerId,
                StartDate = task.StartDate,
                EndDate = task.EndDate,
                ProjectId = task.ProjectId,
                StatusId = task.StatusId,
                ProgressPercent = percent
            });
        }

        return tasksProgress;
    }

    public List<ProjectTaskProgress> GetTasksWithProgressByEmployeeId(string employeeId) {
        List<ProjectTask> tasks = TaskDataAccess.Instance.GetTasksByEmployeeId(employeeId);
        List<ProjectTaskProgress> tasksProgress = [];

        foreach (ProjectTask task in tasks) {
            int requiredDocumentCount = TaskDataAccess.Instance.GetRequiredDocumentCount(task.TaskId);
            int documentCount = DocumentDataAccess.Instance.CountDocumentsByTaskId(task.TaskId);
            decimal percent = requiredDocumentCount != 0
                ? Math.Round(documentCount * 100m / requiredDocumentCount, 2)
                : 0;

            tasksProgress.Add(new ProjectTaskProgress {
                TaskId = task.TaskId,
                Name = task.Name,
                IsPublicToProject = task.IsPublicToProject,
                IsPublicToDepartment = task.IsPublicToDepartment,
                ManagerId = task.ManagerId,
                StartDate = task.StartDate,
                EndDate = task.EndDate,
                ProjectId = task.ProjectId,
                StatusId = task.StatusId,
                ProgressPercent = percent
            });
        }

        return tasksProgress;
    }

    public Employee GetTaskManager(int taskId) {
        Employee? employee = TaskDataAccess.Instance.GetTaskManager(taskId);
        if (employee == null) {
            return new Employee();
        }
        return employee;
    }

    public ProjectTask GetTaskByDocumentId(int documentId) {
        ProjectTask? task = TaskDataAccess.Instance.GetTaskByDocumentId(documentId);
        if (task == null) {
            return new ProjectTask();
        }
        return task;
    }

    public ProjectTask GetTaskByDocumentId(string documentId) {
        int id = Convert.ToInt32(documentId);
        return Instance.GetTaskByDocumentId(id);
    }
}
