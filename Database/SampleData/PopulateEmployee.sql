-- giám đốc -------------------------------------
EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId      = 'EMP00001'
  , @FirstName       = N'Toàn'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1975-09-21'
  , @Gender          = 1
  , @TaxCode         = '5891734895-427'
  , @CitizenId       = '012735687326'
  , @PhoneNumberList = '0192381297,0284724665,0423874468,0623748736'
  , @DepartmentId    = 'Director'
  , @JobPositionId   = 1
  , @SalaryLevelId   = 30

-- trưởng phòng ---------------------------------
EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId      = 'EMP00002'
  , @FirstName       = N'Tài'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Phan'
  , @DateOfBirth     = '1990-03-21'
  , @Gender          = 1
  , @TaxCode         = '6378162539'
  , @CitizenId       = '071273681763'
  , @PhoneNumberList = '0264837482,0323487687'
  , @DepartmentId    = 'HR'
  , @JobPositionId   = 3
  , @SalaryLevelId   = 30

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId      = 'EMP00003'
  , @FirstName       = N'Châu'
  , @MiddleName      = N'Thị Ngọc'
  , @LastName        = N'Trần'
  , @DateOfBirth     = '1985-09-01'
  , @Gender          = 0
  , @TaxCode         = '4923874923-853'
  , @CitizenId       = '034784236487'
  , @PhoneNumberList = '0213756238'
  , @DepartmentId    = 'Financial'
  , @JobPositionId   = 3
  , @SalaryLevelId   = 19

-- nhân viên ---------------------------------
-- phòng nhân sự
EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00004'
  , @FirstName       = N'Tuấn'
  , @MiddleName      = N'Anh'
  , @LastName        = N'Trần'
  , @DateOfBirth    = '1995-05-19'
  , @Gender          = 1
  , @TaxCode        = '1923157862-873'
  , @CitizenId       = '060770287103'
  , @PhoneNumberList = NULL
  , @DepartmentId   = 'HR'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 49

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00005'
  , @FirstName       = N'Vũ'
  , @MiddleName      = N'Đình'
  , @LastName        = N'Trần'
  , @DateOfBirth    = '1990-03-15'
  , @Gender          = 1
  , @TaxCode        = '9257390619-759'
  , @CitizenId       = '063530240085'
  , @PhoneNumberList = '0234716538'
  , @DepartmentId   = 'HR'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 48

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00006'
  , @FirstName       = N'Anh'
  , @MiddleName      = N'Mai'
  , @LastName        = N'Trương'
  , @DateOfBirth    = '1980-05-19'
  , @Gender          = 0
  , @TaxCode        = '5792378571'
  , @CitizenId       = '070251041576'
  , @PhoneNumberList = '0952387759'
  , @DepartmentId   = 'HR'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 55

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00007'
  , @FirstName       = N'Trắc'
  , @MiddleName      = NULL
  , @LastName        = N'Vương'
  , @DateOfBirth    = '1987-01-17'
  , @Gender          = 0
  , @TaxCode        = '8502935028'
  , @CitizenId       = '057713588258'
  , @PhoneNumberList = '0480399240'
  , @DepartmentId   = 'HR'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 52

-- phòng tài vụ
EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00008'
  , @FirstName       = N'Lam'
  , @MiddleName      = N'Ngô Ngọc'
  , @LastName        = N'Phan'
  , @DateOfBirth    = '2000-04-01'
  , @Gender          = 0
  , @TaxCode        = '1952638756-298'
  , @CitizenId       = '047853010347'
  , @PhoneNumberList = '0157863874'
  , @DepartmentId   = 'Financial'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 48

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00009'
  , @FirstName       = N'Vũ'
  , @MiddleName      = NULL
  , @LastName        = N'Huỳnh'
  , @DateOfBirth    = '1999-07-28'
  , @Gender          = 1
  , @TaxCode        = '6528735682-523'
  , @CitizenId       = '064223204085'
  , @PhoneNumberList = NULL
  , @DepartmentId   = 'Financial'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 50

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00010'
  , @FirstName       = N'Nga'
  , @MiddleName      = N'Huỳnh'
  , @LastName        = N'Tố'
  , @DateOfBirth    = '1982-07-18'
  , @Gender          = 0
  , @TaxCode        = '9523847598'
  , @CitizenId       = '066283772230'
  , @PhoneNumberList = '0458237568'
  , @DepartmentId   = 'Financial'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 57

EXECUTE [dbo].[usp_InsertEmployee]
    @EmployeeId     = 'EMP00011'
  , @FirstName       = N'Phong'
  , @MiddleName      = N'Tuấn'
  , @LastName        = N'Phạm'
  , @DateOfBirth    = '1999-08-22'
  , @Gender          = 1
  , @TaxCode        = '2984672947'
  , @CitizenId       = '027260138574'
  , @PhoneNumberList = '0593487298'
  , @DepartmentId   = 'Financial'
  , @JobPositionId  = 4
  , @SalaryLevelId  = 48
