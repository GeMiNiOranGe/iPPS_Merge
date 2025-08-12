USE [Pepro]
GO

SET NOCOUNT ON

:r $(workspace)\Database\SampleData\PopulateDepartment.sql
:r $(workspace)\Database\SampleData\PopulateStatus.sql
:r $(workspace)\Database\SampleData\PopulatePosition.sql
:r $(workspace)\Database\SampleData\PopulateSalaryScale.sql

:r $(workspace)\Database\SampleData\PopulateProject.sql
:r $(workspace)\Database\SampleData\PopulateSalaryLevel.sql
:r $(workspace)\Database\SampleData\PopulateEmployee.sql
:r $(workspace)\Database\SampleData\PopulateAccount.sql
:r $(workspace)\Database\SampleData\PopulateAssignment.sql
:r $(workspace)\Database\SampleData\PopulateDocument.sql

:r $(workspace)\Database\SampleData\PopulateAssignmentDetail.sql
:r $(workspace)\Database\SampleData\PopulateDepartmentProject.sql
