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
CREATE TABLE [dbo].[Department] (
    [DepartmentId]  [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
    [ManagerId]     [varchar](10)   NOT NULL,
);

CREATE TABLE [dbo].[Project] (
    [ProjectId]     [varchar](10)   NOT NULL,
    [Name]          [nvarchar](50)  NOT NULL,
    [Status]        [varchar](10)   NOT NULL,
    [CustomerName]  [nvarchar](50)  NOT NULL,
    [ManagerId]     [varchar](10)   NOT NULL,
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
CREATE TABLE [dbo].[SalaryLevel] (
    [SalaryLevelId] [int]           NOT NULL IDENTITY(1, 1),
    [Level]         [nvarchar](10)  NOT NULL,
    [Coefficient]   [decimal](4, 2) NOT NULL,

    [SalaryScaleId] [int]           NOT NULL,
);

CREATE TABLE [dbo].[Employee] (
    [EmployeeId]    [varchar](10)   NOT NULL,
    [FirstName]     [nvarchar](10)  NOT NULL,
    [MiddleName]    [nvarchar](30)  NOT NULL,
    [LastName]      [nvarchar](10)  NOT NULL,
    [DateOfBirth]   [date]          NOT NULL,
    [Gender]        [bit], -- 1 is male, 0 is female and null is other
    [TaxCode]       [varbinary](MAX),
    [CitizenId]     [varchar](12)   NOT NULL,

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
    [Status]                [varchar](10)   NOT NULL,
    [IsProjectPublic]       [bit]           NOT NULL,
    [IsDepartmentPublic]    [bit]           NOT NULL,
    [ManagerId]             [varchar](10)   NOT NULL,
    [StartDate]             [date]          NOT NULL,
    [EndDate]               [date]          NOT NULL,

    [ProjectId]             [varchar](10)   NOT NULL,
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
    [ProjectStartDate]      [date]          NOT NULL,
    [ProjectEndDate]        [date]          NOT NULL,

    [ProjectId]             [varchar](10)   NOT NULL,
    [DepartmentId]          [varchar](10)   NOT NULL,
);
GO

-- TẠO BẢNG PHÒNG BAN
CREATE TABLE [dbo].[PHONGBAN] (
    MAPB   VARCHAR(10)   PRIMARY KEY,
    TENPB  NVARCHAR(50),
    DIACHI NVARCHAR(100),
)

-- TẠO BẢNG CHỨC VỤ
CREATE TABLE [dbo].[CHUCVU](
    MACV       VARCHAR(10)   PRIMARY KEY,
    TENCV      NVARCHAR(50),
    HESOPHUCAP DECIMAL(10,1),
    MAPB       VARCHAR(10),

    FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
)

-- TẠO BẢNG NGẠCH LƯƠNG
CREATE TABLE [dbo].[NGACHLUONG] (
    MANL  VARCHAR(10)   PRIMARY KEY,
    TENNL NVARCHAR(20),
    MOTA  NVARCHAR(100),
)

-- TẠO BẢNG BẬC LƯƠNG
CREATE TABLE [dbo].[BACLUONG] (
    MABL   VARCHAR(10)   PRIMARY KEY,
    TENBL  NVARCHAR(20),
    HESOBL DECIMAL(10,1),
    MOTA   NVARCHAR(100),
    MANL   VARCHAR(10),

    FOREIGN KEY(MANL) REFERENCES NGACHLUONG(MANL),
)

-- TẠO BẢNG NHÂN VIÊN
CREATE TABLE [dbo].[NHANVIEN] (
    MANV          VARCHAR(10)  PRIMARY KEY,
    HOTENNV       NVARCHAR(50),
    GIOITINH      BIT,
    NGAYSINH      DATE,
    NOISINH       NVARCHAR(50),
    QUEQUAN       NVARCHAR(50),
    TRINHDOVANHOA CHAR(10), -- TRÌNH ĐỘ VĂN HOÁ
    DANTOC        NVARCHAR(20),
    TONGIAO       NVARCHAR(20),
    DOANVIEN      BIT,
    DANGVIEN      BIT,
    CONGDOANVIEN  BIT, -- CÔNG ĐOÀN VIÊN
    MAPB          VARCHAR(10),
    MACV          VARCHAR(10),
    MANL          VARCHAR(10),
    MABL          VARCHAR(10),

    FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
    FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV),
    FOREIGN KEY(MANL) REFERENCES NGACHLUONG(MANL),
    FOREIGN KEY(MABL) REFERENCES BACLUONG(MABL),
)

-- TẠO BẢNG NGƯỜI THÂN
CREATE TABLE [dbo].[NGUOITHAN] (
    MANT       VARCHAR(10)  PRIMARY KEY,
    LOAINT     NVARCHAR(30),
    HOTEN      NVARCHAR(50),
    NGAYSINH   DATE,
    NGHENGHIEP NVARCHAR(50),
    MANV       VARCHAR(10),

    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
)

-- TẠO BẢNG CHUYÊN MÔN
CREATE TABLE [dbo].[CHUYENMON](
    MACM    VARCHAR(10)  PRIMARY KEY,
    TENCM   NVARCHAR(50),
    TRINHDO CHAR(5),
)

-- TẠO BẢNG NHÂN VIÊN - CHUYÊN MÔN
CREATE TABLE [dbo].[NHANVIEN_CHUYENMON] (
    MANV VARCHAR(10) NOT NULL,
    MACM VARCHAR(10) NOT NULL,

    PRIMARY KEY(MANV, MACM),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
    FOREIGN KEY(MACM) REFERENCES CHUYENMON(MACM),
)

-- TẠO BẢNG NGOẠI NGỮ
CREATE TABLE [dbo].[NGOAINGU] (
    MANN    VARCHAR(10)  PRIMARY KEY,
    TENNN   NVARCHAR(50),
    TRINHDO CHAR(5),
)

-- TẠO BẢNG NHÂN VIÊN - NGOẠI NGỮ
CREATE TABLE [dbo].[NHANVIEN_NGOAINGU] (
    MANV VARCHAR(10) NOT NULL,
    MANN VARCHAR(10) NOT NULL,

    PRIMARY KEY(MANV, MANN),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
    FOREIGN KEY(MANN) REFERENCES NGOAINGU(MANN),
)

-- TẠO BẢNG PHÒNG TỔ CHỨC
CREATE TABLE [dbo].[PHONGTOCHUC] (
    SOQUYETDINH          VARCHAR(20)  PRIMARY KEY,
    TENNGUOIKY           NVARCHAR(50), -- TÊN NGƯỜI KÝ
    CHUCVUNGUOIKY        VARCHAR(10), -- CHỨC VỤ NGƯỜI KÝ
    PHONGBANHIENTAI      VARCHAR(10), -- PHÒNG BAN HIỆN TẠI
    PHONGBANTHUYENCHUYEN VARCHAR(10), -- PHÒNG BAN THUYÊN CHUYỂN

    FOREIGN KEY(CHUCVUNGUOIKY) REFERENCES CHUCVU(MACV),
    FOREIGN KEY(PHONGBANHIENTAI) REFERENCES PHONGBAN(MAPB),
    FOREIGN KEY(PHONGBANTHUYENCHUYEN) REFERENCES PHONGBAN(MAPB),
)

CREATE TABLE [dbo].[NHANVIEN_PHONGTOCHUC] (
    MANV        VARCHAR(10),
    SOQUYETDINH VARCHAR(20),

    PRIMARY KEY(MANV, SOQUYETDINH),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
    FOREIGN KEY(SOQUYETDINH) REFERENCES PHONGTOCHUC(SOQUYETDINH),
)

-- TẠO BẢNG PHÒNG BAN - PHÒNG TỔ CHỨC
CREATE TABLE [dbo].[PHONGBAN_PHONGTOCHUC] (
    MAPB        VARCHAR(10),
    SOQUYETDINH VARCHAR(20),

    PRIMARY KEY(MAPB, SOQUYETDINH),
    FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
    FOREIGN KEY(SOQUYETDINH) REFERENCES PHONGTOCHUC(SOQUYETDINH),
)

-- TẠO BẢNG HỘ GIA ĐÌNH
CREATE TABLE [dbo].[HOGIADINH] (
	MAHGD VARCHAR(10) PRIMARY KEY,
	MANV1 VARCHAR(10),
	MANV2 VARCHAR(10),

	FOREIGN KEY(MANV1) REFERENCES NHANVIEN(MANV),
	FOREIGN KEY(MANV2) REFERENCES NHANVIEN(MANV)
)

-- TẠO BẢNG ĐIỆN
CREATE TABLE [dbo].[DIEN] (
    MAD            VARCHAR(10) PRIMARY KEY,
    MAHGD          VARCHAR(10),
    THANG          DATE,
    HESOTHANGTRUOC INT,
    HESOHIENTAI    INT,
    DONVI          char(5),

    FOREIGN KEY(MAHGD) REFERENCES HOGIADINH(MAHGD)
)

-- TẠO BẢNG NƯỚC
CREATE TABLE [dbo].[NUOC] (
    MAN            VARCHAR(10) PRIMARY KEY,
    MAHGD          VARCHAR(10),
    THANG          DATE,
    HESOTHANGTRUOC INT,
    HESOHIENTAI    INT,
    DONVI          char(5),

    FOREIGN KEY(MAHGD) REFERENCES HOGIADINH(MAHGD)
)

-- TẠO BẢNG TIENNHA
CREATE TABLE [dbo].[TIENNHA] (
    MANTT                     VARCHAR(10) PRIMARY KEY,
    MAHGD                     VARCHAR(10),
    THANG                     DATE,
    TIENNHA                   INT,
    MAD                       VARCHAR(10),
    MAN                       VARCHAR(10),
    TIENPHIVESINHANNINHTRATTU INT, -- TIỀN PHÍ VỆ SINH AN NINH TRẬT TỰ
    TONGTIEN                  INT

    FOREIGN KEY(MAHGD) REFERENCES HOGIADINH(MAHGD),
    FOREIGN KEY(MAD) REFERENCES DIEN(MAD),
    FOREIGN KEY(MAN) REFERENCES NUOC(MAN),
)

-- TẠO BẢNG BỘ PHẬN CHẤM CÔNG
CREATE TABLE [dbo].[BOPHANCHAMCONG] (
    MACC                VARCHAR(10) PRIMARY KEY,
    THANG               DATE,
    SONGAYTRONGTHANG    TINYINT, -- SỐ NGÀY TRONG THÁNG PHẢI ĐI LÀM
    SONGAYNGHIBHXH      TINYINT, -- SỐ NGÀY NGHỈ BHXH
    SONGAYNGHIKHONGLYDO TINYINT, -- SỐ NGÀY NGHỈ KHÔNG LY DO
    MANV                VARCHAR(10),

    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
)

-- TẠO BẢNG LƯƠNG
CREATE TABLE [dbo].[LUONG] (
    MAL        VARCHAR(10) PRIMARY KEY,
    THOIDIEM   DATE,
    LUONGCOBAN INT,
    MANL       VARCHAR(10),
    MABL       VARCHAR(10),
    MACV       VARCHAR(10),
    MACC       VARCHAR(10),
    MATN       VARCHAR(10), -- TIỀN NHÀ
    MANV       VARCHAR(10),
    TIENLUONG  INT         DEFAULT 0

    FOREIGN KEY(MANL) REFERENCES NGACHLUONG(MANL),
    FOREIGN KEY(MABL) REFERENCES BACLUONG(MABL),
    FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV),
    FOREIGN KEY(MACC) REFERENCES BOPHANCHAMCONG(MACC),
    FOREIGN KEY(MATN) REFERENCES TIENNHA(MANTT),
    FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
)
GO

-- add unique key --------------------------------------------------------
ALTER TABLE [dbo].[Account]
ADD CONSTRAINT UK_Username      UNIQUE ([Username])
  , CONSTRAINT UK_EmployeeId    UNIQUE ([EmployeeId])
GO

-- add primary key -------------------------------------------------------
ALTER TABLE [dbo].[Department]          ADD CONSTRAINT [PK_Department]          PRIMARY KEY ([DepartmentId])
ALTER TABLE [dbo].[Project]             ADD CONSTRAINT [PK_Project]             PRIMARY KEY ([ProjectId])
ALTER TABLE [dbo].[JobPosition]         ADD CONSTRAINT [PK_JobPosition]         PRIMARY KEY ([JobPositionId])
ALTER TABLE [dbo].[SalaryScale]         ADD CONSTRAINT [PK_SalaryScale]         PRIMARY KEY ([SalaryScaleId]);
ALTER TABLE [dbo].[SalaryLevel]         ADD CONSTRAINT [PK_SalaryLevel]         PRIMARY KEY ([SalaryLevelId]);
ALTER TABLE [dbo].[Employee]            ADD CONSTRAINT [PK_Employee]            PRIMARY KEY ([EmployeeId])
ALTER TABLE [dbo].[EmployeePhoneNumber] ADD CONSTRAINT [PK_EmployeePhoneNumber] PRIMARY KEY ([EmployeePhoneNumberId])
ALTER TABLE [dbo].[Account]             ADD CONSTRAINT [PK_Account]             PRIMARY KEY ([AccountId])
ALTER TABLE [dbo].[Task]                ADD CONSTRAINT [PK_Task]                PRIMARY KEY ([TaskId])
ALTER TABLE [dbo].[Document]            ADD CONSTRAINT [PK_Document]            PRIMARY KEY ([DocumentId])
ALTER TABLE [dbo].[TaskDetail]          ADD CONSTRAINT [PK_TaskDetail]          PRIMARY KEY ([TaskDetailId])
GO

-- add foreign key -------------------------------------------------------
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
    REFERENCES [dbo].[Project]([ProjectId]);
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
