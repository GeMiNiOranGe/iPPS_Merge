CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDummyProject]
    @Name               NVARCHAR(50),
    @CustomerName       NVARCHAR(50),
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
            ([CustomerName], [StartDate], [EndDate], [StatusId], [Name])
    VALUES  (@CustomerName,  @StartDate,  @EndDate,  @StatusId,  @Name)
END
GO

EXECUTE [dbo].[usp_CreateDummyProject]
    @Name            = N'Dự án nâng cấp nhà máy sản xuất vi mạch'
  , @CustomerName    = N'Tập Đoàn Nubot'
  , @DaysBeforeToday = -20
  , @DaysAfterToday  = 5
  , @StatusId        = 1

EXECUTE [dbo].[usp_CreateDummyProject]
    @Name            = N'Dự án triển khai mô hình chăn nuôi hiện đại'
  , @CustomerName    = N'Công ty Hừng Đông'
  , @DaysBeforeToday = -87
  , @DaysAfterToday  = 17
  , @StatusId        = 2

EXECUTE [dbo].[usp_CreateDummyProject]
    @Name            = N'Dự án bất động sản BaterHam'
  , @CustomerName    = N'ông Đặng Văn Tuấn'
  , @DaysBeforeToday = -87
  , @DaysAfterToday  = 7
  , @StatusId        = 3

EXECUTE [dbo].[usp_CreateDummyProject]
    @Name            = N'Dự án nghiên cứu mô hình trồng cây tự động'
  , @CustomerName    = N'bà Đặng Ngọc Thúy'
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
