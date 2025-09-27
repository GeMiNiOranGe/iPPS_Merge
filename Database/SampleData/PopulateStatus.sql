SET IDENTITY_INSERT [dbo].[Status] ON;

INSERT INTO [dbo].[Status]
        ([StatusId],    [Name])
VALUES  (1,             'Cancel')
     ,  (2,             'On hold')
     ,  (3,             'On going')
     ,  (4,             'Complete')
     ,  (5,             'Prepare')
;

SET IDENTITY_INSERT [dbo].[Status] OFF;
GO