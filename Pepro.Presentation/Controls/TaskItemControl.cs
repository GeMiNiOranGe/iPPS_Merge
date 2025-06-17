using Pepro.Business;
using System.ComponentModel;
using System.Data;

namespace Pepro.Presentation.Controls {
    public partial class TaskItemControl : UserControl {
        #region Properties
        bool isHover = false;
        private Panel pnlManager;
        private Panel pnlJobOfEmployee;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Panel PanelManager {
            get => pnlManager;
            set => pnlManager = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Panel PanelJobOfEmployee {
            get => pnlJobOfEmployee;
            set => pnlJobOfEmployee = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Id {
            get => taskIdLabel.Text;
            set => taskIdLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Name {
            get => taskNameLabel.Text;
            set => taskNameLabel.Text = value;
        }

        [Category("Custom Props")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Percent {
            get => taskPercentLabel.Text;
            set => taskPercentLabel.Text = value;
        }
        #endregion

        public TaskItemControl() {
            InitializeComponent();
        }

        public void RetrieveInfomation(string strJobId, ref Panel pnlManager, ref Panel pnlJobOfEmployee) {
            if (pnlManager.Controls.Count > 0) pnlManager.Controls.Clear();
            if (pnlJobOfEmployee.Controls.Count > 0) pnlJobOfEmployee.Controls.Clear();

            string managerTempId = null;

            var dtManager = CJobBLL.Instance.GetManager(strJobId);

            if (dtManager != null && dtManager.Rows.Count > 0) {
                foreach (DataRow row in dtManager.Rows) {
                    var managerItem = new ManagerItemControl {
                        Id = row["EMPLOYEE_ID"].ToString(),
                        Name = row["EMPLOYEE_FULLNAME"].ToString()
                    };

                    managerTempId = managerItem.Id;

                    managerItem.Size = new Size() {
                        Width = pnlManager.Size.Width,
                        Height = managerItem.Size.Height
                    };
                    pnlManager.Controls.Add(managerItem);
                }
            }

            var dtJobsByProject = CJobBLL.Instance.GetAllByEmployee(managerTempId);
            double total;
            double total1;
            if (dtJobsByProject != null && dtJobsByProject.Rows.Count > 0) {
                foreach (DataRow row in dtJobsByProject.Rows) {
                    var jobOfEmployeeItem = new TaskOfEmployeeControl {
                        ProjectId = row["PROJECT_ID"].ToString(),
                        JobId = row["JOB_ID"].ToString(),
                        JobName = row["JOB_NAME"].ToString()
                    };
                    total = Convert.ToDouble(CProgressBLL.getTotalDocumentbyJobID(jobOfEmployeeItem.JobId));
                    total1 = Convert.ToDouble(CProgressBLL.getNumberofDocumentbyJobID(jobOfEmployeeItem.JobId));
                    jobOfEmployeeItem.JobPercent = Math.Round((total / total1) * 100, 2).ToString() + "%";
                    pnlJobOfEmployee.Controls.Add(jobOfEmployeeItem);
                }
            }
        }

        private void UCJobItem_Click(object sender, EventArgs e) {
            RetrieveInfomation(Id, ref pnlManager, ref pnlJobOfEmployee);
        }

        private void UCJobItem_MouseEnter(object sender, EventArgs e) {
            if (isHover == true) return;

            BackColor = Color.FromArgb(22, 22, 22);
            this.Cursor = Cursors.Hand;
            isHover = true;
        }

        private void UCJobItem_MouseLeave(object sender, EventArgs e) {
            if (isHover == false) return;

            BackColor = Color.FromArgb(29, 29, 29);
            isHover = false;
        }
    }
}
