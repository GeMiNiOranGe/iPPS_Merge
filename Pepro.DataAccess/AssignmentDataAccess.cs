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

    public List<Assignment> GetAssignmentsByProjectId(string projectId) {
        string query = @"
            SELECT AssignmentId
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , RequiredDocumentCount
                , ProjectId
                , StatusId
            FROM Assignment 
            WHERE ProjectId = @ProjectId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("ProjectId", SqlDbType.VarChar, 10, projectId);

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
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , RequiredDocumentCount
                , ProjectId
                , StatusId
            FROM Assignment
            INNER JOIN AssignmentDetail
                    ON AssignmentDetail.AssignmentId = Assignment.AssignmentId
            WHERE EmployeeId = @EmployeeId
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
                , IsDeleted
            FROM Assignment
            INNER JOIN Employee
                    ON Employee.EmployeeId = Assignment.ManagerId
            WHERE AssignmentId = @AssignmentId
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
                , Name
                , IsPublicToProject
                , IsPublicToDepartment
                , ManagerId
                , StartDate
                , EndDate
                , RequiredDocumentCount
                , ProjectId
                , StatusId
            FROM Assignment
            INNER JOIN Document
                    ON Document.AssignmentId = Assignment.AssignmentId
            WHERE Document.DocumentId = @DocumentId
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
