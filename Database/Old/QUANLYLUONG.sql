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

INSERT INTO [dbo].[TAIKHOAN]
        ([Username],    [Password])
VALUES  ('Admin',       'admin123')
GO

INSERT INTO [dbo].[PHONGBAN]
        ([MAPB], [TENPB],           [DIACHI])
VALUES  ('PB001', N'Phòng ban ABC', N'TP Hồ Chí Minh')
     ,  ('PB002', N'Phòng ban EFG', N'Bình Dương')
     ,  ('PB003', N'Phòng ban HKJ', N'Đồng Nai')
GO

INSERT INTO [dbo].[CHUCVU]
        ([MACV],    [TENCV],                        [HESOPHUCAP],   [MAPB])
VALUES  ('CV001',   N'Quản lý',                     3,              'PB001')
     ,  ('CV002',   N'Kế toán',                     2,              'PB002')
     ,  ('CV003',   N'Kiểm toán',                   2,              'PB003')
     ,  ('CV004',   N'Trưởng phòng',                2.2,            'PB002')
     ,  ('CV005',   N'Nhân viên Content Marketing', 3,              'PB001')
     ,  ('CV006',   N'Nhân viên bán hàng',          3,              'PB001')
     ,  ('CV007',   N'Nhân viên kỹ thuật',          3,              'PB003')
GO

INSERT INTO [dbo].[NGACHLUONG]
        ([MANL],    [TENNL],            [MOTA])
VALUES  ('NL001',   N'Ngạch lương I',   null)
     ,  ('NL002',   N'Ngạch lương II',  null)
     ,  ('NL003',   N'Ngạch lương III', null)
     ,  ('NL004',   N'Ngạch lương IV',  null)
     ,  ('NL005',   N'Ngạch lương V',   null)
GO

INSERT INTO [dbo].[BACLUONG]
        ([MABL],    [TENBL],            [HESOBL],   [MOTA], [MANL])
VALUES  ('BL001',   N'Bậc lương I',     6.20,       null,   'NL001')
     ,  ('BL002',   N'Bậc lương II',    6.56,       null,   'NL002')
     ,  ('BL003',   N'Bậc lương III',   6.92,       null,   'NL003')
     ,  ('BL004',   N'Bậc lương IV',    7.28,       null,   'NL004')
     ,  ('BL005',   N'Bậc lương V',     7.56,       null,   'NL005')
GO

INSERT INTO [dbo].[NHANVIEN]
        ([MANV],    [HOTENNV],              [GIOITINH], [NGAYSINH], [NOISINH],      [QUEQUAN],      [TRINHDOVANHOA],[DANTOC],[TONGIAO],     [DOANVIEN], [DANGVIEN], [CONGDOANVIEN], [MAPB],     [MACV],     [MANL],     [MABL])
VALUES  ('NV00001', N'Lê Thị Bình',         0,          '19920301', N'Bình Dương',  N'Bình Dương',  '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV001',    'NL001',    'BL001')
     ,  ('NV00002', N'Trần Khánh Vân',      0,          '19970705', N'Bình Thuận',  N'Bình Thuận',  '12/12',        N'Kinh', N'Đạo Phật',   1,          0,          1,              'PB002',    'CV002',    'NL002',    'BL002')
     ,  ('NV00003', N'Lê Tấn Đạt',          1,          '20001030', N'Bình Định',   N'Bình Định',   '12/12',        N'Kinh', N'Đạo Phật',   1,          0,          0,              'PB003',    'CV003',    'NL003',    'BL003')
     ,  ('NV00004', N'Nguyễn Duy Khang',    1,          '19990328', N'Biên Hòa',    N'Biên Hòa',    '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          0,              'PB002',    'CV004',    'NL004',    'BL004')
     ,  ('NV00005', N'Nguyễn Phương Nhi',   0,          '20010710', N'Phú Yên',     N'Phú Yên',     '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV005',    'NL005',    'BL005')
     ,  ('NV00006', N'Đỗ Thị Hà',           0,          '20010309', N'Phú Yên',     N'Phú Yên',     '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV005',    'NL001',    'BL001')
     ,  ('NV00007', N'Đoàn Thiên Ân',       0,          '20020710', N'Long An',     N'Long An',     '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV005',    'NL002',    'BL002')
     ,  ('NV00008', N'Huỳnh Thanh Thủy',    0,          '20031106', N'Đà Nẵng',     N'Đà Nẵng',     '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV006',    'NL002',    'BL002')
     ,  ('NV00009', N'Nguyễn Hải Nam',      1,          '20000709', N'Phú Yên',     N'Phú Yên',     '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV006',    'NL005',    'BL005')
     ,  ('NV00010', N'Lê Duy Khánh',        1,          '20010911', N'Hà Nội',      N'Hà Nội',      '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB001',    'CV006',    'NL005',    'BL005')
     ,  ('NV00011', N'Trịnh Thùy Linh',     0,          '20030719', N'Hải Phòng',   N'Hải Phòng',   '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB003',    'CV007',    'NL001',    'BL001')
     ,  ('NV00012', N'Lê Nguyễn Ngọc Hằng', 0,          '20030720', N'Hồ Chí Minh', N'Hồ Chí Minh', '12/12',        N'Kinh', N'Đạo Phật',   0,          1,          1,              'PB003',    'CV007',    'NL002',    'BL002')
     ,  ('NV00013', N'Lê Minh Anh',         1,          '20030823', N'Bình Định',   N'Bình Định',   '12/12',        N'Kinh', N'Đạo Phật',   1,          1,          1,              'PB003',    'CV007',    'NL001',    'BL001')
     ,  ('NV00014', N'Lê Kim Hung',         1,          '20030823', N'Bình Định',   N'Bình Định',   '12/12',        N'Kinh', N'Đạo Phật',   1,          0,          1,              'PB003',    'CV007',    'NL001',    'BL001')
GO

INSERT INTO [dbo].[NGUOITHAN]
        ([MANT],    [LOAINT],   [HOTEN],                [NGAYSINH], [NGHENGHIEP],   [MANV])
VALUES  ('NT001',   N'Cha',     N'Lê Văn Tám',          '19630427', N'Bán tạp hoá', 'NV00001')
     ,  ('NT002',   N'Mẹ',      N'Nguyễn Thị Chín',     '19690428', N'Kinh doanh',  'NV00001') 
     ,  ('NT003',   N'Cha',     N'Trần Hữu Nghĩa',      '19670927', N'Kinh doanh',  'NV00002')
     ,  ('NT004',   N'Mẹ',      N'Nguyễn Thị Bé',       '19731027', N'Bán tạp hoá', 'NV00002') 
     ,  ('NT005',   N'Cha',     N'Lê Văn Khánh',        '19800430', N'Ngư nghiệp',  'NV00003') 
     ,  ('NT006',   N'Mẹ',      N'Trần Tuyết Nhung',    '19810506', N'Nông nghiệp', 'NV00004') 
     ,  ('NT007',   N'Mẹ',      N'Nguyễn Thị Chóng',    '19770405', N'Công nhân',   'NV00004') 
     ,  ('NT008',   N'Cha',     N'Lê Văn Đông',         '19650927', N'Kinh doanh',  'NV00005') 
     ,  ('NT009',   N'Cha',     N'Trần Văn Trọng',      '19650927', N'Kinh doanh',  'NV00006')
     ,  ('NT010',   N'Cha',     N'Lê Văn Hòa',          '19651022', N'Kinh doanh',  'NV00007')
     ,  ('NT011',   N'Cha',     N'Nguyễn Anh Dũng',     '19690927', N'Kinh doanh',  'NV00008')
     ,  ('NT012',   N'Cha',     N'Nguyễn Văn Nam',      '19700927', N'Kinh doanh',  'NV00009')
     ,  ('NT013',   N'Cha',     N'Lâm Văn Thủy',        '19710927', N'Kinh doanh',  'NV00010')
     ,  ('NT014',   N'Cha',     N'Trần Duy Phước',      '19650929', N'Kinh doanh',  'NV00011')
     ,  ('NT015',   N'Cha',     N'Lê Văn Mười',         '19681027', N'Kinh doanh',  'NV00012')
     ,  ('NT016',   N'Mẹ',      N'Trần Thị Nhung',      '19720127', N'Nông nghiệp', 'NV00013')
GO

INSERT INTO [dbo].[CHUYENMON]
        ([MACM],    [TENCM],                            [TRINHDO])
VALUES  ('CM001',   N'Quản lí phòng ban',               'A')
     ,  ('CM002',   N'Tính toán doanh thu',             'A')
     ,  ('CM003',   N'Kiểm tra - đối soát doanh thu',   'A')
     ,  ('CM004',   N'Quản lí nhân sự',                 'A')
     ,  ('CM005',   N'Quảng cáo sản phẩm',              'A')
     ,  ('CM006',   N'Nhập bán hàng',                   'A')
     ,  ('CM007',   N'Hỗ trợ - sữa chữa',               'A')
GO

INSERT INTO [dbo].[NHANVIEN_CHUYENMON]
        ([MANV],    [MACM])
VALUES  ('NV00001', 'CM001')
     ,  ('NV00002', 'CM002')
     ,  ('NV00003', 'CM003')
     ,  ('NV00004', 'CM004')
     ,  ('NV00005', 'CM005')
     ,  ('NV00006', 'CM005')
     ,  ('NV00007', 'CM005')
     ,  ('NV00008', 'CM006')
     ,  ('NV00009', 'CM006')
     ,  ('NV00010', 'CM006')
     ,  ('NV00011', 'CM007')
     ,  ('NV00012', 'CM007')
     ,  ('NV00013', 'CM007')
GO

INSERT INTO [dbo].[NGOAINGU]
        ([MANN],    [TENNN],        [TRINHDO])
VALUES  ('NN001',   N'Toeic 450+',  450)
     ,  ('NN002',   N'Toeic 800+',  800)
     ,  ('NN003',   N'Toeic 650+',  650)
     ,  ('NN004',   N'Ielts 4.0',   4.0)
     ,  ('NN005',   N'Ielts 6.0',   6.0)
GO

INSERT INTO [dbo].[NHANVIEN_NGOAINGU]
        ([MANV],    [MANN])
VALUES  ('NV00001', 'NN001')
     ,  ('NV00002', 'NN002')
     ,  ('NV00003', 'NN003')
     ,  ('NV00004', 'NN004')
     ,  ('NV00005', 'NN005')
     ,  ('NV00006', 'NN001')
     ,  ('NV00007', 'NN003')
     ,  ('NV00008', 'NN002')
     ,  ('NV00009', 'NN005')
     ,  ('NV00010', 'NN004')
     ,  ('NV00011', 'NN004')
     ,  ('NV00012', 'NN001')
     ,  ('NV00013', 'NN005')
GO

INSERT INTO [dbo].[PHONGTOCHUC]
        ([SOQUYETDINH],         [TENNGUOIKY],   [CHUCVUNGUOIKY],    [PHONGBANHIENTAI],  [PHONGBANTHUYENCHUYEN])
VALUES  ('1/13112023/QD-PB',    N'Lê Thị Bình', 'CV001',            'PB001',            'PB002')
     ,  ('1/14112023/QD-PB',    N'Lê Thị Bình', 'CV001',            'PB002',            'PB003')
     ,  ('1/15112023/QD-PB',    N'Lê Thị Bình', 'CV001',            'PB003',            'PB001')
     ,  ('1/16112023/QD-PB',    N'Lê Thị Bình', 'CV001',            'PB002',            'PB001')
     ,  ('1/17112023/QD-PB',    N'Lê Thị Bình', 'CV001',            'PB001',            'PB003')
GO

INSERT INTO [dbo].[NHANVIEN_PHONGTOCHUC]
        ([MANV],    [SOQUYETDINH])
VALUES  ('NV00001', '1/13112023/QD-PB')
     ,  ('NV00002', '1/14112023/QD-PB')
     ,  ('NV00003', '1/15112023/QD-PB')
     ,  ('NV00004', '1/16112023/QD-PB')
     ,  ('NV00005', '1/17112023/QD-PB')
     ,  ('NV00006', '1/13112023/QD-PB')
     ,  ('NV00007', '1/14112023/QD-PB')
     ,  ('NV00008', '1/15112023/QD-PB')
     ,  ('NV00009', '1/16112023/QD-PB')
     ,  ('NV00010', '1/17112023/QD-PB')
     ,  ('NV00011', '1/13112023/QD-PB')
     ,  ('NV00012', '1/14112023/QD-PB')
     ,  ('NV00013', '1/15112023/QD-PB')
GO

INSERT INTO [dbo].[PHONGBAN_PHONGTOCHUC]
        ([MAPB],    [SOQUYETDINH])
VALUES  ('PB001',   '1/13112023/QD-PB')
     ,  ('PB002',   '1/14112023/QD-PB')
     ,  ('PB003',   '1/15112023/QD-PB')
     ,  ('PB002',   '1/16112023/QD-PB')
     ,  ('PB001',   '1/17112023/QD-PB')
GO

INSERT INTO [dbo].[HOGIADINH]
        ([MAHGD],   [MANV1],    [MANV2])
VALUES  ('P001',    'NV00001', 'NV00014')
     ,  ('P002',    'NV00002',  NULL)
     ,  ('P003',    'NV00003',  NULL)
     ,  ('P004',    'NV00004',  NULL)
     ,  ('P005',    'NV00005',  NULL)
     ,  ('P006',    'NV00006',  NULL)
     ,  ('P007',    'NV00007',  NULL)
     ,  ('P008',    'NV00008', 'NV00011')
     ,  ('P009',    'NV00009', 'NV00012')
     ,  ('P010',    'NV00010', 'NV00013')
GO

INSERT INTO [dbo].[DIEN]
        ([MAD],     [MAHGD],    [THANG],    [HESOTHANGTRUOC],   [HESOHIENTAI],  [DONVI])
VALUES  ('D0001',   'P001',     '20231101', 0,                  102,            'kW')
     ,  ('D0002',   'P002',     '20231101', 0,                  103,            'kW')
     ,  ('D0003',   'P003',     '20231101', 0,                  104,            'kW')
     ,  ('D0004',   'P004',     '20231101', 0,                  105,            'kW')
     ,  ('D0005',   'P005',     '20231101', 0,                  106,            'kW')
     ,  ('D0006',   'P006',     '20231101', 0,                  102,            'kW')
     ,  ('D0007',   'P007',     '20231101', 0,                  103,            'kW')
     ,  ('D0008',   'P008',     '20231101', 0,                  104,            'kW')
     ,  ('D0009',   'P009',     '20231101', 0,                  105,            'kW')
     ,  ('D0010',   'P010',     '20231101', 0,                  106,            'kW')
GO

INSERT INTO [dbo].[NUOC]
        ([MAN],     [MAHGD],    [THANG],    [HESOTHANGTRUOC],   [HESOHIENTAI],  [DONVI])
VALUES  ('N0001',   'P001',     '20231101', 0,                  12,             'm3')
     ,  ('N0002',   'P002',     '20231101', 0,                  13,             'm3')
     ,  ('N0003',   'P003',     '20231101', 0,                  14,             'm3')
     ,  ('N0004',   'P004',     '20231101', 0,                  15,             'm3')
     ,  ('N0005',   'P005',     '20231101', 0,                  16,             'm3')
     ,  ('N0006',   'P006',     '20231101', 0,                  12,             'm3')
     ,  ('N0007',   'P007',     '20231101', 0,                  13,             'm3')
     ,  ('N0008',   'P008',     '20231101', 0,                  14,             'm3')
     ,  ('N0009',   'P009',     '20231101', 0,                  15,             'm3')
     ,  ('N0010',   'P010',     '20231101', 0,                  16,             'm3')
GO

INSERT INTO [dbo].[TIENNHA]
        ([MANTT],   [MAHGD],    [THANG],    [TIENNHA],  [MAD],      [MAN],      [TIENPHIVESINHANNINHTRATTU],    [TONGTIEN])
VALUES  ('TN0001',  'P001',     '20231101', 2500000,    'D0001',    'N0001',    50000,                          0)
     ,  ('TN0002',  'P002',     '20231101', 2800000,    'D0002',    'N0002',    65000,                          0)
     ,  ('TN0003',  'P003',     '20231101', 3000000,    'D0003',    'N0003',    50000,                          0)
     ,  ('TN0004',  'P004',     '20231101', 2600000,    'D0004',    'N0004',    55000,                          0)
     ,  ('TN0005',  'P005',     '20231101', 2900000,    'D0005',    'N0005',    60000,                          0)
     ,  ('TN0006',  'P006',     '20231101', 2500000,    'D0006',    'N0006',    50000,                          0)
     ,  ('TN0007',  'P007',     '20231101', 2800000,    'D0007',    'N0007',    65000,                          0)
     ,  ('TN0008',  'P008',     '20231101', 3000000,    'D0008',    'N0008',    50000,                          0)
     ,  ('TN0009',  'P009',     '20231101', 2600000,    'D0009',    'N0009',    55000,                          0)
     ,  ('TN0010',  'P010',     '20231101', 2900000,    'D0010',    'N0010',    60000,                          0)
GO

INSERT INTO [dbo].[BOPHANCHAMCONG]
        ([MACC],    [THANG],    [SONGAYTRONGTHANG], [SONGAYNGHIBHXH],   [SONGAYNGHIKHONGLYDO],  [MANV])
VALUES  ('CC0001',  '20231031', 27,                 1,                  3,                      'NV00001')
     ,  ('CC0002',  '20231031', 27,                 1,                  0,                      'NV00002')
     ,  ('CC0003',  '20231031', 27,                 0,                  1,                      'NV00003')
     ,  ('CC0004',  '20231031', 27,                 2,                  0,                      'NV00004')
     ,  ('CC0005',  '20231031', 27,                 1,                  2,                      'NV00005')
     ,  ('CC0006',  '20231031', 27,                 1,                  3,                      'NV00006')
     ,  ('CC0007',  '20231031', 27,                 1,                  0,                      'NV00007')
     ,  ('CC0008',  '20231031', 27,                 0,                  1,                      'NV00008')
     ,  ('CC0009',  '20231031', 27,                 2,                  0,                      'NV00009')
     ,  ('CC0010',  '20231031', 27,                 1,                  2,                      'NV00010')
     ,  ('CC0011',  '20231031', 27,                 1,                  3,                      'NV00011')
     ,  ('CC0012',  '20231031', 27,                 1,                  0,                      'NV00012')
     ,  ('CC0013',  '20231031', 27,                 0,                  1,                      'NV00013')
GO

INSERT INTO [dbo].[LUONG]
        ([MAL],     [THOIDIEM],     [LUONGCOBAN],   [MANL],     [MABL],     [MACV],     [MACC],     [MATN],     [MANV])
VALUES  ('L0001',   '20231101',     6000000,        'NL001',    'BL001',    'CV001',    'CC0001',   'TN0001',   'NV00001')
     ,  ('L0002',   '20231101',     5800000,        'NL002',    'BL002',    'CV002',    'CC0002',   'TN0002',   'NV00002')
     ,  ('L0003',   '20231101',     7000000,        'NL003',    'BL003',    'CV003',    'CC0003',   'TN0003',   'NV00003')
     ,  ('L0004',   '20231101',     6400000,        'NL004',    'BL004',    'CV004',    'CC0004',   'TN0004',   'NV00004')
     ,  ('L0005',   '20231101',     6500000,        'NL005',    'BL005',    'CV005',    'CC0005',   'TN0005',   'NV00005')
     ,  ('L0006',   '20231101',     6000000,        'NL001',    'BL001',    'CV005',    'CC0006',   'TN0006',   'NV00006')
     ,  ('L0007',   '20231101',     5800000,        'NL002',    'BL002',    'CV005',    'CC0007',   'TN0007',   'NV00007')
     ,  ('L0008',   '20231101',     7000000,        'NL002',    'BL002',    'CV006',    'CC0008',   'TN0008',   'NV00008')
     ,  ('L0009',   '20231101',     6400000,        'NL005',    'BL005',    'CV006',    'CC0009',   'TN0009',   'NV00009')
     ,  ('L0010',   '20231101',     6500000,        'NL005',    'BL005',    'CV006',    'CC0010',   'TN0010',   'NV00010')
GO
