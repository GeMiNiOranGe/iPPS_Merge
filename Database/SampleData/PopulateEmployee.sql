CREATE OR ALTER PROCEDURE [dbo].[usp_InsertDummyEmployee]
    @FirstName          NVARCHAR(10),
    @MiddleName         NVARCHAR(30)    = NULL,
    @LastName           NVARCHAR(10),
    @DateOfBirth        DATE,
    @Gender             BIT, -- 1 is male, 0 is female and null is other
    @TaxCode            VARBINARY(MAX)  = NULL,
    @CitizenId          VARCHAR(12),
    @PhoneNumberList    VARCHAR(MAX)    = NULL,
    @DepartmentId       VARCHAR(10),
    @PositionId         INT,
    @SalaryLevelId      INT
AS BEGIN
    SET NOCOUNT ON

    DECLARE @Separator          VARCHAR(2)
    DECLARE @InsertedEmployee   TABLE (EmployeeId INT)
    DECLARE @EmployeeId         INT

    SET @Separator = ','

    INSERT INTO [dbo].[Employee]
            ([FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [TaxCode], [CitizenId], [DepartmentId], [PositionId], [SalaryLevelId])
    OUTPUT Inserted.[EmployeeId] INTO @InsertedEmployee
    VALUES  (@FirstName,  @MiddleName,  @LastName,  @DateOfBirth,  @Gender,  @TaxCode,  @CitizenId,  @DepartmentId,  @PositionId,  @SalaryLevelId)

    SELECT @EmployeeId = EmployeeId FROM @InsertedEmployee
    IF (@PhoneNumberList IS NOT NULL) BEGIN
        INSERT INTO [dbo].[EmployeePhoneNumber]
                ([PhoneNumber], [EmployeeId])
        SELECT    value,        @EmployeeId
        FROM string_split(@PhoneNumberList, @Separator)
        WHERE RTrim(value) <> '';
    END
END
GO

-- giám đốc -------------------------------------
EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Toàn'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1975-09-21'
  , @Gender          = 1
  , @TaxCode         = 0x3D87A9824C41049547CB50C8F4960DD94E56D2E2D3522F363C2CB14A03EDCD43 -- 5891734895-427
  , @CitizenId       = '012735687326'
  , @PhoneNumberList = '0192381297,0284724665,0423874468,0623748736'
  , @DepartmentId    = 'Director'
  , @PositionId      = 1
  , @SalaryLevelId   = 30

-- trưởng phòng ---------------------------------
EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Tài'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Phan'
  , @DateOfBirth     = '1990-03-21'
  , @Gender          = 1
  , @TaxCode         = 0x7C82AAAF0F3E5B65B417FAAD029E7A64216E0F6417E386637836E2450FCDF669 -- 6378162539
  , @CitizenId       = '071273681763'
  , @PhoneNumberList = '0264837482,0323487687'
  , @DepartmentId    = 'HR'
  , @PositionId      = 3
  , @SalaryLevelId   = 30

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Châu'
  , @MiddleName      = N'Thị Ngọc'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1985-09-01'
  , @Gender          = 0
  , @TaxCode         = 0xAF70D120626B7C48B08903D1FB4AB52BFD50777187833E3103AFB5D919CA7B7B -- 4923874923-853
  , @CitizenId       = '034784236487'
  , @PhoneNumberList = '0213756238'
  , @DepartmentId    = 'Financial'
  , @PositionId      = 3
  , @SalaryLevelId   = 19

-- nhân viên ---------------------------------
-- phòng nhân sự
EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Tuấn'
  , @MiddleName      = N'Anh'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1995-05-19'
  , @Gender          = 1
  , @TaxCode         = 0x32DAEA90838FA9AE223CD6D6FA1B8D07782403E7A58E99A04FE1C45BFF5156C2 -- 1923157862-873
  , @CitizenId       = '060770287103'
  , @PhoneNumberList = NULL
  , @DepartmentId    = 'HR'
  , @PositionId      = 4
  , @SalaryLevelId   = 49

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Vũ'
  , @MiddleName      = N'Đình'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1990-03-15'
  , @Gender          = 1
  , @TaxCode         = 0x0C69E2F3E95AC56433026954E7F7236B96D6354360E352EF3CD109E79B738B74 -- 9257390619-759
  , @CitizenId       = '063530240085'
  , @PhoneNumberList = '0234716538'
  , @DepartmentId    = 'HR'
  , @PositionId      = 4
  , @SalaryLevelId   = 48

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Anh'
  , @MiddleName      = N'Mai'
  , @LastName        = N'Trương'
  , @DateOfBirth     = '1980-05-19'
  , @Gender          = 0
  , @TaxCode         = 0x7D28AC534FA89B14ECBDB0D298EBE605B6FC0E9B0365C7DBD3841912F726A1B4 -- 5792378571
  , @CitizenId       = '070251041576'
  , @PhoneNumberList = '0952387759'
  , @DepartmentId    = 'HR'
  , @PositionId      = 4
  , @SalaryLevelId   = 55

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Trắc'
  , @MiddleName      = NULL
  , @LastName        = N'Vương'
  , @DateOfBirth     = '1987-01-17'
  , @Gender          = 0
  , @TaxCode         = 0x3882C08E441E168CFBB4CE2B5CE3CF2B1360A45E9251AE58D61202DECFADD9D8 -- 8502935028
  , @CitizenId       = '057713588258'
  , @PhoneNumberList = '0480399240'
  , @DepartmentId    = 'HR'
  , @PositionId      = 4
  , @SalaryLevelId   = 52

-- phòng tài vụ
EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Lam'
  , @MiddleName      = N'Ngô Ngọc'
  , @LastName        = N'Phan'
  , @DateOfBirth     = '2000-04-01'
  , @Gender          = 0
  , @TaxCode         = 0xC1E30355E19E53F2C047BDB02831CAA80E5DB1463B2A98D607CD0CFCCD367EF4 -- 1952638756-298
  , @CitizenId       = '047853010347'
  , @PhoneNumberList = '0157863874'
  , @DepartmentId    = 'Financial'
  , @PositionId      = 4
  , @SalaryLevelId   = 48

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Vũ'
  , @MiddleName      = NULL
  , @LastName        = N'Huỳnh'
  , @DateOfBirth     = '1999-07-28'
  , @Gender          = 1
  , @TaxCode         = 0xC9BF39682EF83903AD2491A4FFF8C46DC584E52B40E307882B51570C2483309C -- 6528735682-523
  , @CitizenId       = '064223204085'
  , @PhoneNumberList = NULL
  , @DepartmentId    = 'Financial'
  , @PositionId      = 4
  , @SalaryLevelId   = 50

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Nga'
  , @MiddleName      = N'Huỳnh'
  , @LastName        = N'Tố'
  , @DateOfBirth     = '1982-07-18'
  , @Gender          = 0
  , @TaxCode         = 0x4347FECF3922B77AD419647C395014BA315B70FFED576D7546DC15C869B4C781 -- 9523847598
  , @CitizenId       = '066283772230'
  , @PhoneNumberList = '0458237568'
  , @DepartmentId    = 'Financial'
  , @PositionId      = 4
  , @SalaryLevelId   = 57

EXECUTE [dbo].[usp_InsertDummyEmployee]
    @FirstName       = N'Phong'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Phạm'
  , @DateOfBirth     = '1999-08-22'
  , @Gender          = 1
  , @TaxCode         = 0x831DFFC2D6F4C05E8654440A06BEC99DE222DC5909208374F0A0AC73E67091EC -- 2984672947
  , @CitizenId       = '027260138574'
  , @PhoneNumberList = '0593487298'
  , @DepartmentId    = 'Financial'
  , @PositionId      = 4
  , @SalaryLevelId   = 48
GO

IF EXISTS (
    SELECT 1
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'usp_InsertDummyEmployee'
) BEGIN
    DROP PROCEDURE [dbo].[usp_InsertDummyEmployee]
END
GO
