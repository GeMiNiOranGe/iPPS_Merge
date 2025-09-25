SET IDENTITY_INSERT [dbo].[Permission] ON;

INSERT INTO [dbo].[Permission]
        ([PermissionId],    [Key])
VALUES  (1,                 N'Account.Create')
     ,  (2,                 N'Account.Read')
     ,  (3,                 N'Account.Update')
     ,  (4,                 N'Account.Delete')

     ,  (5,                 N'Assignment.Create')
     ,  (6,                 N'Assignment.Read')
     ,  (7,                 N'Assignment.Update')
     ,  (8,                 N'Assignment.Delete')

     ,  (9,                 N'Department.Create')
     ,  (10,                N'Department.Read')
     ,  (11,                N'Department.Update')
     ,  (12,                N'Department.Delete')

     ,  (13,                N'Document.Create')
     ,  (14,                N'Document.Read')
     ,  (15,                N'Document.Update')
     ,  (16,                N'Document.Delete')

     ,  (17,                N'Employee.Create')
     ,  (18,                N'Employee.Read')
     ,  (19,                N'Employee.Update')
     ,  (20,                N'Employee.Delete')

     ,  (21,                N'Project.Create')
     ,  (22,                N'Project.Read')
     ,  (23,                N'Project.Update')
     ,  (24,                N'Project.Delete')

     ,  (25,                N'Role.Create')
     ,  (26,                N'Role.Read')
     ,  (27,                N'Role.Update')
     ,  (28,                N'Role.Delete')

     ,  (29,                N'Salary.Create')
     ,  (30,                N'Salary.Read')
     ,  (31,                N'Salary.Update')
     ,  (32,                N'Salary.Delete')
;

SET IDENTITY_INSERT [dbo].[Permission] OFF;
GO
