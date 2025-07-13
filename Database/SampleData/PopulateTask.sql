CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDummyTask]
    @Name                 NVARCHAR(50),
    @IsPublicToProject    BIT,
    @IsPublicToDepartment BIT,
    @ManagerId            VARCHAR(10),
    @DaysBeforeToday      INT,
    @DaysAfterToday       INT,
    @ProjectId            VARCHAR(10),
    @StatusId             INT
AS BEGIN
    SET NOCOUNT ON

    DECLARE @CurrentDate DATE
    DECLARE @StartDate   DATE
    DECLARE @EndDate     DATE

    SET @CurrentDate = GetDate()
    SET @StartDate   = DateAdd(DAY, @DaysBeforeToday, @CurrentDate)
    SET @EndDate     = DateAdd(DAY, @DaysAfterToday, @CurrentDate)

    INSERT INTO [dbo].[Task]
            ([Name], [IsPublicToProject], [IsPublicToDepartment], [ManagerId], [StartDate], [EndDate], [ProjectId], [StatusId])
    VALUES  (@Name,  @IsPublicToProject,  @IsPublicToDepartment,  @ManagerId,  @StartDate,  @EndDate,  @ProjectId,  @StatusId)
END
GO

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 1'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 1
  , @ManagerId            = 'EMP00004'
  , @DaysBeforeToday      = 0
  , @DaysAfterToday       = 5
  , @ProjectId            = 'PRJ00001'
  , @StatusId             = 3

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 2'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 1
  , @ManagerId            = 'EMP00004'
  , @DaysBeforeToday      = -2
  , @DaysAfterToday       = 3
  , @ProjectId            = 'PRJ00001'
  , @StatusId             = 1

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 3'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00011'
  , @DaysBeforeToday      = -20
  , @DaysAfterToday       = -15
  , @ProjectId            = 'PRJ00001'
  , @StatusId             = 4

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 4'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00011'
  , @DaysBeforeToday      = -30
  , @DaysAfterToday       = -20
  , @ProjectId            = 'PRJ00002'
  , @StatusId             = 4

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 5'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 1
  , @ManagerId            = 'EMP00011'
  , @DaysBeforeToday      = -87
  , @DaysAfterToday       = -80
  , @ProjectId            = 'PRJ00002'
  , @StatusId             = 1

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 6'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00011'
  , @DaysBeforeToday      = 10
  , @DaysAfterToday       = 17
  , @ProjectId            = 'PRJ00002'
  , @StatusId             = 5

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 7'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00004'
  , @DaysBeforeToday      = -6
  , @DaysAfterToday       = 1
  , @ProjectId            = 'PRJ00003'
  , @StatusId             = 2

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 8'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 1
  , @ManagerId            = 'EMP00004'
  , @DaysBeforeToday      = -87
  , @DaysAfterToday       = -80
  , @ProjectId            = 'PRJ00003'
  , @StatusId             = 5

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 9'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00006'
  , @DaysBeforeToday      = -10
  , @DaysAfterToday       = 7
  , @ProjectId            = 'PRJ00003'
  , @StatusId             = 2

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 10'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00006'
  , @DaysBeforeToday      = 5
  , @DaysAfterToday       = 7
  , @ProjectId            = 'PRJ00004'
  , @StatusId             = 5

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 11'
  , @IsPublicToProject    = 1
  , @IsPublicToDepartment = 1
  , @ManagerId            = 'EMP00006'
  , @DaysBeforeToday      = -7
  , @DaysAfterToday       = 0
  , @ProjectId            = 'PRJ00004'
  , @StatusId             = 4

EXECUTE [dbo].[usp_CreateDummyTask] 
    @Name                 = N'Công việc 12'
  , @IsPublicToProject    = 0
  , @IsPublicToDepartment = 0
  , @ManagerId            = 'EMP00006'
  , @DaysBeforeToday      = -8
  , @DaysAfterToday       = 6
  , @ProjectId            = 'PRJ00004'
  , @StatusId             = 3
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_CreateDummyTask'
) BEGIN
    DROP PROCEDURE [dbo].[usp_CreateDummyTask]
END
GO
