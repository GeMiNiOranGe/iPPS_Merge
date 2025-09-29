using Pepro.Business;
using System.Data;
using System.Text;

namespace Pepro.Presentation
{
    public partial class GrantRoleForm : Form
    {
        private int _roleID;
        public GrantRoleForm(int roleID)
        {
            InitializeComponent();
            loadData();
            loadRoleID();
            loadPermissionID();
            LoadColumnNames();
            _roleID = roleID;
        }


        #region Function
        private void loadData()
        {
            DataTable dataTable = RoleBussiness.Instance.GetRolePermissions();
            try
            {
                if (dataTable == null || dataTable.Columns.Count == 0)
                {
                    MessageBox.Show("No data returned from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dtgvGrant.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadRoleID()
        {
            DataTable role= RoleBussiness.Instance.GetRoles();
            cbRoleID.DataSource = role;
            cbRoleID.DisplayMember = "RoleID";
        }
        private void  loadPermissionID()
        {
            DataTable Permission = RoleBussiness.Instance.GetPermission();
            cbPermission.DataSource = Permission;
            cbPermission.DisplayMember = "PermissionID";
        }
        private void LoadColumnNames()
        {
            cbColumnName.Items.Clear();
            cbColumnName.Items.Add("EmployeeID");
            cbColumnName.Items.Add("Gender");
            cbColumnName.Items.Add("DateOfBirth");
            cbColumnName.Items.Add("PhoneNumber");
            cbColumnName.Items.Add("Salary");
            cbColumnName.Items.Add("Allowance");
            cbColumnName.Items.Add("TaxCode");
            cbColumnName.Items.Add("DepartmentID");
        }
        private string GenerateColumnNameParameter()
        {
            string selectedColumn = cbColumnName.Text;
            if (string.IsNullOrWhiteSpace(selectedColumn) || selectedColumn == "NULL")
            {
                return null;
            }
            return selectedColumn;
        }
        private string getDatafromDtgv()
        {
            StringBuilder columns = new StringBuilder();
            foreach (DataGridViewColumn column in dtgvGrant.Columns)
            {
                columns.Append(column.HeaderText + ",");
            }
            columns.Remove(columns.Length - 1, 1);
            return columns.ToString();
        }
        #endregion

        #region Event
        private void dtgvGrant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvGrant.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvGrant.Rows[e.RowIndex];

                cbRoleID.Text= row.Cells["RoleID"].Value?.ToString() ?? string.Empty;
                cbPermission.Text= row.Cells["PermissionID"].Value?.ToString() ?? string.Empty;
                tbName.Text= row.Cells["Name"].Value?.ToString() ?? string.Empty;

            }
        }

        private void cbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRoleID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormGrantRole_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void cbColumnName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPermiss_Click(object sender, EventArgs e)
        {
            int roleID = _roleID;
            int roleIDAdd = Convert.ToInt32(cbRoleID.Text);
            int permissionID = Convert.ToInt32(cbPermission.Text);
            string name = tbName.Text;
            string columnName = GenerateColumnNameParameter();

            // Only proceed if columnName is not empty
            if (!string.IsNullOrWhiteSpace(columnName))
            {
                RoleBussiness.Instance.GrantRole(roleID, roleIDAdd, permissionID, name, columnName);
                loadData();
            }
            else
            {
                MessageBox.Show("Please select a valid column name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForbid_Click(object sender, EventArgs e)
        {
            int roleID = _roleID;
            int roldidAdd= Convert.ToInt32(cbRoleID.Text);
            int permissionid=Convert.ToInt32(cbPermission.Text);
            string columnName = cbColumnName.Text;
            if (!string.IsNullOrWhiteSpace(columnName))
            {
                string currentColumns = getDatafromDtgv();

                string[] columnArray = currentColumns.Split(',');

                List<string> columnList = new List<string>(columnArray);
                columnList.Remove(columnName);
                string newColumns = string.Join(",", columnList);

                RoleBussiness.Instance.UpdateRolePermission(roleID, roldidAdd,permissionid, newColumns);
                loadData();
            }
            else
            {
                MessageBox.Show("Please select a valid column name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
