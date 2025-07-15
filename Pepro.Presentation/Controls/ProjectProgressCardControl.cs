using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class ProjectProgressCardControl : PeproUserControl {
    private ProjectProgress _item = null!;
    private Color _defaultBackColor;

    public ProjectProgressCardControl() {
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
    public required ProjectProgress Item {
        get => _item;
        set {
            ArgumentNullException.ThrowIfNull(value, nameof(Item));
            _item = value;
            projectIdLabel.Text = _item.ProjectId;
            projectNameLabel.Text = _item.Name;
            projectPercentLabel.Text = _item.ProgressPercent.ToString() + "%";
        }
    }

    private void ProjectProgressCardControl_MouseEnter(object sender, EventArgs e) {
        _defaultBackColor = BackColor;
        BackColor = MouseOverBackColor;
    }

    private void ProjectProgressCardControl_MouseLeave(object sender, EventArgs e) {
        BackColor = _defaultBackColor;
    }

    private void ProjectProgressCardControl_MouseDown(object sender, MouseEventArgs e) {
        BackColor = MouseDownBackColor;
    }

    private void ProjectProgressCardControl_Click(object sender, EventArgs e) {
        OnClick(e);
    }
}
