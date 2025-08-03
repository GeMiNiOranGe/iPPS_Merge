using Pepro.DataAccess;
using Pepro.DTOs;

namespace Pepro.Business;

public class SalaryScaleBusiness {
    private static SalaryScaleBusiness? instance;

    public static SalaryScaleBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private SalaryScaleBusiness() { }

    public List<SalaryScale> GetSalaryScales() {
        return SalaryScaleDataAccess.Instance.GetSalaryScales();
    }
}
