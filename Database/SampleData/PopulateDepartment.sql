SET IDENTITY_INSERT [dbo].[Department] ON;

INSERT INTO [dbo].[Department]
        ([DepartmentId],    [Name])
VALUES  (1,                 N'Phòng giám đốc')
     ,  (2,                 N'Phòng nhân sự')
     ,  (3,                 N'Phòng tài chính')
     ,  (4,                 N'Phòng công nghệ thông tin')
;

SET IDENTITY_INSERT [dbo].[Department] OFF;
GO
