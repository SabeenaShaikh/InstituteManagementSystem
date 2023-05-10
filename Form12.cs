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
    public partial class frmCampus : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmCampus()
        {
            InitializeComponent();
        }

        private void frmCampus_Load(object sender, EventArgs e)
        {
            grbxAddCamp.Visible = false;
            CampShowGrid();

            label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;
        }
        private void CampShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT camp_id AS CampusID,camp_date AS CampusDate,camp_company AS Company,camp_add AS Address,camp_jobloc As JobLocation,camp_Role As Role,camp_salary As Salary,camp_status As Status FROM tbl_campus_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvCampInfo.DataSource = dt; 
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
            label2.Text = "Add Campus:";
            grbxAddCamp.Visible = true; 
            dgrvCampInfo.Visible = false;

            int index = dt.Rows.Count - 1;
            int cmpsID = Convert.ToInt32(dt.Rows[index][0]) + 1;
            txtCampID.ReadOnly = true;
            txtCampID.Text = cmpsID.ToString();
            dtpCamp.Focus();

            label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;  
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCampID.Text != "" && cmbxCompany.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_campus_master VALUES(@cmid,@cmdt,@cmcomp,@cmadd,@cmjobloc,@cmrol,@cmsal,@cmstat)";
                    cmd = new SqlCommand(q2, con);

                    int cmsid = Convert.ToInt32(txtCampID.Text);

                    cmd.Parameters.Add(new SqlParameter("cmid", cmsid));
                    cmd.Parameters.Add(new SqlParameter("cmdt", dtpCamp.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("cmcomp", cmbxCompany.Text));
                    cmd.Parameters.Add(new SqlParameter("cmadd", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("cmjobloc", cmbxJobLoc.Text));
                    cmd.Parameters.Add(new SqlParameter("cmrol", cmbxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("cmsal", cmbxSal.Text));
                    cmd.Parameters.Add(new SqlParameter("cmstat", cmbxStatus.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Campus Entry Saved!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAddCamp.Visible = false;

                        dgrvCampInfo.Visible = true;
                        CampShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Click on Add & Fill Detais!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
        }
        private void ClearnSet()
        {
            txtCampID.Text = "";
            dtpCamp.Value = DateTime.Today;
            cmbxCompany.Text = "--Select--";
            txtAddress.Text = "";
            cmbxJobLoc.Text = "--Select--"; 
            cmbxRole.Text = "--Select--";
            cmbxSal.Text = "--Select--";
            cmbxStatus.Text = "--Select--";
            dtpCamp.Focus();

            label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;  
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAddCamp.Visible = false; 
            dgrvCampInfo.Visible = true;
            CampShowGrid();
        }

        private void dgrvCampInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Update/Delete:";
            txtCampID.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpCamp.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbxCompany.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbxJobLoc.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbxRole.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbxSal.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbxStatus.Text = dgrvCampInfo.Rows[e.RowIndex].Cells[7].Value.ToString();

            dgrvCampInfo.Hide();  //dgrvCourses.Visible = false; 
            grbxAddCamp.Visible = true;
            txtCampID.ReadOnly = true;

            label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;  

        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update:";
            if (txtCampID.Text != "" && dtpCamp.Text != "" && cmbxCompany.Text != "--Select--")
            {
                try
                {
                    
                    con.Open();

                    string q2 = "UPDATE tbl_campus_master SET camp_id=@cmid,camp_date=@cmdt,camp_company=@cmcomp,camp_add=@cmadd,camp_jobloc=@cmjobloc,camp_Role=@cmrol,camp_salary=@cmsal,camp_status=@cmstat WHERE camp_id=@cmid";
                    cmd = new SqlCommand(q2, con);

                    int cmsid = Convert.ToInt32(txtCampID.Text);

                    cmd.Parameters.Add(new SqlParameter("cmid", cmsid));
                    cmd.Parameters.Add(new SqlParameter("cmdt", dtpCamp.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("cmcomp", cmbxCompany.Text));
                    cmd.Parameters.Add(new SqlParameter("cmadd", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("cmjobloc", cmbxJobLoc.Text));
                    cmd.Parameters.Add(new SqlParameter("cmrol", cmbxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("cmsal", cmbxSal.Text));
                    cmd.Parameters.Add(new SqlParameter("cmstat", cmbxStatus.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxAddCamp.Visible = false; 
                        MessageBox.Show("Campus Entry Updated!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvCampInfo.Visible = true;
                        CampShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("Entry Update Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    CampShowGrid(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    ClearnSet();
                }
            }
            else
            {
                label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;  
                MessageBox.Show("Select A Record To Update?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            CampShowGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = true;  

            txtSearchByCompany.Focus();

            CampShowGrid(); 
            grbxAddCamp.Visible = false;
            dgrvCampInfo.Visible = true;
        }

        private void txtSearchByCompany_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCompany.Text != "") 
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT camp_id AS CampusID,camp_date AS CampusDate,camp_company AS Company,camp_add AS Address,camp_jobloc As JobLocation,camp_Role As Role,camp_salary As Salary,camp_status As Status FROM tbl_campus_master WHERE camp_company LIKE '" + txtSearchByCompany.Text + "%'"; 
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvCampInfo.DataSource = dt; 
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
                CampShowGrid(); 
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete:";
            if (txtCampID.Text != "")
            {
                try
                {
                    string q4 = "DELETE FROM tbl_campus_master WHERE camp_id=@cmsid";
                    cmd = new SqlCommand(q4, con);
                    con.Open();

                    int cmpsid = Convert.ToInt32(txtCampID.Text);
                    cmd.Parameters.Add(new SqlParameter("cmsid", cmpsid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grbxAddCamp.Visible = false; 
                        MessageBox.Show("Record Deleted Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Record Deletion Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    CampShowGrid(); 
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
                label12.Visible = txtSearchByCompany.Visible = btnExportData.Visible = false;  
                MessageBox.Show("Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();
            dgrvCampInfo.Visible = true; 
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

                worksheet.Name = "Campus_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrvCampInfo.Columns.Count + 1; i++)     // storing header part in Excel   
                {
                    worksheet.Cells[1, i] = dgrvCampInfo.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgrvCampInfo.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrvCampInfo.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrvCampInfo.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Campus_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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
