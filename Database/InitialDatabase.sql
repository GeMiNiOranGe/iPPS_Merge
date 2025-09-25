-- NOTE:
-- For `Gender` column:
-- 1 is male, 0 is female and null is other

-- For each `IsDeleted` column:
-- + IsDeleted = 0 -> the record is active (i.e., not deleted). This is the default value.
-- + IsDeleted = 1 -> the record is soft-deleted (logically deleted).

-- For `UpdatedAt` column:
-- Set `UpdatedAt` to current datetime on any update, except when only `IsDeleted` is modified.

-- For `DeletedAt` column:
-- `DeletedAt` must be set to the current datetime when `IsDeleted` is set to 1,
-- and must be set to `NULL` when IsDeleted is set to 0.

USE [Master]
GO

DECLARE @DbName     NVARCHAR(50)  = N'Pepro' -- change DbName here and...
DECLARE @DeleteStmt NVARCHAR(Max) = N'DROP    DATABASE IF EXISTS '  + QuoteName(@DbName)
DECLARE @CreateStmt NVARCHAR(Max) = N'CREATE  DATABASE '            + QuoteName(@DbName)
EXECUTE sys.sp_ExecuteSql @Stmt = @DeleteStmt
EXECUTE sys.sp_ExecuteSql @Stmt = @CreateStmt
GO

USE [Pepro]
GO

-- have no key ----------------------------------
CREATE TABLE [dbo].[Role] (
    [RoleId]    [int]           NOT NULL IDENTITY(1,1),
    [Name]      [nvarchar](50)  NOT NULL,

    [IsDeleted] [bit]           NOT NULL,
    [CreatedAt] [datetime]      NOT NULL,
    [UpdatedAt] [datetime]      NOT NULL,
    [DeletedAt] [datetime],
);

CREATE TABLE [dbo].[Permission] (
    [PermissionId]  [int]           NOT NULL IDENTITY(1,1),
    [Key]           [varchar](100)  NOT NULL,
);

CREATE TABLE [dbo].[Department] (
    [DepartmentId]  [int]           NOT NULL IDENTITY(1, 1),
    [Name]          [nvarchar](50)  NOT NULL,

    [ManagerId]     [int],

    [IsDeleted]     [bit]           NOT NULL,
    [CreatedAt]     [datetime]      NOT NULL,
    [UpdatedAt]     [datetime]      NOT NULL,
    [DeletedAt]     [datetime],
);

CREATE TABLE [dbo].[Status] (
    [StatusId]  [int]           NOT NULL IDENTITY(1, 1),
    [Name]      [varchar](10)   NOT NULL,
);

CREATE TABLE [dbo].[Position] (
    [PositionId]        [int]           NOT NULL IDENTITY(1, 1),
    [Title]             [nvarchar](20)  NOT NULL,
    [AllowancePercent]  [decimal](4, 2) NOT NULL,
);

CREATE TABLE [dbo].[SalaryScale] (
    [SalaryScaleId] [int]           NOT NULL IDENTITY(1, 1),
    [Group]         [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
);

-- has a foreign key ----------------------------
CREATE TABLE [dbo].[Project] (
    [ProjectId]     [int]           NOT NULL IDENTITY(1, 1),
    [Name]          [nvarchar](50)  NOT NULL,
    [CustomerName]  [nvarchar](50)  NOT NULL,
    [StartDate]     [date]          NOT NULL,
    [EndDate]       [date]          NOT NULL,

    [ManagerId]     [int],
    [StatusId]      [int]           NOT NULL,

    [IsDeleted]     [bit]           NOT NULL,
    [CreatedAt]     [datetime]      NOT NULL,
    [UpdatedAt]     [datetime]      NOT NULL,
    [DeletedAt]     [datetime],
);

CREATE TABLE [dbo].[SalaryLevel] (
    [SalaryLevelId] [int]           NOT NULL IDENTITY(1, 1),
    [Level]         [nvarchar](10)  NOT NULL,
    [Coefficient]   [decimal](4, 2) NOT NULL,

    [SalaryScaleId] [int]           NOT NULL,
);

CREATE TABLE [dbo].[Employee] (
    [EmployeeId]    [int]           NOT NULL IDENTITY(1, 1),
    [FirstName]     [nvarchar](10)  NOT NULL,
    [MiddleName]    [nvarchar](30),
    [LastName]      [nvarchar](10)  NOT NULL,
    [DateOfBirth]   [date]          NOT NULL,
    [Gender]        [bit],
    [TaxCode]       [varbinary](max),
    [CitizenId]     [varchar](12)   NOT NULL,
    -- TODO: add address column

    [DepartmentId]  [int]           NOT NULL,
    [PositionId]    [int]           NOT NULL,
    [SalaryLevelId] [int]           NOT NULL,

    [IsDeleted]     [bit]           NOT NULL,
    [CreatedAt]     [datetime]      NOT NULL,
    [UpdatedAt]     [datetime]      NOT NULL,
    [DeletedAt]     [datetime],
);

CREATE TABLE [dbo].[EmployeePhoneNumber] (
    [EmployeePhoneNumberId] [int]       NOT NULL IDENTITY(1, 1),
    [PhoneNumber]           [char](10)  NOT NULL,

    [EmployeeId]            [int]       NOT NULL,
);

CREATE TABLE [dbo].[Account] (
    [AccountId]  [int]              NOT NULL IDENTITY(1, 1),
    [Username]   [varchar](255)     NOT NULL,
    [Salt]       [varbinary](max)   NOT NULL,
    [Password]   [varbinary](max)   NOT NULL,
    [IsActive]   [bit]              NOT NULL,
    -- TODO: add email column
    
    [EmployeeId] [int]              NOT NULL,

    [IsDeleted]  [bit]              NOT NULL,
    [CreatedAt]  [datetime]         NOT NULL,
    [UpdatedAt]  [datetime]         NOT NULL,
    [DeletedAt]  [datetime],
);

CREATE TABLE [dbo].[Assignment] (
    [AssignmentId]          [int]           NOT NULL IDENTITY(1, 1),
    [Name]                  [nvarchar](50)  NOT NULL,
    [IsPublicToProject]     [bit]           NOT NULL,
    [IsPublicToDepartment]  [bit]           NOT NULL,
    [StartDate]             [date]          NOT NULL,
    [EndDate]               [date]          NOT NULL,
    [RequiredDocumentCount] [int]           NOT NULL,

    [ManagerId]             [int],
    [ProjectId]             [int]           NOT NULL,
    [StatusId]              [int]           NOT NULL,

    [IsDeleted]             [bit]           NOT NULL,
    [CreatedAt]             [datetime]      NOT NULL,
    [UpdatedAt]             [datetime]      NOT NULL,
    [DeletedAt]             [datetime],
);

CREATE TABLE [dbo].[Document] (
    [DocumentId]        [int]           NOT NULL IDENTITY(1, 1),
    [Title]             [nvarchar](255) NOT NULL,
    [CreateAt]          [date]          NOT NULL,
    [RevisionNumber]    [int]           NOT NULL,
    [RevisionStatus]    [varchar](10)   NOT NULL, -- latest, private, public
    [DocumentUrl]       [varchar](500)  NOT NULL,
    [NativeFileFormat]  [varchar](20)   NOT NULL,
    [PreparedBy]        [nvarchar](100),
    [CheckedBy]         [nvarchar](100),
    [ApprovedBy]        [nvarchar](100),

    [AssignmentId]      [int]           NOT NULL,

    [IsDeleted]         [bit]           NOT NULL,
);

-- many-to-many relationship --------------------
CREATE TABLE [dbo].[RolePermission] (
    [RolePermissionId]  [int]   NOT NULL IDENTITY(1, 1),

    [RoleId]            [int]   NOT NULL,
    [PermissionId]      [int]   NOT NULL,
);

CREATE TABLE [dbo].[AccountRole] (
    [AccountRoleId] [int]   NOT NULL IDENTITY(1, 1),

    [AccountId]     [int]   NOT NULL,
    [RoleId]        [int]   NOT NULL,
);

CREATE TABLE [AssignmentDetail] (
    [AssignmentDetailId]    [int]   NOT NULL IDENTITY(1, 1),

    [EmployeeId]            [int]   NOT NULL,
    [AssignmentId]          [int]   NOT NULL,
);

CREATE TABLE [DepartmentProject] (
    [DepartmentProjectId]   [int]   NOT NULL IDENTITY(1, 1),

    [ProjectId]             [int]   NOT NULL,
    [DepartmentId]          [int]   NOT NULL,
);
GO

-- add unique key --------------------------------------------------------
ALTER TABLE [dbo].[Account]
ADD CONSTRAINT [UK_Username]      UNIQUE ([Username])
  , CONSTRAINT [UK_EmployeeId]    UNIQUE ([EmployeeId])
GO

-- add primary key -------------------------------------------------------
ALTER TABLE [dbo].[Role]                ADD CONSTRAINT [PK_Role]                PRIMARY KEY ([RoleId]);
ALTER TABLE [dbo].[Permission]          ADD CONSTRAINT [PK_Permission]          PRIMARY KEY ([PermissionId]);
ALTER TABLE [dbo].[Department]          ADD CONSTRAINT [PK_Department]          PRIMARY KEY ([DepartmentId])
ALTER TABLE [dbo].[Status]              ADD CONSTRAINT [PK_Status]              PRIMARY KEY ([StatusId])
ALTER TABLE [dbo].[Position]            ADD CONSTRAINT [PK_Position]            PRIMARY KEY ([PositionId])
ALTER TABLE [dbo].[SalaryScale]         ADD CONSTRAINT [PK_SalaryScale]         PRIMARY KEY ([SalaryScaleId]);
ALTER TABLE [dbo].[Project]             ADD CONSTRAINT [PK_Project]             PRIMARY KEY ([ProjectId])
ALTER TABLE [dbo].[SalaryLevel]         ADD CONSTRAINT [PK_SalaryLevel]         PRIMARY KEY ([SalaryLevelId]);
ALTER TABLE [dbo].[Employee]            ADD CONSTRAINT [PK_Employee]            PRIMARY KEY ([EmployeeId])
ALTER TABLE [dbo].[EmployeePhoneNumber] ADD CONSTRAINT [PK_EmployeePhoneNumber] PRIMARY KEY ([EmployeePhoneNumberId])
ALTER TABLE [dbo].[Account]             ADD CONSTRAINT [PK_Account]             PRIMARY KEY ([AccountId])
ALTER TABLE [dbo].[Assignment]          ADD CONSTRAINT [PK_Assignment]          PRIMARY KEY ([AssignmentId])
ALTER TABLE [dbo].[Document]            ADD CONSTRAINT [PK_Document]            PRIMARY KEY ([DocumentId])
ALTER TABLE [dbo].[RolePermission]      ADD CONSTRAINT [PK_RolePermission]      PRIMARY KEY ([RolePermissionId])
ALTER TABLE [dbo].[AccountRole]         ADD CONSTRAINT [PK_AccountRole]         PRIMARY KEY ([AccountRoleId])
ALTER TABLE [dbo].[AssignmentDetail]    ADD CONSTRAINT [PK_AssignmentDetail]    PRIMARY KEY ([AssignmentDetailId])
ALTER TABLE [dbo].[DepartmentProject]   ADD CONSTRAINT [PK_DepartmentProject]   PRIMARY KEY ([DepartmentProjectId])
GO

-- add foreign key -------------------------------------------------------
ALTER TABLE [dbo].[Department] ADD
CONSTRAINT [FK_Department_Employee]
    FOREIGN KEY ([ManagerId])
    REFERENCES [dbo].[Employee]([EmployeeId]);
GO

ALTER TABLE [dbo].[Project] ADD
CONSTRAINT [FK_Project_Employee]
    FOREIGN KEY ([ManagerId])
    REFERENCES [dbo].[Employee]([EmployeeId]),
CONSTRAINT [FK_Project_Status]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]([StatusId]);
GO

ALTER TABLE [dbo].[SalaryLevel] ADD
CONSTRAINT [FK_SalaryLevel_SalaryScale]
    FOREIGN KEY ([SalaryScaleId])
    REFERENCES [dbo].[SalaryScale]([SalaryScaleId]);
GO

ALTER TABLE [dbo].[Employee] ADD
CONSTRAINT [FK_Employee_Department]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department]([DepartmentId]),
CONSTRAINT [FK_Employee_Position]
    FOREIGN KEY ([PositionId])
    REFERENCES [dbo].[Position]([PositionId]),
CONSTRAINT [FK_Employee_SalaryLevel]
    FOREIGN KEY ([SalaryLevelId])
    REFERENCES [dbo].[SalaryLevel]([SalaryLevelId]);
GO

ALTER TABLE [dbo].[EmployeePhoneNumber] ADD
CONSTRAINT [FK_EmployeePhoneNumber_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]);
GO

ALTER TABLE [dbo].[Account] ADD
CONSTRAINT [FK_Account_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]);
GO

ALTER TABLE [dbo].[Assignment] ADD
CONSTRAINT [FK_Assignment_Employee]
    FOREIGN KEY ([ManagerId])
    REFERENCES [dbo].[Employee]([EmployeeId]),
CONSTRAINT [FK_Assignment_Project]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Project]([ProjectId]),
CONSTRAINT [FK_Assignment_Status]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]([StatusId]);
GO

ALTER TABLE [dbo].[Document] ADD
CONSTRAINT [FK_Document_Assignment]
    FOREIGN KEY ([AssignmentId])
    REFERENCES [dbo].[Assignment]([AssignmentId]);
GO

ALTER TABLE [dbo].[RolePermission] ADD
CONSTRAINT [FK_RolePermission_Role]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Role]([RoleId]),
CONSTRAINT [FK_RolePermission_Permission]
    FOREIGN KEY ([PermissionId])
    REFERENCES [dbo].[Permission]([PermissionId]);
GO

ALTER TABLE [dbo].[AccountRole] ADD
CONSTRAINT [FK_AccountRole_Account]
    FOREIGN KEY ([AccountId])
    REFERENCES [dbo].[Account]([AccountId]),
CONSTRAINT [FK_AccountRole_Role]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Role]([RoleId]);
GO

ALTER TABLE [dbo].[AssignmentDetail] ADD
CONSTRAINT [FK_AssignmentDetail_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]),
CONSTRAINT [FK_AssignmentDetail_Assignment]
    FOREIGN KEY ([AssignmentId])
    REFERENCES [dbo].[Assignment]([AssignmentId]);
GO

ALTER TABLE [dbo].[DepartmentProject] ADD
CONSTRAINT [FK_DepartmentProject_Project]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Project]([ProjectId]),
CONSTRAINT [FK_DepartmentProject_Department]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department]([DepartmentId]);
GO

-- default ---------------------------------------------------------------
ALTER TABLE [Role] ADD
CONSTRAINT DF_Role_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Role_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Role_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Department ADD
CONSTRAINT DF_Department_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Department_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Department_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Project ADD
CONSTRAINT DF_Project_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Project_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Project_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Employee ADD
CONSTRAINT DF_Employee_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Employee_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Employee_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Account ADD
CONSTRAINT DF_Account_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Account_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Account_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Assignment ADD
CONSTRAINT DF_Assignment_IsDeleted DEFAULT 0
    FOR IsDeleted,
CONSTRAINT DF_Assignment_CreatedAt DEFAULT GetDate()
    FOR CreatedAt,
CONSTRAINT DF_Assignment_UpdatedAt DEFAULT GetDate()
    FOR UpdatedAt;
GO

ALTER TABLE Document ADD
CONSTRAINT DF_Document_IsDeleted DEFAULT 0
    FOR IsDeleted;
GO
