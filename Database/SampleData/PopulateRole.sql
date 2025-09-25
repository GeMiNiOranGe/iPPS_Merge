SET IDENTITY_INSERT [dbo].[Role] ON;

INSERT INTO [dbo].[Role]
        ([RoleId],  [Name])
VALUES  (1,         N'Admin')
     ,  (2,         N'Employee')
     ,  (3,         N'DepartmentHead')
     ,  (4,         N'HR')
     ,  (5,         N'Finance')
     ,  (6,         N'IT')
;

SET IDENTITY_INSERT [dbo].[Role] OFF;
GO
