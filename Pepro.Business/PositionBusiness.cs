using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class PositionBusiness {
    private static PositionBusiness? instance;

    public static PositionBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private PositionBusiness() { }

    public List<PositionDto> GetPositions() {
        List<Position> position = PositionDataAccess.Instance.GetPositions();
        return position.ToDtos();
    }

    public string GetPositionTitleByEmployeeId(int employeeId) {
        Position? employeePosition = PositionDataAccess.Instance.GetPositionByEmployeeId(employeeId);
        return employeePosition != null ? employeePosition.Title : "";
    }
}
