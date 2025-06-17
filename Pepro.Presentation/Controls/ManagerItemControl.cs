using System.ComponentModel;

namespace Pepro.Presentation.Controls {
    public partial class ManagerItemControl : UserControl {
        public ManagerItemControl() {
            InitializeComponent();
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Id {
            get => managerIdLabel.Text;
            set => managerIdLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Name {
            get => managerNameLabel.Text;
            set => managerNameLabel.Text = value;
        }
    }
}
