using Pepro.DataAccess;
using Pepro.DTOs;

namespace Pepro.Business;

public class PositionBusiness {
    private static PositionBusiness? instance;

    public static PositionBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionBusiness() { }

    public List<EmployeePosition> GetPositions() {
        return PositionDataAccess.Instance.GetPositions();
    }

    public string GetPositionTitleByEmployeeId(string employeeId) {
        EmployeePosition? employeePosition = PositionDataAccess.Instance.GetPositionByEmployeeId(employeeId);
        return employeePosition != null ? employeePosition.Title : "";
    }
}
