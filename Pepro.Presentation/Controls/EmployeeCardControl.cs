using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeCardControl : PeproUserControl {
    private Employee _item = null!;

    public EmployeeCardControl() {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Employee Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            employeeIdLabel.Text = _item.EmployeeId;
            employeeNameLabel.Text = _item.FirstName + ", " + _item.MiddleName + " " + _item.LastName;
        }
    }
}
