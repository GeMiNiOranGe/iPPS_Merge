﻿using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class FormDocument : Form
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        public static FormDocument instance;
        public FormDocument()
        {
            InitializeComponent();
        }

        private void FormDocument_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
            this.dgvDocument.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvDocument.DefaultCellStyle.ForeColor = Color.Black;
            dataDocument();

        }
        public void dataDocument()
        {
            sqlCommand = new SqlCommand("SELECT DOCUMENT.ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE,NAME,NATIVE_FILE_FORMAT FROM DOCUMENT,DOCUMENT_NATIVE_FILE_FORMAT WHERE DOCUMENT.ID=DOCUMENT_NATIVE_FILE_FORMAT.ID", sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgvDocument.DataSource = dataTable;
        }
        private void dgvDocument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = dgvDocument.Rows[e.RowIndex];
            lbIDDoc.Text = Convert.ToString(dataGridViewRow.Cells[0].Value);
            label1.Text = Convert.ToString(dataGridViewRow.Cells[21].Value);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormInsert  formInsert = new FormInsert("1");
            formInsert.ShowDialog();
;        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (lbIDDoc.Text != "label1")
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlCommand = new SqlCommand("DELETE DOCUMENT WHERE ID='" + lbIDDoc.Text + "'", sqlConnection);
                    MessageBox.Show("Xóa tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCommand.ExecuteNonQuery();
                    dataDocument();
                }
            }
            else
            {
                MessageBox.Show("Vui chọn tài liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormInsert formInsert = new FormInsert("0");
            formInsert.ID = dgvDocument.CurrentRow.Cells[0].Value.ToString();
            formInsert.JOB_ID = dgvDocument.CurrentRow.Cells[1].Value.ToString();
            formInsert.PACKAGE = dgvDocument.CurrentRow.Cells[2].Value.ToString();
            formInsert.WORK_ITEM = dgvDocument.CurrentRow.Cells[3].Value.ToString();
            formInsert.TYPE = dgvDocument.CurrentRow.Cells[4].Value.ToString();
            formInsert.PARTNER_CODE = dgvDocument.CurrentRow.Cells[5].Value.ToString();
            formInsert.REVISION_NUMBER = dgvDocument.CurrentRow.Cells[6].Value.ToString();
            formInsert.LASTEST_REVISION = dgvDocument.CurrentRow.Cells[7].Value.ToString();
            formInsert.DATE = dgvDocument.CurrentRow.Cells[8].Value.ToString();
            formInsert.ISSUE_PURPOSE = dgvDocument.CurrentRow.Cells[9].Value.ToString();
            formInsert.PREPARED_BY = dgvDocument.CurrentRow.Cells[10].Value.ToString();
            formInsert.CHECKED_BY = dgvDocument.CurrentRow.Cells[11].Value.ToString();
            formInsert.APPROVED_BY = dgvDocument.CurrentRow.Cells[12].Value.ToString();
            formInsert.ACTION = dgvDocument.CurrentRow.Cells[13].Value.ToString();
            formInsert.SUPPORT = dgvDocument.CurrentRow.Cells[14].Value.ToString();
            formInsert.REFERRENCE = dgvDocument.CurrentRow.Cells[15].Value.ToString();
            formInsert.TO_COMPANY = dgvDocument.CurrentRow.Cells[16].Value.ToString();
            formInsert.ISSUSED_ON = dgvDocument.CurrentRow.Cells[17].Value.ToString();
            formInsert.ISSUSED_VIA = dgvDocument.CurrentRow.Cells[18].Value.ToString();
            formInsert.TITLE = dgvDocument.CurrentRow.Cells[19].Value.ToString();
            formInsert.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (radioIDDoc.Checked == true)
            {
                sqlCommand = new SqlCommand("SELECT ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE FROM DOCUMENT WHERE ID LIKE '%" + txtSearch.Text + "%'", sqlConnection);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvDocument.DataSource = dataTable;
                txtSearch.Clear();
            }
            else if(radioISSUSED_ON.Checked == true)
            {
                sqlCommand = new SqlCommand("SELECT ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE FROM DOCUMENT WHERE ISSUSED_ON LIKE '%" + txtSearch.Text + "%'", sqlConnection);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvDocument.DataSource = dataTable;
                txtSearch.Clear();
            }
            else if(radioLASTEST_REVISION.Checked == true)
            {
                txtSearch.Text = "Latest";
                sqlCommand = new SqlCommand("SELECT ID,JOB_ID,PACKAGE,WORK_ITEM,TYPE,PARTNER_CODE,REVISION_NUMBER,LASTEST_REVISION,DATE,ISSUE_PURPOSE,PREPARED_BY,CHECKED_BY,APPROVED_BY,ACTION,SUPPORT,REFERRENCE,TO_COMPANY,ISSUSED_ON,ISSUSED_VIA,TITLE FROM DOCUMENT WHERE LASTEST_REVISION LIKE '%" + txtSearch.Text + "%'", sqlConnection);
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvDocument.DataSource = dataTable;
                txtSearch.Clear();
            }
            sqlConnection.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dataDocument();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string id = lbIDDoc.Text;
            OpenFile(id);
        }
        public void OpenFile(string id)
        {
            sqlConnection.Open();
            using (sqlCommand = new SqlCommand("SELECT NAME,NATIVE_FILE_FORMAT,LINK FROM DOCUMENT_NATIVE_FILE_FORMAT WHERE ID=@id", sqlConnection))
            {
                sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    var name = sqlDataReader["NAME"].ToString();
                    var type = sqlDataReader["NATIVE_FILE_FORMAT"].ToString();
                    var link = (byte[])sqlDataReader["LINK"];
                    var newFile = name.Replace(type, DateTime.Now.ToString("ddMMyyyyhhmmss")) + type;
                    File.WriteAllBytes(newFile, link);
                    System.Diagnostics.Process.Start(newFile);
                }
            }
            sqlConnection.Close();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT ('"+label1.Text+ "') | *'"+label1.Text+"'", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string strFile = saveFileDialog.FileName;
                        Download(strFile);
                    }
                }
            }
        }
        public void Download(string strFile)
        {
            sqlConnection.Open();
            bool bFlag = false;
            using (sqlCommand = new SqlCommand("select LINK from  DOCUMENT_NATIVE_FILE_FORMAT where ID='" + lbIDDoc.Text + "'", sqlConnection))
            {
                using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.Default))
                {
                    if (sqlDataReader.Read())
                    {
                        bFlag = true;
                        byte[] link = (byte[])sqlDataReader.GetValue(0);
                        using (FileStream fileStream = new FileStream(strFile, FileMode.Create, FileAccess.ReadWrite))
                        {
                            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                            {
                                binaryWriter.Write(link);
                                binaryWriter.Close();
                            }
                        }
                    }
                    if (bFlag == false)
                    {
                        MessageBox.Show("Không có Data", "Thông báo", MessageBoxButtons.OK);
                    }
                    sqlDataReader.Close();
                }
            }
            sqlConnection.Close();
        }
    }
}

