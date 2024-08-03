CREATE DATABASE QUANLYLUONG
GO

USE QUANLYLUONG
GO

-- TẠO BẢNG TÀI KHOẢN
CREATE TABLE TAIKHOAN (
	USERNAME VARCHAR(10) PRIMARY KEY,
	PASSWORD NVARCHAR(30) NOT NULL,
)
INSERT TAIKHOAN VALUES ('Admin', 'admin123')

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