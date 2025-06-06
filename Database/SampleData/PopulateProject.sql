CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDummyProject]
    @ProjectId          VARCHAR(10),
    @Name               NVARCHAR(50),
    @CustomerName       NVARCHAR(50),
    @ManagerId          VARCHAR(10),
    @DaysBeforeToday    INT,
    @DaysAfterToday     INT,
    @StatusId           INT
AS BEGIN
    SET NOCOUNT ON

    DECLARE @CurrentDate DATE
    DECLARE @StartDate   DATE
    DECLARE @EndDate     DATE

    SET @CurrentDate = GetDate()
    SET @StartDate   = DateAdd(DAY, @DaysBeforeToday, @CurrentDate)
    SET @EndDate     = DateAdd(DAY, @DaysAfterToday, @CurrentDate)

    INSERT INTO [dbo].[Project]
            ([ProjectId], [CustomerName], [ManagerId], [StartDate], [EndDate], [StatusId], [Name])
    VALUES  (@ProjectId,  @CustomerName,  @ManagerId,  @StartDate,  @EndDate,  @StatusId,  @Name)
END
GO

EXECUTE [dbo].[usp_CreateDummyProject]
    @ProjectId       = 'PRJ00001'
  , @Name            = N'Dự án nâng cấp nhà máy sản xuất vi mạch'
  , @CustomerName    = N'Tập Đoàn Nubot'
  , @ManagerId       = 'EMP00001'
  , @DaysBeforeToday = -20
  , @DaysAfterToday  = 5
  , @StatusId        = 1

EXECUTE [dbo].[usp_CreateDummyProject]
    @ProjectId       = 'PRJ00002'
  , @Name            = N'Dự án triển khai mô hình chăn nuôi hiện đại'
  , @CustomerName    = N'Công ty Hừng Đông'
  , @ManagerId       = 'EMP00002'
  , @DaysBeforeToday = -87
  , @DaysAfterToday  = 17
  , @StatusId        = 2

EXECUTE [dbo].[usp_CreateDummyProject]
    @ProjectId       = 'PRJ00003'
  , @Name            = N'Dự án bất động sản BaterHam'
  , @CustomerName    = N'ông Đặng Văn Tuấn'
  , @ManagerId       = 'EMP00003'
  , @DaysBeforeToday = -87
  , @DaysAfterToday  = 7
  , @StatusId        = 3

EXECUTE [dbo].[usp_CreateDummyProject]
    @ProjectId       = 'PRJ00004'
  , @Name            = N'Dự án nghiên cứu mô hình trồng cây tự động'
  , @CustomerName    = N'bà Đặng Ngọc Thúy'
  , @ManagerId       = 'EMP00004'
  , @DaysBeforeToday = -8
  , @DaysAfterToday  = 7
  , @StatusId        = 4
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_CreateDummyProject'
) BEGIN
    DROP PROCEDURE [dbo].[usp_CreateDummyProject]
END
GO
