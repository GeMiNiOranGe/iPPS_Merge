using Pepro.Business;
using Pepro.Presentation.Controls;
using System.ComponentModel;
using System.Data;

namespace Pepro.Presentation {
    public partial class FormJobDetail : Form {
        public string? strEmployeeId;

        #region Properties
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProjectId {
            get => lblIdProject.Text;
            set => lblIdProject.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ProjectName {
            get => lblNameProject.Text;
            set => lblNameProject.Text = value;
        }
        #endregion

        public FormJobDetail() {
            InitializeComponent();
        }

        private void FormWorkOfProject_Load(object sender, EventArgs e) {
            ShowJobsFromProject(ProjectId);
        }

        private void ShowJobsFromProject(string strProjectId) {
            flPnlListJob.Controls.Clear();
            var dataTable = CJobBLL.Instance.GetAllFromProject(strProjectId);
            double total;
            double total1;
            if (dataTable != null && dataTable.Rows.Count > 0) {
                foreach (DataRow row in dataTable.Rows) {
                    var jobItem = new UCJobItem {
                        Id = row["JOB_ID"].ToString(),
                        Name = row["JOB_NAME"].ToString(),
                        PanelManager = pnlManager,
                        PanelJobOfEmployee = flPnlJobOfEmployee
                    };
                    total = Convert.ToDouble(CProgressBLL.getTotalDocumentbyJobID(jobItem.Id));
                    total1 = Convert.ToDouble(CProgressBLL.getNumberofDocumentbyJobID(jobItem.Id));
                    jobItem.Percent = Math.Round((total / total1) * 100, 2).ToString() + "%";

                    jobItem.Size = new Size() {
                        Width = flPnlListJob.Size.Width,
                        Height = jobItem.Size.Height
                    };
                    flPnlListJob.Controls.Add(jobItem);
                }
            }
        }
    }
}
