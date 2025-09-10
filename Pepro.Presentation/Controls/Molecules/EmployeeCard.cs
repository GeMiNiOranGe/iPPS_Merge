using Pepro.DTOs;
using Pepro.Presentation.Base;
using System.ComponentModel;

namespace Pepro.Presentation.Controls.Molecules;

public partial class EmployeeCard : PeproCardBase {
    private EmployeeDto _item = null!;

    public EmployeeCard() {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EmployeeDto Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            employeeIdLabel.Text = _item.EmployeeId.ToString();
            employeeNameLabel.Text = _item.FullName;
        }
    }
}
