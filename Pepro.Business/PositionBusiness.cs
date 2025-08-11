using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class PositionBusiness {
    private static PositionBusiness? instance;

    public static PositionBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionBusiness() { }

    public List<EmployeePositionDto> GetPositions() {
        List<EmployeePosition> position = PositionDataAccess.Instance.GetPositions();
        return position.ToDtos();
    }

    public string GetPositionTitleByEmployeeId(string employeeId) {
        EmployeePosition? employeePosition = PositionDataAccess.Instance.GetPositionByEmployeeId(employeeId);
        return employeePosition != null ? employeePosition.Title : "";
    }
}
