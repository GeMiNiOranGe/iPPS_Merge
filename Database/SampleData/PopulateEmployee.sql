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
  , @JobPositionId   = 'POS00001'
  , @SalaryLevelId   = 30

