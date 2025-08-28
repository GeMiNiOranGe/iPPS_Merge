using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
using System.Data;

namespace Pepro.DataAccess;

public class AssignmentDataAccess {
    private static AssignmentDataAccess? instance;

    public static AssignmentDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private AssignmentDataAccess() { }

    public List<Assignment> GetAssignments() {
        string query = @"
            SELECT Assignment.AssignmentId
                , Assignment.Name
                , Assignment.IsPublicToProject
                , Assignment.IsPublicToDepartment
                , Assignment.ManagerId
                , Assignment.StartDate
                , Assignment.EndDate
                , Assignment.RequiredDocumentCount
                , Assignment.ProjectId
                , Assignment.StatusId
                , Assignment.IsDeleted
                , Assignment.CreatedAt
                , Assignment.UpdatedAt
                , Assignment.DeletedAt
            FROM Assignment 
            WHERE Assignment.IsDeleted = 0
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Assignment> assignments = [];
        foreach (DataRow row in dataTable.Rows) {
            Assignment assignment = AssignmentMapper.FromDataRow(row);
            assignments.Add(assignment);
        }
        return assignments;
    }

    public List<Assignment> SearchAssignments(string searchValue) {
        string query = @"
            SELECT Assignment.AssignmentId
                , Assignment.Name
                , Assignment.IsPublicToProject
                , Assignment.IsPublicToDepartment
                , Assignment.ManagerId
                , Assignment.StartDate
                , Assignment.EndDate
                , Assignment.RequiredDocumentCount
                , Assignment.ProjectId
                , Assignment.StatusId
                , Assignment.IsDeleted
                , Assignment.CreatedAt
                , Assignment.UpdatedAt
                , Assignment.DeletedAt
            FROM Assignment 
            WHERE
                (
                    Assignment.AssignmentId LIKE '%' + @SearchValue + '%'
                    OR Assignment.Name LIKE '%' + @SearchValue + '%'
                )
                AND Assignment.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Assignment> assignments = [];
        foreach (DataRow row in dataTable.Rows) {
            Assignment assignment = AssignmentMapper.FromDataRow(row);
            assignments.Add(assignment);
        }
        return assignments;
    }

    public List<Assignment> GetAssignmentsByProjectId(int projectId) {
        string query = @"
            SELECT Assignment.AssignmentId
                , Assignment.Name
                , Assignment.IsPublicToProject
                , Assignment.IsPublicToDepartment
                , Assignment.ManagerId
                , Assignment.StartDate
                , Assignment.EndDate
                , Assignment.RequiredDocumentCount
                , Assignment.ProjectId
                , Assignment.StatusId
                , Assignment.IsDeleted
                , Assignment.CreatedAt
                , Assignment.UpdatedAt
                , Assignment.DeletedAt
            FROM Assignment 
            WHERE Assignment.ProjectId = @ProjectId
                AND Assignment.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.Int, projectId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Assignment> assignments = [];
        foreach (DataRow row in dataTable.Rows) {
            Assignment assignment = AssignmentMapper.FromDataRow(row);
            assignments.Add(assignment);
        }
        return assignments;
    }

    public List<Assignment> GetAssignmentsByEmployeeId(int employeeId) {
        string query = @"
            SELECT Assignment.AssignmentId
                , Assignment.Name
                , Assignment.IsPublicToProject
                , Assignment.IsPublicToDepartment
                , Assignment.ManagerId
                , Assignment.StartDate
                , Assignment.EndDate
                , Assignment.RequiredDocumentCount
                , Assignment.ProjectId
                , Assignment.StatusId
                , Assignment.IsDeleted
                , Assignment.CreatedAt
                , Assignment.UpdatedAt
                , Assignment.DeletedAt
            FROM Assignment
            INNER JOIN AssignmentDetail
                    ON AssignmentDetail.AssignmentId = Assignment.AssignmentId
            WHERE AssignmentDetail.EmployeeId = @EmployeeId
                AND Assignment.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Assignment> assignments = [];
        foreach (DataRow row in dataTable.Rows) {
            Assignment assignment = AssignmentMapper.FromDataRow(row);
            assignments.Add(assignment);
        }
        return assignments;
    }

    /// <summary>
    ///     Take out the manager of the assignment
    /// </summary>
    /// <param name="assignmentId">Assignment id</param>
    /// <returns>
    ///     Manager
    /// </returns>
    public Employee? GetAssignmentManager(int assignmentId) {
        string query = @"
            SELECT Employee.EmployeeId
                , Employee.FirstName
                , Employee.MiddleName
                , Employee.LastName
                , Employee.DateOfBirth
                , Employee.Gender
                , Employee.TaxCode
                , Employee.CitizenId
                , Employee.DepartmentId
                , Employee.PositionId
                , Employee.SalaryLevelId
                , Employee.IsDeleted
                , Employee.CreatedAt
                , Employee.UpdatedAt
                , Employee.DeletedAt
            FROM Employee
            INNER JOIN Assignment
                    ON Assignment.ManagerId = Employee.EmployeeId
            WHERE Assignment.AssignmentId = @AssignmentId
                AND Employee.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("AssignmentId", SqlDbType.VarChar, 10, assignmentId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return EmployeeMapper.FromDataRow(row);
    }

    public Assignment? GetAssignmentByDocumentId(int documentId) {
        string query = @"
            SELECT Assignment.AssignmentId
                , Assignment.Name
                , Assignment.IsPublicToProject
                , Assignment.IsPublicToDepartment
                , Assignment.ManagerId
                , Assignment.StartDate
                , Assignment.EndDate
                , Assignment.RequiredDocumentCount
                , Assignment.ProjectId
                , Assignment.StatusId
                , Assignment.IsDeleted
                , Assignment.CreatedAt
                , Assignment.UpdatedAt
                , Assignment.DeletedAt
            FROM Assignment
            INNER JOIN Document
                    ON Document.AssignmentId = Assignment.AssignmentId
            WHERE Document.DocumentId = @DocumentId
                AND Assignment.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("DocumentId", SqlDbType.Int, documentId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return AssignmentMapper.FromDataRow(row);
    }
}
