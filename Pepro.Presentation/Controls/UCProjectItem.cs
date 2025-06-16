using System.ComponentModel;

namespace Pepro.Presentation.Controls {
    public partial class UCProjectItem : UserControl {
        #region Properties
        bool isHover = false;

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Id {
            get => projectIdLabel.Text;
            set => projectIdLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Name {
            get => projectNameLabel.Text;
            set => projectNameLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DepartmentName {
            get => departmentNameLabel.Text;
            set => departmentNameLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Percent {
            get => percentLabel.Text;
            set => percentLabel.Text = value;
        }
        #endregion

        public UCProjectItem() {
            InitializeComponent();
        }

        private void UCProject_MouseEnter(object sender, EventArgs e) {
            if (isHover == true) return;

            BackColor = Color.FromArgb(22, 22, 22);
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void UCProject_MouseLeave(object sender, EventArgs e) {
            if (isHover == false) return;

            BackColor = Color.FromArgb(29, 29, 29);
            isHover = false;
        }

        private void UCProject_Click(object sender, EventArgs e) {
            var formJobDetail = new FormJobDetail {
                ProjectId = Id,
                ProjectName = Name
            };
            formJobDetail.ShowDialog();
        }
    }
}
