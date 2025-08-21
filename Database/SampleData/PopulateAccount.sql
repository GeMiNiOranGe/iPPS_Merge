CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDummyDefaultAccount]
    @EmployeeId INT,
    @Username   VARCHAR(50)
AS BEGIN
    SET NOCOUNT ON

    DECLARE @DefaultUsername    VARCHAR(75)
    DECLARE @DefaultPassword    VARCHAR(75)
    DECLARE @Salt               VARBINARY(Max)
    DECLARE @HashedPassword     VARBINARY(Max)
    DECLARE @SaltedPassword     VARCHAR(Max)

    SET @DefaultUsername = @Username + Cast(@EmployeeId AS VARCHAR(Max))

    SET @DefaultPassword = @DefaultUsername
    SET @Salt            = crypt_gen_random(32)
    SET @SaltedPassword  = @DefaultPassword + Cast(@Salt AS VARCHAR(Max))
    SET @HashedPassword  = Cast(HashBytes('SHA2_256', @SaltedPassword) AS VARBINARY(Max))

    INSERT INTO [dbo].[Account]
            ([Username],        [Password],      [Salt], [IsActive], [EmployeeId])
    VALUES  (@DefaultUsername,  @HashedPassword, @Salt,  1,          @EmployeeId)
END
GO

EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 1,  @Username = 'tttoan'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 2,  @Username = 'pttai'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 3,  @Username = 'ttnchau'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 4,  @Username = 'tatuan'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 5,  @Username = 'tdvu'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 6,  @Username = 'tmanh'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 7,  @Username = 'vtrac'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 8,  @Username = 'pnnlam'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 9,  @Username = 'hvu'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 10, @Username = 'thnga'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 11, @Username = 'ptphong'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 12, @Username = 'tnmi'
EXECUTE [dbo].[usp_CreateDummyDefaultAccount] @EmployeeId = 13, @Username = 'ptntuan'
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_CreateDummyDefaultAccount'
) BEGIN
    DROP PROCEDURE [dbo].[usp_CreateDummyDefaultAccount]
END
GO
