USE [Pepro]
GO

CREATE OR ALTER PROCEDURE [dbo].[usp_InsertEmployee]
    @EmployeeId         VARCHAR(10),
    @FirstName          NVARCHAR(10),
    @MiddleName         NVARCHAR(30)    = NULL,
    @LastName           NVARCHAR(10),
    @DateOfBirth        DATE,
    @Gender             BIT, -- 1 is male, 0 is female and null is other
    @TaxCode            VARCHAR(14)     = NULL,
    @CitizenId          VARCHAR(12),
    @PhoneNumberList    VARCHAR(MAX)    = NULL,
    @DepartmentId       VARCHAR(10),
    @JobPositionId      INT,
    @SalaryLevelId      INT
AS BEGIN
    SET NOCOUNT ON

    DECLARE @Separator          VARCHAR(2)
    DECLARE @EncryptedTaxCode   VARBINARY(Max)

    SET @Separator = ','

    OPEN SYMMETRIC KEY [PeproSymKey] DECRYPTION BY PASSWORD = 'W34kP4ssw0rd@'
    SET @EncryptedTaxCode = EncryptByKey(key_guid('PeproSymKey'), @TaxCode)
    CLOSE SYMMETRIC KEY [PeproSymKey]

    INSERT INTO [dbo].[Employee]
            ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [TaxCode],         [CitizenId], [DepartmentId], [JobPositionId], [SalaryLevelId])
    VALUES  (@EmployeeId,  @FirstName,  @MiddleName,  @LastName,  @DateOfBirth,  @Gender,  @EncryptedTaxCode, @CitizenId,  @DepartmentId,  @JobPositionId,  @SalaryLevelId)

    IF (@PhoneNumberList IS NOT NULL) BEGIN
        INSERT INTO [dbo].[EmployeePhoneNumber]
                ([PhoneNumber], [EmployeeId])
        SELECT    value,        @EmployeeId
        FROM STRING_SPLIT(@PhoneNumberList, @Separator)
        WHERE RTRIM(value) <> '';
    END
END
GO

CREATE OR ALTER PROCEDURE [dbo].[usp_CreateDefaultAccount]
    @Username   VARCHAR(50),
    @EmployeeId VARCHAR(10)
AS BEGIN
    SET NOCOUNT ON

    DECLARE @DefaultPassword    VARCHAR(50)
    DECLARE @Salt               VARBINARY(Max)
    DECLARE @HashedPassword     VARBINARY(Max)
    DECLARE @SaltedPassword     VARCHAR(Max)

    SET @DefaultPassword = @EmployeeId
    SET @Salt            = crypt_gen_random(32)
    SET @SaltedPassword  = @DefaultPassword + Cast(@Salt AS VARCHAR(Max))
    SET @HashedPassword  = Cast(HashBytes('SHA2_256', @SaltedPassword) AS VARBINARY(Max))

    INSERT INTO [dbo].[Account]
            ([Username], [Password],      [Salt], [IsActive], [EmployeeId])
    VALUES  (@Username,  @HashedPassword, @Salt,  1,          @EmployeeId)
END
GO

CREATE OR ALTER PROCEDURE usp_XoaChamCong
    @MaNhanVienCanXoa NVARCHAR(50)
AS BEGIN
    SET NOCOUNT ON;

    EXEC sp_MSForeachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
    DELETE FROM BOPHANCHAMCONG WHERE MANV = @MaNhanVienCanXoa;
    EXEC sp_MSForeachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
END;
GO

CREATE OR ALTER PROCEDURE usp_XoaMaDien
    @MaDien NVARCHAR(50)
AS BEGIN
    SET NOCOUNT ON;

    EXEC sp_MSForeachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
    DELETE FROM DIEN WHERE MAD = @MaDien;
    EXEC sp_MSForeachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
END;
GO

CREATE OR ALTER PROCEDURE usp_XoaMaNuoc
    @MaNuoc NVARCHAR(50)
AS BEGIN
    SET NOCOUNT ON;

    EXEC sp_MSForeachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL';
    DELETE FROM NUOC WHERE MAN = @MaNuoc;
    EXEC sp_MSForeachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL';
END;
GO

CREATE OR ALTER PROCEDURE CalculateSalary
    @MaNhanVien NVARCHAR(10)
AS BEGIN
    SELECT
        ((LUONG.LUONGCOBAN * BACLUONG.HESOBL) + 
        (LUONG.LUONGCOBAN * CHUCVU.HESOPHUCAP * 0.1) - 
        (ISNULL(TIENNHA.TONGTIEN, 0) + 
        (BOPHANCHAMCONG.SONGAYNGHIBHXH * LUONG.LUONGCOBAN * 0.1) + 
        (BOPHANCHAMCONG.SONGAYNGHIKHONGLYDO * LUONG.LUONGCOBAN * 0.3))) AS TongLuong
    FROM LUONG
        INNER JOIN NGACHLUONG
                ON LUONG.MANL = NGACHLUONG.MANL
        INNER JOIN BACLUONG
                ON LUONG.MABL = BACLUONG.MABL
        INNER JOIN CHUCVU
                ON LUONG.MACV = CHUCVU.MACV
        INNER JOIN BOPHANCHAMCONG
                ON LUONG.MACC = BOPHANCHAMCONG.MACC
        INNER JOIN TIENNHA
                ON LUONG.MATN = TIENNHA.MANTT
    WHERE LUONG.MANV = @MaNhanVien;
END
GO