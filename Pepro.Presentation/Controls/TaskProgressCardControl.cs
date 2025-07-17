using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class TaskProgressCardControl : PeproUserControl {
    private ProjectTaskProgress _item = null!;
    private Color _defaultBackColor;

    public TaskProgressCardControl() {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color MouseOverBackColor {
        get;
        set;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color MouseDownBackColor {
        get;
        set;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required ProjectTaskProgress Item {
        get => _item;
        set {
            ArgumentNullException.ThrowIfNull(value, nameof(Item));
            _item = value;
            taskIdLabel.Text = _item.TaskId.ToString();
            taskNameLabel.Text = _item.Name;
            taskPercentLabel.Text = _item.ProgressPercent.ToString() + "%";
        }
    }

    private void TaskProgressCardControl_MouseEnter(object sender, EventArgs e) {
        _defaultBackColor = BackColor;
        BackColor = MouseOverBackColor;
    }

    private void TaskProgressCardControl_MouseLeave(object sender, EventArgs e) {
        BackColor = _defaultBackColor;
    }

    private void TaskProgressCardControl_MouseDown(object sender, MouseEventArgs e) {
        BackColor = MouseDownBackColor;
    }

    private void TaskProgressCardControl_Click(object sender, EventArgs e) {
        OnClick(e);
    }
}
