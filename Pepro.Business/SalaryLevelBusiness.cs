using Pepro.DataAccess;
using Pepro.DTOs;

namespace Pepro.Business;

public class SalaryLevelBusiness {
    private static SalaryLevelBusiness? instance;

    public static SalaryLevelBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryLevelBusiness() { }

    public List<SalaryLevel> GetSalaryLevelsBySalaryScaleId(int salaryScaleId) {
        return SalaryLevelDataAccess.Instance.GetSalaryLevelsBySalaryScaleId(salaryScaleId);
    }
}
