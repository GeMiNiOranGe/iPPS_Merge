using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class PeproMediatedUserControl : PeproUserControlBase {
    protected readonly IMediator _mediator = null!;

    public PeproMediatedUserControl() {
        Initialize();
    }

    public PeproMediatedUserControl(IMediator mediator) {
        Initialize();
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    private void Initialize() {
        InitializeComponent();

        headerReturnButton.ApplyFlatStyleNoBackColor();
    }

    [Browsable(true)]
    [Category("Behavior")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public virtual bool ReturnButtonVisible {
        get => headerReturnButton.Visible;
        set {
            headerReturnButton.Visible = value;
            headerReturnButton.Width = value ? 48 : 0;
        }
    }

    [Browsable(true)]
    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public virtual string HeaderText {
        get => headerLabel.Text;
        set => headerLabel.Text = value;
    }

    protected override void OnLoad(EventArgs e) {
        base.OnLoad(e);

        if (!DesignMode) {
            headerReturnButton.Image = IconProvider.GetIcon(
                "ArrowLeft",
                color: ThemeColors.Text
            );
        }
    }

    protected void Close() {
        Parent?.Controls.Remove(this);
    }

    private void HeaderReturnButton_Click(object sender, EventArgs e) {
        Close();
    }
}
