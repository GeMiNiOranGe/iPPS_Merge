using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class SalaryLevelBusiness {
    private static SalaryLevelBusiness? instance;

    public static SalaryLevelBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryLevelBusiness() { }

    public List<SalaryLevelDto> GetSalaryLevelsBySalaryScaleId(int salaryScaleId) {
        List<SalaryLevel> salaryLevels = SalaryLevelDataAccess.Instance.GetSalaryLevelsBySalaryScaleId(salaryScaleId);
        return salaryLevels.ToDtos();
    }
}
