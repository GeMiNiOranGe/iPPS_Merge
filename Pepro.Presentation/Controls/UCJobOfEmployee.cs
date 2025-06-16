using System.ComponentModel;

namespace Pepro.Presentation.Controls {
    public partial class UCJobOfEmployee : UserControl {
        public UCJobOfEmployee() {
            InitializeComponent();
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProjectId {
            get => projectIdLabel.Text;
            set => projectIdLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string JobName {
            get => taskNameLabel.Text;
            set => taskNameLabel.Text = value;
        }
        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string JobId {
            get => taskIdLabel.Text;
            set => taskIdLabel.Text = value;
        }
        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string JobPercent {
            get => taskPercentLabel.Text;
            set => taskPercentLabel.Text = value;
        }
    }
}
