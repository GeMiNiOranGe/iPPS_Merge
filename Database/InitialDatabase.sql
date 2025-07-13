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

-- create security key --------------------------
CREATE SYMMETRIC KEY PeproSymKey
    WITH ALGORITHM = AES_256
    ENCRYPTION BY PASSWORD = 'W34kP4ssw0rd@'
GO

-- have no key ----------------------------------
CREATE TABLE [dbo].[Department] (
    [DepartmentId]  [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
    [ManagerId]     [varchar](10)   NOT NULL,
);

CREATE TABLE [dbo].[Status] (
    [StatusId]      [int]           NOT NULL IDENTITY(1, 1),
    [StatusValue]   [varchar](10)   NOT NULL,
);

CREATE TABLE [dbo].[JobPosition] (
    [JobPositionId]         [int]           NOT NULL IDENTITY(1, 1),
    [JobTitle]              [nvarchar](20)  NOT NULL,
    [AllowanceCoefficient]  [decimal](4, 2) NOT NULL, --TODO: Encrypt
);

CREATE TABLE [dbo].[SalaryScale] (
    [SalaryScaleId] [int]           NOT NULL IDENTITY(1, 1),
    [Group]         [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
);

-- has a foreign key ----------------------------
CREATE TABLE [dbo].[Project] (
    [ProjectId]     [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
    [CustomerName]  [nvarchar](50)  NOT NULL,
    [ManagerId]     [varchar](10)   NOT NULL,
    [StartDate]     [date]          NOT NULL,
    [EndDate]       [date]          NOT NULL,

    [StatusId]      [int]           NOT NULL,
);

CREATE TABLE [dbo].[SalaryLevel] (
    [SalaryLevelId] [int]           NOT NULL IDENTITY(1, 1),
    [Level]         [nvarchar](10)  NOT NULL,
    [Coefficient]   [decimal](4, 2) NOT NULL,

    [SalaryScaleId] [int]           NOT NULL,
);

CREATE TABLE [dbo].[Employee] (
    [EmployeeId]    [varchar](10)   NOT NULL,
    [FirstName]     [nvarchar](10)  NOT NULL,
    [MiddleName]    [nvarchar](30),
    [LastName]      [nvarchar](10)  NOT NULL,
    [DateOfBirth]   [date]          NOT NULL,
    [Gender]        [bit], -- 1 is male, 0 is female and null is other
    [TaxCode]       [varbinary](max),
    [CitizenId]     [varchar](12)   NOT NULL,
    -- TODO: add address column

    [DepartmentId]  [varchar](10)   NOT NULL,
    [JobPositionId] [int]           NOT NULL,
    [SalaryLevelId] [int]           NOT NULL,
);

CREATE TABLE [dbo].[EmployeePhoneNumber] (
    [EmployeePhoneNumberId] [int]           NOT NULL IDENTITY(1, 1),
    [PhoneNumber]           [char](10)      NOT NULL,

    [EmployeeId]            [varchar](10)   NOT NULL,
);

CREATE TABLE [dbo].[Account] (
    [AccountId]  [int]              NOT NULL IDENTITY(1, 1),
    [Username]   [varchar](255)     NOT NULL,
    [Salt]       [varbinary](max)   NOT NULL,
    [Password]   [varbinary](max)   NOT NULL,
    [IsActive]   [bit]              NOT NULL,
    -- TODO: add email column
    
    [EmployeeId] [varchar](10)      NOT NULL,
);

CREATE TABLE [dbo].[Task] (
    [TaskId]                [int]           NOT NULL IDENTITY(1, 1),
    [Name]                  [nvarchar](50)  NOT NULL,
    [IsPublicToProject]     [bit]           NOT NULL,
    [IsPublicToDepartment]  [bit]           NOT NULL,
    [ManagerId]             [varchar](10)   NOT NULL,
    [StartDate]             [date]          NOT NULL,
    [EndDate]               [date]          NOT NULL,

    [ProjectId]             [varchar](10)   NOT NULL,
    [StatusId]              [int]           NOT NULL,
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

    [TaskId]            [int]           NOT NULL,
);

-- many-to-many relationship --------------------
CREATE TABLE [TaskDetail] (
    [TaskDetailId]  [int]           NOT NULL IDENTITY(1, 1),

    [EmployeeId]    [varchar](10)   NOT NULL,
    [TaskId]        [int]           NOT NULL,
);

CREATE TABLE [DepartmentProject] (
    [DepartmentProjectId]   [int]           NOT NULL IDENTITY(1, 1),

    [ProjectId]             [varchar](10)   NOT NULL,
    [DepartmentId]          [varchar](10)   NOT NULL,
);
GO

-- add unique key --------------------------------------------------------
ALTER TABLE [dbo].[Account]
ADD CONSTRAINT [UK_Username]      UNIQUE ([Username])
  , CONSTRAINT [UK_EmployeeId]    UNIQUE ([EmployeeId])
GO

-- add primary key -------------------------------------------------------
ALTER TABLE [dbo].[Department]          ADD CONSTRAINT [PK_Department]          PRIMARY KEY ([DepartmentId])
ALTER TABLE [dbo].[Status]              ADD CONSTRAINT [PK_Status]              PRIMARY KEY ([StatusId])
ALTER TABLE [dbo].[JobPosition]         ADD CONSTRAINT [PK_JobPosition]         PRIMARY KEY ([JobPositionId])
ALTER TABLE [dbo].[SalaryScale]         ADD CONSTRAINT [PK_SalaryScale]         PRIMARY KEY ([SalaryScaleId]);
ALTER TABLE [dbo].[Project]             ADD CONSTRAINT [PK_Project]             PRIMARY KEY ([ProjectId])
ALTER TABLE [dbo].[SalaryLevel]         ADD CONSTRAINT [PK_SalaryLevel]         PRIMARY KEY ([SalaryLevelId]);
ALTER TABLE [dbo].[Employee]            ADD CONSTRAINT [PK_Employee]            PRIMARY KEY ([EmployeeId])
ALTER TABLE [dbo].[EmployeePhoneNumber] ADD CONSTRAINT [PK_EmployeePhoneNumber] PRIMARY KEY ([EmployeePhoneNumberId])
ALTER TABLE [dbo].[Account]             ADD CONSTRAINT [PK_Account]             PRIMARY KEY ([AccountId])
ALTER TABLE [dbo].[Task]                ADD CONSTRAINT [PK_Task]                PRIMARY KEY ([TaskId])
ALTER TABLE [dbo].[Document]            ADD CONSTRAINT [PK_Document]            PRIMARY KEY ([DocumentId])
ALTER TABLE [dbo].[TaskDetail]          ADD CONSTRAINT [PK_TaskDetail]          PRIMARY KEY ([TaskDetailId])
GO

-- add foreign key -------------------------------------------------------
ALTER TABLE [dbo].[Project] ADD
CONSTRAINT [FK_Project_Status]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]([StatusId]);
GO

ALTER TABLE [dbo].[SalaryLevel] ADD
CONSTRAINT [FK_SalaryLevel_SalaryScale]
    FOREIGN KEY ([SalaryScaleId])
    REFERENCES [dbo].[SalaryScale]([SalaryScaleId]);
GO

ALTER TABLE [dbo].[EmployeePhoneNumber] ADD
CONSTRAINT [FK_EmployeePhoneNumber_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]);
GO

ALTER TABLE [dbo].[Employee] ADD
CONSTRAINT [FK_Employee_Department]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department]([DepartmentId]),
CONSTRAINT [FK_Employee_JobPosition]
    FOREIGN KEY ([JobPositionId])
    REFERENCES [dbo].[JobPosition]([JobPositionId]),
CONSTRAINT [FK_Employee_SalaryLevel]
    FOREIGN KEY ([SalaryLevelId])
    REFERENCES [dbo].[SalaryLevel]([SalaryLevelId]);
GO

ALTER TABLE [dbo].[Account] ADD
CONSTRAINT [FK_Account_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]);
GO

ALTER TABLE [dbo].[Task] ADD
CONSTRAINT [FK_Task_Project]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Project]([ProjectId]),
CONSTRAINT [FK_Task_Status]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]([StatusId]);
GO

ALTER TABLE [dbo].[Document] ADD
CONSTRAINT [FK_Document_Task]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[Task]([TaskId]);
GO

ALTER TABLE [dbo].[TaskDetail] ADD
CONSTRAINT [FK_TaskDetail_Employee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employee]([EmployeeId]),
CONSTRAINT [FK_TaskDetail_Task]
    FOREIGN KEY ([TaskId])
    REFERENCES [dbo].[Task]([TaskId]);
GO

ALTER TABLE [dbo].[DepartmentProject] ADD
CONSTRAINT [FK_DepartmentProject_Project]
    FOREIGN KEY ([ProjectId])
    REFERENCES [dbo].[Project]([ProjectId]),
CONSTRAINT [FK_DepartmentProject_Department]
    FOREIGN KEY ([DepartmentId])
    REFERENCES [dbo].[Department]([DepartmentId]);
GO
