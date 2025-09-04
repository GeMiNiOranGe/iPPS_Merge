-- Department -----------------------------------------------------------------

DECLARE @DepartmentUpdate TABLE (
    DepartmentId INT IDENTITY(1,1),
    ManagerId INT
);

INSERT INTO @DepartmentUpdate
        (ManagerId)
VALUES  (1)
     ,  (2)
     ,  (3)

UPDATE Department
SET Department.ManagerId = DepartmentUpdate.ManagerId
FROM [dbo].[Department]
INNER JOIN @DepartmentUpdate AS DepartmentUpdate
        ON DepartmentUpdate.DepartmentId = Department.DepartmentId
GO

-- Project --------------------------------------------------------------------

DECLARE @ProjectUpdate TABLE (
    ProjectId INT IDENTITY(1,1),
    ManagerId INT
);

INSERT INTO @ProjectUpdate
        (ManagerId)
VALUES  (1)
     ,  (2)
     ,  (3)
     ,  (4)

UPDATE Project
SET Project.ManagerId = ProjectUpdate.ManagerId
FROM [dbo].[Project]
INNER JOIN @ProjectUpdate AS ProjectUpdate
        ON ProjectUpdate.ProjectId = Project.ProjectId
GO

-- Assignment -----------------------------------------------------------------

DECLARE @AssignmentUpdate TABLE (
    AssignmentId INT IDENTITY(1,1),
    ManagerId INT
);

INSERT INTO @AssignmentUpdate
        (ManagerId)
VALUES  (4)
     ,  (4)
     ,  (4)
     ,  (4)
     ,  (6)
     ,  (6)
     ,  (6)
     ,  (6)
     ,  (11)
     ,  (11)
     ,  (11)
     ,  (11)

UPDATE Assignment
SET Assignment.ManagerId = AssignmentUpdate.ManagerId
FROM [dbo].[Assignment]
INNER JOIN @AssignmentUpdate AS AssignmentUpdate
        ON AssignmentUpdate.AssignmentId = Assignment.AssignmentId
GO
