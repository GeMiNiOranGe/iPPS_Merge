using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class PositionBusiness {
    private static PositionBusiness? _instance;

    public static PositionBusiness Instance {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private PositionBusiness() { }

    public IEnumerable<PositionDto> GetPositions() {
        IEnumerable<Position> position = PositionDataAccess.Instance.GetPositions();
        return position.ToDtos();
    }

    public string GetPositionTitleByEmployeeId(int employeeId) {
        Position? employeePosition = PositionDataAccess.Instance.GetPositionByEmployeeId(employeeId);
        return employeePosition != null ? employeePosition.Title : "";
    }
}
