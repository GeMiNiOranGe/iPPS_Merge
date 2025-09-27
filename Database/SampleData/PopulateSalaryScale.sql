SET IDENTITY_INSERT [dbo].[SalaryScale] ON;

INSERT INTO [dbo].[SalaryScale]
        ([SalaryScaleId],   [Group],   [Name])
VALUES  (1,                 'A3.1',    N'Chuyên viên cao cấp nhóm 1')
     ,  (2,                 'A3.2',    N'Chuyên viên cao cấp nhóm 2')
     ,  (3,                 'A2.1',    N'Chuyên viên chính nhóm 1')
     ,  (4,                 'A2.2',    N'Chuyên viên chính nhóm 2')
     ,  (5,                 'A1',      N'Chuyên viên')
     ,  (6,                 'A0',      N'Cán sự')
     ,  (7,                 'B',       N'Nhân viên')
     ,  (8,                 'C1',      N'Khác nhóm 1')
     ,  (9,                 'C2',      N'Khác nhóm 2')
     ,  (10,                'C3',      N'Khác nhóm 3')
;

SET IDENTITY_INSERT [dbo].[SalaryScale] OFF;
GO
