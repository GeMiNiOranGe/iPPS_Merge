SET IDENTITY_INSERT [dbo].[Position] ON;

INSERT INTO [dbo].[Position]
        ([PositionId],  [Title],           [AllowancePercent])
VALUES  (1,             N'Giám đốc',       0.3)
     ,  (2,             N'Phó giám đốc',   0.25)
     ,  (3,             N'Trưởng phòng',   0.2)
     ,  (4,             N'Nhân viên',      0)
;

SET IDENTITY_INSERT [dbo].[Position] OFF;
GO
