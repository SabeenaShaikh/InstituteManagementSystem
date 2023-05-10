using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;   //
using System.Configuration;    //


namespace ISMS_Project
{
    public partial class frmExpences : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmExpences()
        {
            InitializeComponent();
        }

        private void frmExpences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_users_master' table. You can move, or remove it, as needed.
            this.tbl_users_masterTableAdapter.Fill(this.dB_StudentDataSet.tbl_users_master);
            grbxAddExp.Visible = false;
            ExpShowGrid();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = false;

        }
        private void ExpShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT exp_id AS ExpenseID,exp_date AS OnDate,exp_descri AS Description,exp_by AS ExpenseBy,exp_amt As Amount FROM tbl_expenses_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvExpInfo.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            label2.Text = "Add Expense:";
            cmbxExpBy.Text = "--Select--";
            grbxAddExp.Visible = true;
            dgrvExpInfo.Visible = false;

            int index = dt.Rows.Count - 1;
            int expID = Convert.ToInt32(dt.Rows[index][0]) + 1;
            txtExpID.ReadOnly = true;
            txtExpID.Text = expID.ToString();
            txtExpDescr.Focus();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtExpID.Text != "" && dtpExpdt.Text != "" && txtExpDescr.Text != "" && cmbxExpBy.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_expenses_master VALUES(@exid,@exdt,@exdesc,@exby,@examt)";
                    cmd = new SqlCommand(q2, con);

                    int eamt = Convert.ToInt32(txtAmt.Text); 

                    cmd.Parameters.Add(new SqlParameter("exid", txtExpID.Text));
                    cmd.Parameters.Add(new SqlParameter("exdt", dtpExpdt.Value));
                    cmd.Parameters.Add(new SqlParameter("exdesc", dtpExpdt.Text));
                    cmd.Parameters.Add(new SqlParameter("exby", cmbxExpBy.Text));
                    cmd.Parameters.Add(new SqlParameter("examt",eamt));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Expence Added!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAddExp.Visible = false; 

                        dgrvExpInfo.Visible = true;
                        ExpShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("An Error! Expence Not Added.", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearnSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    //ClearnSet();
                }
            }
            else
            {
                MessageBox.Show("Click on Add & Fill Details!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();

        }

        private void ClearnSet()
        {
            txtExpID.Text = ""; 
            dtpExpdt.Value = DateTime.Today;
            txtExpDescr.Text = "";
            cmbxExpBy.Text = "--Select--";
            txtAmt.Text = "";
            txtExpDescr.Focus();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAddExp.Visible = false; 
            dgrvExpInfo.Visible = true;
            ExpShowGrid(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = true;
            txtSearchByName.Focus();

            ExpShowGrid(); 
            grbxAddExp.Visible = false;
            dgrvExpInfo.Visible = true;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "") 
            {
                try
                {
                    con.Open();
                    string q4 = "SELECT exp_id AS ExpenseID,exp_date AS OnDate,exp_descri AS Description,exp_by AS ExpenseBy,exp_amt As Amount FROM tbl_expenses_master WHERE exp_by LIKE '" + txtSearchByName.Text + "%'"; 
                    cmd = new SqlCommand(q4, con);

                    dr = cmd.ExecuteReader(); 
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvExpInfo.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                //MessageBox.Show("Blank Not Allowed.");
                ExpShowGrid();
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete:";
            if (txtExpID.Text != "") 
            {
                try
                {
                    string q4 = "DELETE FROM tbl_expenses_master WHERE exp_id=@exid";
                    cmd = new SqlCommand(q4, con);
                    con.Open();

                    int eid = Convert.ToInt32(txtExpID.Text);
                    cmd.Parameters.Add(new SqlParameter("exid", eid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grbxAddExp.Visible = false; 
                        MessageBox.Show("Expence Deleted.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Expence Deletion Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    ExpShowGrid(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                label12.Visible = txtSearchByName.Visible = btnExportData.Visible = false;
                MessageBox.Show("Please Select Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();
            dgrvExpInfo.Visible = true; 
        }

        private void dgrvExpInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Delete Expence:";
            txtExpID.Text = dgrvExpInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpExpdt.Text = dgrvExpInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtExpDescr.Text = dgrvExpInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbxExpBy.Text = dgrvExpInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAmt.Text = dgrvExpInfo.Rows[e.RowIndex].Cells[4].Value.ToString();


            dgrvExpInfo.Hide();  //dgrvCourses.Visible = false;   
            grbxAddExp.Visible = true;
            txtExpID.ReadOnly = true; 

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = false; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frmMN = new frmMain();
            frmMN.Show();
            this.Hide();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //Creating Excel Application

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //Creating new workbook within excel application

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                //Creating new worksheet in workbook

                app.Visible = false;
                //see the excelsheet behind the program

                // Get the reference of first sheet. By default its name is Sheet1.  
                // Store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Expenses_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrvExpInfo.Columns.Count + 1; i++)     // storing header part in Excel   
                {
                    worksheet.Cells[1, i] = dgrvExpInfo.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgrvExpInfo.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrvExpInfo.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrvExpInfo.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Expense_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
                MessageBox.Show("Data Exported Successfully!! \nPath=E:\\", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem With Exporting Data!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message.ToString());
            }
        }




    }
}
