namespace Pepro.Presentation.Controls;

public class PeproForm : Form {
    public PeproForm() : base() {
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }
}
