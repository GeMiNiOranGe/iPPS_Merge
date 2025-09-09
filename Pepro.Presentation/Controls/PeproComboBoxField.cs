using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Windows.Forms.ComboBox;

namespace Pepro.Presentation.Controls;

public partial class PeproComboBoxField : PeproInputFieldBase, INotifyPropertyChanged {
    private static readonly object s_selectedIndexChangedEvent = new();
    public event PropertyChangedEventHandler? PropertyChanged;

    public PeproComboBoxField() {
        InitializeComponent();
    }

    protected override Size DefaultSize => new(240, 48);

    [DefaultValue(typeof(Size), "240, 48")]
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public new bool Enabled {
        get => inputFieldComboBox.Enabled;
        set {
            inputFieldComboBox.Enabled = value;
            TabStop = value;
        }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object? DataSource {
        get => inputFieldComboBox.DataSource;
        set => inputFieldComboBox.DataSource = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string DisplayMember {
        get => inputFieldComboBox.DisplayMember;
        set => inputFieldComboBox.DisplayMember = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ValueMember {
        get => inputFieldComboBox.ValueMember;
        set => inputFieldComboBox.ValueMember = value;
    }

    [Bindable(true)]
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [DisallowNull]
    public object? SelectedValue {
        get => inputFieldComboBox.SelectedValue;
        set => inputFieldComboBox.SelectedValue = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex {
        get => inputFieldComboBox.SelectedIndex;
        set => inputFieldComboBox.SelectedIndex = value;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object? SelectedItem {
        get => inputFieldComboBox.SelectedItem;
        set => inputFieldComboBox.SelectedItem = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public new ControlBindingsCollection DataBindings => inputFieldComboBox.DataBindings;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new BindingContext? BindingContext {
        get => inputFieldComboBox.BindingContext;
        set => inputFieldComboBox.BindingContext = value;
    }

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

    protected void OnPropertyChanged(string propertyName) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void InputFieldComboBox_SelectedIndexChanged(object sender, EventArgs e) {
        if (Events[s_selectedIndexChangedEvent] is EventHandler handler) {
            handler(this, e);
        }

        OnPropertyChanged(nameof(SelectedValue));
    }
}
