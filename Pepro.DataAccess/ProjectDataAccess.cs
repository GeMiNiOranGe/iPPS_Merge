using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class ProjectDataAccess
{
    private static ProjectDataAccess? _instance;

    public static ProjectDataAccess Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private ProjectDataAccess() { }

    public Project? GetById(int projectId)
    {
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
            WHERE Project.ProjectId = @ProjectId
                AND Project.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.Int, projectId);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapToSingleOrDefault(ProjectMapper.FromDataRow);
    }

    public Project? GetByAssignmentId(int assignmentId)
    {
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
                AND Project.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("AssignmentId", SqlDbType.Int, assignmentId);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapToSingleOrDefault(ProjectMapper.FromDataRow);
    }

    /// <summary>
    ///     Retrieve all projects
    /// </summary>
    /// <returns>
    ///     List of projects
    /// </returns>
    public IEnumerable<Project> GetMany()
    {
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
            WHERE Project.IsDeleted = 0
        ";

        return DataProvider
            .Instance.ExecuteQuery(query)
            .MapMany(ProjectMapper.FromDataRow);
    }

    public IEnumerable<Project> GetManyByIds(IEnumerable<int> projectIds)
    {
        if (projectIds == null || !projectIds.Any())
        {
            return [];
        }

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
            INNER JOIN @ProjectIds AS ProjectIds
                    ON ProjectIds.Id = Project.ProjectId
            WHERE Project.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];

        DataTable entityIds = TableParameters.CreateEntityIds(projectIds);
        parameters.AddTableValued("ProjectIds", "EntityIds", entityIds);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapMany(ProjectMapper.FromDataRow);
    }

    public IEnumerable<Project> Search(string searchValue)
    {
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
                    Project.ProjectId LIKE '%' + @SearchValue + '%'
                    OR Project.Name LIKE '%' + @SearchValue + '%'
                    OR Project.CustomerName LIKE '%' + @SearchValue + '%'
                )
                AND Project.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapMany(ProjectMapper.FromDataRow);
    }

    public IEnumerable<Project> GetManyByEmployeeId(int employeeId)
    {
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
            FROM Project
            INNER JOIN Assignment
                    ON Assignment.ProjectId = Project.ProjectId
            INNER JOIN AssignmentDetail
                    ON AssignmentDetail.AssignmentId = Assignment.AssignmentId
            WHERE AssignmentDetail.EmployeeId = @EmployeeId
                AND Project.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        return DataProvider
            .Instance.ExecuteQuery(query, [.. parameters])
            .MapMany(ProjectMapper.FromDataRow);
    }

    public int Insert(Project entity)
    {
        string query = @"
            INSERT INTO Project
            (
                Name
                , CustomerName
                , ManagerId
                , StartDate
                , EndDate
                , StatusId
            )
            VALUES
            (
                @Name
                , @CustomerName
                , @ManagerId
                , @StartDate
                , @EndDate
                , @StatusId
            )
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("Name", SqlDbType.NVarChar, 50, entity.Name);
        parameters.Add("CustomerName", SqlDbType.NVarChar, 50, entity.CustomerName);
        parameters.Add("ManagerId", SqlDbType.Int, entity.ManagerId);
        parameters.Add("StartDate", SqlDbType.Date, entity.StartDate);
        parameters.Add("EndDate", SqlDbType.Date, entity.EndDate);
        parameters.Add("StatusId", SqlDbType.Int, entity.StatusId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int Update(int projectId, ProjectUpdate info)
    {
        SqlUpdateQueryBuilder builder = new SqlUpdateQueryBuilder("Project")
            .Set("Name", SqlDbType.NVarChar, 50, info.Name)
            .Set("CustomerName", SqlDbType.NVarChar, 50, info.CustomerName)
            .Set("ManagerId", SqlDbType.Int, info.ManagerId)
            .Set("StartDate", SqlDbType.Date, info.StartDate)
            .Set("EndDate", SqlDbType.Date, info.EndDate)
            .Set("StatusId", SqlDbType.Int, info.StatusId)
            .SetDirect("UpdatedAt", SqlDbType.DateTime, DateTime.Now)
            .Where("ProjectId", SqlDbType.Int, projectId);

        (string query, List<SqlParameter> parameters) = builder.Build();

        if (string.IsNullOrEmpty(query) || parameters.Count == 0)
        {
            return 0;
        }
        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int Delete(int projectId)
    {
        string query = @"
            UPDATE Project
            SET IsDeleted = 1,
                DeletedAt = GetDate()
            WHERE ProjectId = @ProjectId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.Int, projectId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }
}
