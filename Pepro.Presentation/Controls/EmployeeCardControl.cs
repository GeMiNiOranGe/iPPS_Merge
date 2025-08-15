using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeCardControl : PeproUserControl {
    private EmployeeDto _item = null!;

    public EmployeeCardControl() {
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
