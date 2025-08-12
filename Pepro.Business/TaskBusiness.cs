using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class TaskBusiness {
    private static TaskBusiness? instance;

    public static TaskBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private TaskBusiness() { }

    public List<ProjectTaskDto> GetTasksByProjectId(string projectId) {
        List<ProjectTask> tasks = TaskDataAccess.Instance.GetTasksByProjectId(projectId);
        return tasks.ToDtos();
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

    public EmployeeDto? GetTaskManager(int taskId) {
        Employee? employee = TaskDataAccess.Instance.GetTaskManager(taskId);
        return employee?.ToDto();
    }

    public ProjectTaskDto? GetTaskByDocumentId(int documentId) {
        ProjectTask? task = TaskDataAccess.Instance.GetTaskByDocumentId(documentId);
        return task?.ToDto();
    }
}
