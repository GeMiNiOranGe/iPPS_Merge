-- Admin ----------------------------------------------------------------------
INSERT INTO [dbo].[RolePermission]
(
    [RoleId]
    , [PermissionId]
)
SELECT [Role].[RoleId]
    , [Permission].[PermissionId]
FROM [dbo].[Role] CROSS JOIN [dbo].[Permission]
WHERE [Role].[Name] = N'Admin';
GO

-- Other ----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       NVARCHAR(100),
    @PermissionKeys VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Separator  VARCHAR(1)
    DECLARE @KeyList    TABLE ([Key] VARCHAR(255));
    DECLARE @RoleId     INT;

    SET @Separator = '|'

    INSERT INTO @KeyList
            ([Key])
    SELECT  LTrim(RTrim(value))
    FROM string_split(@PermissionKeys, @Separator)
    WHERE LTrim(RTrim(value)) <> '';

    SELECT @RoleId = RoleId
    FROM [dbo].[Role]
    WHERE Role.Name = @RoleName;

    INSERT INTO [dbo].[RolePermission]
            ([RoleId],          [PermissionId])
    SELECT   @RoleId, Permission.PermissionId
    FROM [dbo].[Permission]
    INNER JOIN @KeyList AS KeyList
            ON KeyList.[Key] = Permission.[Key];
END
GO

EXECUTE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       = N'Employee'
  , @PermissionKeys = N'Assignment.Read|Employee.Read|Project.Read'

EXECUTE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       = N'DepartmentHead'
  , @PermissionKeys = N'Department.Read'

EXECUTE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       = N'HR'
  , @PermissionKeys = N'Employee.Create|Employee.Update|Employee.Delete'

EXECUTE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       = N'Finance'
  , @PermissionKeys = N'Salary.Read|Salary.Update'

EXECUTE [dbo].[usp_CreateDummyRolePermission]
    @RoleName       = N'IT'
  , @PermissionKeys = N'Account.Create|Account.Read|Account.Update|Account.Delete|Role.Create|Role.Read|Role.Update|Role.Delete'
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
        AND SPECIFIC_NAME = N'usp_CreateDummyRolePermission'
) BEGIN
    DROP PROCEDURE [dbo].[usp_CreateDummyRolePermission]
END
GO
