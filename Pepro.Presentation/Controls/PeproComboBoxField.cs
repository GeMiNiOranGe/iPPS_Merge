using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Windows.Forms.ComboBox;

namespace Pepro.Presentation.Controls;

public partial class PeproComboBoxField : PeproInputFieldBase {
    private static readonly object s_selectedIndexChangedEvent = new();

    public PeproComboBoxField() {
        InitializeComponent();
    }

    protected override Size DefaultSize => new(256, 56);

    [DefaultValue(typeof(Size), "256, 56")]
    public new Size Size {
        get => base.Size;
        set => base.Size = value;
    }

    /// <summary>
    ///     Collection of the items contained in this ComboBox.
    /// </summary>
    [Category("Data")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public ObjectCollection Items => inputFieldComboBox.Items;

    [AllowNull]
    [Browsable(true)]
    [Category("Appearance")]
    [DefaultValue("")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public override string Text {
        get => inputFieldComboBox.Text;
        set => inputFieldComboBox.Text = value;
    }

    [Browsable(true)]
    [Category("Behavior")]
    public event EventHandler? SelectedIndexChanged {
        add => Events.AddHandler(s_selectedIndexChangedEvent, value);
        remove => Events.RemoveHandler(s_selectedIndexChangedEvent, value);
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ComboBox InnerComboBox => inputFieldComboBox;

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified) {
        base.SetBoundsCore(x, y, width, DefaultSize.Height, specified);
    }

    protected override void OnBackColorChanged(EventArgs e) {
        base.OnBackColorChanged(e);
        if (inputFieldComboBox != null) {
            inputFieldComboBox.BackColor = BackColor;
        }
    }

    protected override void OnForeColorChanged(EventArgs e) {
        base.OnForeColorChanged(e);
        if (inputFieldComboBox != null) {
            inputFieldComboBox.ForeColor = ForeColor;
        }
    }

    private void InputFieldComboBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (Events[s_selectedIndexChangedEvent] is EventHandler handler) {
            handler(this, e);
        }
    }
}
