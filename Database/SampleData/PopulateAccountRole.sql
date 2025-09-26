CREATE PROCEDURE dbo.usp_CreateDummyAccountRole
    @AccountId INT,
    @RoleNames VARCHAR(MAX)
AS BEGIN
    SET NOCOUNT ON;

    DECLARE @Separator  VARCHAR(1)
    DECLARE @RoleList   TABLE ([Name] NVARCHAR(100));

    SET @Separator = '|'

    INSERT INTO @RoleList
            ([Name])
    SELECT  LTrim(RTrim(value))
    FROM string_split(@RoleNames, @Separator)
    WHERE LTrim(RTrim(value)) <> '';

    INSERT INTO [dbo].[AccountRole]
            ([AccountId],      [RoleId])
    SELECT   @AccountId, Role.RoleId
    FROM [dbo].[Role]
    INNER JOIN @RoleList AS RoleList
            ON RoleList.[Name] = Role.Name;
END
GO

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 1
  , @RoleNames = N'Admin'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 2
  , @RoleNames = N'Employee|DepartmentHead|HR'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 3
  , @RoleNames = N'Employee|DepartmentHead|Finance'

-- Employee -------------------------------------------------------------------
-- HR
EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 4
  , @RoleNames = N'Employee|HR|ProjectManager'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 5
  , @RoleNames = N'Employee|HR'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 6
  , @RoleNames = N'Employee|HR'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 7
  , @RoleNames = N'Employee|HR'

-- Finance
EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 8
  , @RoleNames = N'Employee|Finance|ProjectManager'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 9
  , @RoleNames = N'Employee|Finance'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 10
  , @RoleNames = N'Employee|Finance'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 11
  , @RoleNames = N'Employee|Finance'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 12
  , @RoleNames = N'Employee|HR'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 13
  , @RoleNames = N'Employee|Finance'

EXECUTE dbo.usp_CreateDummyAccountRole
    @AccountId = 14
  , @RoleNames = N'Employee|IT'
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'usp_CreateDummyAccountRole'
) BEGIN
    DROP PROCEDURE dbo.usp_CreateDummyAccountRole
END
GO
