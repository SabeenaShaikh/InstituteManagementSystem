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
    public partial class frmCertificates : Form
    {
        SqlConnection con;  //
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
         
        public frmCertificates()
        {
            InitializeComponent();
        }

        private void frmCertificates_Load(object sender, EventArgs e)
        {
            grbxAddCerti.Visible = false; 
            CertiShowGrid();

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = false;

        }
        private void CertiShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT std_id AS StudentID,std_certino AS CertificateNO,std_name AS Name,std_course AS Course,std_duration As Duration,std_fromdt As FromDate,std_todt As ToDate,std_institute As Institute,std_cissuedt As DateOfIssue,std_status As Status FROM tbl_Certificates_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvCertInfo1.DataSource = dt; 
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



        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmMain frmMN = new frmMain();
           // frmMN.Show();
            this.Hide();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //Note  

            label2.Text = "Add Certificate::";
            grbxAddCerti.Visible = true;
            dgrvCertInfo1.Visible = false;

            int index = dt.Rows.Count - 1;
            int certno = Convert.ToInt32(dt.Rows[index][1]) + 1;  //frm dgrv index
            txtCertNo.ReadOnly = true;
            txtCertNo.Text = certno.ToString();
            txtStudID.Focus();

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudID.Text != "" && txtCertNo.Text != "") //we can add other controls also but ne need
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_Certificates_master VALUES(@sid,@scrtno,@snm,@scrs,@scrsdur,@scfrmdt,@sctdt,@scinst,@scissdt,@scstat)";
                    cmd = new SqlCommand(q2, con);

                    int stid = Convert.ToInt32(txtStudID.Text);  //FK Col for tbl_Cert TO Stud Stud_id of tbl_student
                    int sertno = Convert.ToInt32(txtCertNo.Text);

                    cmd.Parameters.Add(new SqlParameter("sid", stid));
                    cmd.Parameters.Add(new SqlParameter("scrtno", sertno));

                    cmd.Parameters.Add(new SqlParameter("snm", txtStudName.Text)); 
                    cmd.Parameters.Add(new SqlParameter("scrs", cmbxCourse.Text)); 
                    cmd.Parameters.Add(new SqlParameter("scrsdur", cmbxDuration.Text));
                    cmd.Parameters.Add(new SqlParameter("scfrmdt", dtpFrom.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("sctdt", dtpTo.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("scinst", cmbxInstitute.Text));
                    cmd.Parameters.Add(new SqlParameter("scissdt", dtpIssueDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("scstat", cmbxStatus.Text));
                    

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Certificate Saved Successfully.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAddCerti.Visible = false; 

                        dgrvCertInfo1.Visible = true;
                        CertiShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  ClearnSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Student ID Doesn't Exists,Please Check!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                   // MessageBox.Show("Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   // MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    con.Close();
                    ClearnSet();
                }
            }
            else
            {
                MessageBox.Show("Add New & Fill Details First!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             ClearnSet();
        }
         
        private void ClearnSet() 
        {
            txtStudID.Text = ""; 
            //txtCertNo.Text="";
            txtStudName.Text="";
            cmbxCourse.Text = "--Select--";
            cmbxDuration.Text = "--Select--";
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            cmbxInstitute.Text = "--Select--";
            dtpIssueDate.Value = DateTime.Today;
            cmbxStatus.Text = "--Select--";
            txtStudID.Focus();

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAddCerti.Visible = false;  
            dgrvCertInfo1.Visible = true;
            CertiShowGrid();
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update:";
            if (txtStudID.Text != "" && txtCertNo.Text != "") //we can add other controls also but ne need
            {
                try
                {
                    con.Open();

                    string q2 = "UPDATE tbl_Certificates_master SET std_id=@sid,std_certino=@scrtno,std_name=@snm,std_course=@scrs,std_duration=@scrsdur,std_fromdt=@scfrmdt,std_todt=@sctdt,std_institute=@scinst,std_cissuedt=@scissdt,std_status=@scstat WHERE std_certino=@scrtno";
                    cmd = new SqlCommand(q2, con);

                    int stid = Convert.ToInt32(txtStudID.Text);  //FK Col for tbl_Cert TO Stud Stud_id of tbl_student
                    int sertno = Convert.ToInt32(txtCertNo.Text);

                    cmd.Parameters.Add(new SqlParameter("sid", stid));
                    cmd.Parameters.Add(new SqlParameter("scrtno", sertno));

                    cmd.Parameters.Add(new SqlParameter("snm", txtStudName.Text));
                    cmd.Parameters.Add(new SqlParameter("scrs", cmbxCourse.Text));
                    cmd.Parameters.Add(new SqlParameter("scrsdur", cmbxDuration.Text));
                    cmd.Parameters.Add(new SqlParameter("scfrmdt", dtpFrom.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("sctdt", dtpTo.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("scinst", cmbxInstitute.Text));
                    cmd.Parameters.Add(new SqlParameter("scissdt", dtpIssueDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("scstat", cmbxStatus.Text));
                    

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxAddCerti.Visible = false;
                        MessageBox.Show("Certificate Updation Success!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvCertInfo1.Visible = true;
                        CertiShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("Certificate Updation Failed!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    CertiShowGrid();
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
                label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = false;
                MessageBox.Show("Select Record To Be Update??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            CertiShowGrid();
        }

        private void dgrvCertInfo1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           label2.Text = "Update:";
            txtStudID.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            txtCertNo.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            txtStudName.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            cmbxCourse.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            cmbxDuration.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[4].Value.ToString(); 
            dtpFrom.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpTo.Text = dgrvCertInfo1.Rows[e.RowIndex].Cells[6].Value.ToString(); 
            cmbxInstitute.Text=dgrvCertInfo1.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtpIssueDate.Text = dgrvCertInfo1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbxStatus.Text = dgrvCertInfo1.Rows[e.RowIndex].Cells[9].Value.ToString();

            dgrvCertInfo1.Hide();  //dgrvCertInfo1.Visible = false; 
            grbxAddCerti.Visible = true; 
            txtStudID.ReadOnly = true;
            txtCertNo.ReadOnly = true;

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //label11.Visible = txtSearchByID.Visible = Not Used
            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = btnCertiPrint.Visible = true;
            txtSearchByName.Focus();

            CertiShowGrid();
            grbxAddCerti.Visible = false;
            dgrvCertInfo1.Visible = true;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "")
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT std_id AS StudentID,std_certino AS CertificateNO,std_name AS Name,std_course AS Course,std_duration As Duration,std_fromdt As FromDate,std_todt As ToDate,std_institute As Institute,std_cissuedt As DateOfIssue,std_status As Status FROM tbl_Certificates_master WHERE std_name LIKE '" + txtSearchByName.Text + "%'";
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvCertInfo1.DataSource = dt;
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
                CertiShowGrid(); 
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Certificate Deletion NOT ALLOWED.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnDelete.Enabled = false;
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

                worksheet.Name = "Certificate_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrvCertInfo1.Columns.Count + 1; i++)     // storing header part in Excel   
                {
                    worksheet.Cells[1, i] = dgrvCertInfo1.Columns[i - 1].HeaderText; 
                }

                for (int i = 0; i < dgrvCertInfo1.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrvCertInfo1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrvCertInfo1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Certificate_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void btnCertiPrint_Click(object sender, EventArgs e)
        {
            frmPrintCertificate frmPCRT = new frmPrintCertificate();
            frmPCRT.Show();

            this.Hide();
        }


    }
}
