using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;
using System.Globalization;

namespace Pepro.Business;

public class SalaryBusiness
{
    private static SalaryBusiness? _instance;

    public static SalaryBusiness Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private SalaryBusiness() { }

    private const decimal baseSalary = 2_340_000m;

    public List<Salary> GetPayroll()
    {
        List<EmployeeDto> employees = EmployeeBusiness.Instance.GetEmployees();

        List<int> salaryLevelIds =
        [
            .. employees.Select(employee => employee.SalaryLevelId).Distinct()
        ];

        Dictionary<int, SalaryLevel> salaryLevels = SalaryLevelDataAccess
            .Instance.GetSalaryLevelsBySalaryLevelIds(salaryLevelIds)
            .ToDictionary(
                salaryLevel => salaryLevel.SalaryLevelId,
                salaryLevel => salaryLevel
            );

        List<int> salaryScaleIds =
        [
            .. salaryLevels
                .Values.Select(salaryLevel => salaryLevel.SalaryScaleId)
                .Distinct()
        ];

        Dictionary<int, SalaryScale> salaryScales = SalaryScaleDataAccess
            .Instance.GetSalaryScalesBySalaryScaleIds(salaryScaleIds)
            .ToDictionary(
                salaryScale => salaryScale.SalaryScaleId,
                salaryScale => salaryScale
            );

        List<int> positionIds =
        [
            .. employees.Select(employee => employee.PositionId).Distinct()
        ];

        Dictionary<int, Position> positions = PositionDataAccess
            .Instance.GetPositionsByPositionIds(positionIds)
            .ToDictionary(
                position => position.PositionId,
                position => position
            );

        Salary EmployeeSelector(EmployeeDto employee)
        {
            salaryLevels.TryGetValue(
                employee.SalaryLevelId,
                out SalaryLevel? salaryLevel
            );

            SalaryScale? salaryScale =
                salaryLevel != null
                && salaryScales.TryGetValue(
                    salaryLevel.SalaryScaleId,
                    out SalaryScale? value
                )
                    ? value
                    : null;

            positions.TryGetValue(
                employee.PositionId,
                out Position? position
            );

            decimal basicSalary = salaryLevel != null
                ? salaryLevel.Coefficient * baseSalary
                : 0;

            decimal positionAllowance = position != null
                ? (position.AllowancePercent * basicSalary)
                : 0;

            decimal grossSalary = basicSalary + positionAllowance;

            IFormatProvider format = CultureInfo.CreateSpecificCulture("vi-VN");
            return new Salary()
            {
                EmployeeFullName = employee.FullName,
                SalaryScaleName = salaryScale?.Name ?? "",
                SalaryScaleGroup = salaryScale?.Group ?? "",
                SalaryLevel = salaryLevel?.Level ?? "",
                SalaryLevelCoefficient = salaryLevel != null
                    ? salaryLevel.Coefficient.ToString("0.00")
                    : "",
                BasicSalary = basicSalary.ToString("C", format),
                PositionAllowancePercent = position != null
                    ? position.AllowancePercent.ToString("00.00%")
                    : "",
                PositionAllowance = positionAllowance.ToString("C", format),
                GrossSalary = grossSalary.ToString("C", format),
            };
        }
        return [.. employees.Select(EmployeeSelector)];
    }
}
