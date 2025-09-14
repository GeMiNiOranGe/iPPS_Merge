using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class SalaryScaleBusiness {
    private static SalaryScaleBusiness? _instance;

    public static SalaryScaleBusiness Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private SalaryScaleBusiness() { }

    public List<SalaryScaleDto> GetSalaryScales() {
        List<SalaryScale> salaryScales = SalaryScaleDataAccess.Instance.GetSalaryScales();
        return salaryScales.ToDtos();
    }

    public SalaryScaleDto? GetSalaryScaleBySalaryLevelId(int salaryLevelId) {
        SalaryScale? salaryScale = SalaryScaleDataAccess.Instance.GetSalaryScaleBySalaryLevelId(salaryLevelId);
        return salaryScale?.ToDto();
    }
}
