﻿using Pepro.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepro.Presentation
{
    public partial class EmployeeForm : Form
    {
        private DepartmentBusiness departmentBusiness;
        private int _roleID;
        public EmployeeForm(int roleID)
        {
            InitializeComponent();
            _roleID = roleID;
            departmentBusiness = new DepartmentBusiness();
            LoadEmployeeData();
            loadDepartment();
            checkPermission(_roleID);
        }
       
        #region Event
        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked)
            {
                cbFemale.Checked = false;
            }
        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked)
            {
                cbMale.Checked = false;
            }
        }
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];

            txtID.Text = row.Cells["EmployeeID"].Value?.ToString() ?? string.Empty;
            txtName.Text = row.Cells["FullName"].Value?.ToString() ?? string.Empty;
            txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty;
            txtSalary.Text = row.Cells["Salary"].Value?.ToString() ?? string.Empty;
            txtAllowance.Text = row.Cells["Allowance"].Value?.ToString() ?? string.Empty;
            txtTax.Text = row.Cells["TaxCode"].Value?.ToString() ?? string.Empty;
            cbbDepartment.Text = row.Cells["DepartmentID"].Value?.ToString() ?? string.Empty;
            dtpkDOB.Text = row.Cells["DateOfBirth"].Value?.ToString() ?? string.Empty;

            bool isFemale = Convert.ToBoolean(row.Cells["Gender"].Value??string.Empty);
            cbFemale.Checked = isFemale;
            cbMale.Checked = !isFemale;
        }
    }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvEmployee.Rows.Count > 0)
                {
                    
                    string employeeID = txtID.Text.Trim();
                    string fullName = txtName.Text.Trim();
                    string phoneNumber = txtPhone.Text.Trim();
                    string salary = txtSalary.Text.Trim();
                    string allowance = txtAllowance.Text.Trim();
                    string taxCode = txtTax.Text.Trim();
                    string departmentID = cbbDepartment.Text?.ToString() ?? string.Empty;
                    string dateOfBirth = dtpkDOB.Value.ToString("yyyy-MM-dd");
                    string gender = cbMale.Checked ? "0" : "1";
                    string valueList = $"{fullName},{gender},{dateOfBirth},{phoneNumber},{salary},{allowance},{taxCode},{departmentID}";
                    bool result = EmployeeBusiness.Instance.UpdateEmployee(_roleID, valueList, employeeID);
                    if (result)
                    {
                        MessageBox.Show("Updated!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Updated Unsuccessfully!", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadEmployeeData();
                    }
                }
            }
            catch (SqlException ex) // Catch specific SQL exceptions
            {
                if (ex.Number == 50000) // Check if custom error number
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvEmployee.SelectedRows.Count > 0)
            {
                string employeeID = dtgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = EmployeeBusiness.Instance.DeleteEmployee(_roleID,employeeID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Employee deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadEmployeeData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete employee or insufficient permissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeId = txtID.Text; 
                string fullname = txtName.Text;
                DateTime? dateOfBirth = dtpkDOB.Value; 
                string phoneNumber = txtPhone.Text; 
                string allowance = txtAllowance.Text; 
                string salary=txtSalary.Text;
                string taxCode = txtTax.Text; 
                string departmentId = cbbDepartment.Text;
                bool? gender = null;
                if (cbMale.Checked)
                {
                    gender = false; // Male corresponds to true
                }
                else if (cbFemale.Checked)
                {
                    gender = true; // Female corresponds to false
                }
                EmployeeBusiness.Instance.InsertEmployee(employeeId, fullname, gender, dateOfBirth, phoneNumber, salary, allowance, taxCode, departmentId);

                MessageBox.Show("Employee inserted successfully!");
                LoadEmployeeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            txtAllowance.Clear();
           txtSalary.Clear();
            txtTax.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            cbbDepartment.Text = null;
        }

        #endregion

        #region Function
        private void DisplayEmployees(DataTable dt)
        {
              dtgvEmployee.DataSource = dt;
        }   
        private void LoadEmployeeData()
        {
            try
            {
                DataTable dt = EmployeeBusiness.Instance.GetEmployeesByRoleID(_roleID);
                DisplayEmployees(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDepartment()
        {
            try
            {
                DataTable dt = departmentBusiness.GetDepartments();

                foreach (DataRow row in dt.Rows)
                {
                    cbbDepartment.Items.Add(row["DepartmentID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkPermission(int roleID)
        {
           
            if (roleID==5 || roleID==7) 
            {
                dtgvEmployee.Columns["Salary"].Visible = false;
                dtgvEmployee.Columns["Allowance"].Visible = false;
              
            } else
            {
                dtgvEmployee.Columns["Salary"].Visible = true;
                dtgvEmployee.Columns["Allowance"].Visible = true;
              

            }
            
            
           
        }





        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }

        
    }
}
