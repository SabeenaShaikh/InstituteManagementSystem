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
    public partial class frmAttend : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmAttend()
        {
            InitializeComponent();
        }

        private void frmAttend_Load(object sender, EventArgs e)
        {
            grbxAttend.Visible = false; 
            AttendShowGrid();

            label26.Visible = txtSearchByName.Visible =btnExport.Visible=false;
        }

        private void AttendShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT att_id AS ID,att_name AS Name,att_attstatus AS Status,att_date AS Date,att_memtype As MemberType,att_attby As AttendenceBy FROM tbl_attendence_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvAttendInfo1.DataSource = dt; 
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            label6.Text = "Add Attendence:";
            grbxAttend.Visible = true;
            dgrvAttendInfo1.Visible = false;

            int index = dt.Rows.Count - 1;
            int attID = Convert.ToInt32(dt.Rows[index][0]) + 1;
            txtAttID.ReadOnly = true; 
            txtAttID.Text = attID.ToString();
            txtAttName.Focus();

            label26.Visible = txtSearchByName.Visible = btnExport.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAttID.Text != "" && txtAttName.Text != "")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_attendence_master VALUES(@aid,@anm,@dattstats,@attdt,@amemtyp,@attby)";
                    cmd = new SqlCommand(q2, con);

                    int attidd = Convert.ToInt32(txtAttID.Text);


                    cmd.Parameters.Add(new SqlParameter("aid", attidd));
                    cmd.Parameters.Add(new SqlParameter("anm", txtAttName.Text)); 
                    cmd.Parameters.Add(new SqlParameter("dattstats", cmbxAttendence.Text));
                    cmd.Parameters.Add(new SqlParameter("attdt", dtpAttDate.Value.ToShortDateString())); //date only
                    cmd.Parameters.Add(new SqlParameter("amemtyp", cmbxMemberType.Text));
                    cmd.Parameters.Add(new SqlParameter("attby", cmbxAttBy.Text));
                    

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Attendence Marked Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAttend.Visible = false;  

                        dgrvAttendInfo1.Visible = true;
                        AttendShowGrid();
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
                MessageBox.Show("Click on Add & Fill Detaisl first!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
        }

        private void ClearnSet()
        {
           // txtAttID.Text= "";
            txtAttName.Text = "";
            cmbxAttendence.Text = "--Select--";
            dtpAttDate.Value=DateTime.Today;
            cmbxMemberType.Text = "--Select--";
            cmbxAttBy.Text = "--Select--";
            txtAttName.Focus();

            label26.Visible = txtSearchByName.Visible = btnExport.Visible = false; 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAttend.Visible = false; 
            dgrvAttendInfo1.Visible = true;
            AttendShowGrid(); 
        }

        private void dgrvAttendInfo1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label6.Text = "Update:";
            txtAttID.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[0].Value.ToString();   
            txtAttName.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbxAttendence.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpAttDate.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbxMemberType.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbxAttBy.Text = dgrvAttendInfo1.Rows[e.RowIndex].Cells[5].Value.ToString();

            dgrvAttendInfo1.Hide();  //dgrvCourses.Visible = false;
            grbxAttend.Visible = true;
            txtAttID.ReadOnly = true; 

            label26.Visible = txtSearchByName.Visible = btnExport.Visible = false; 

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            label2.Text = "Update Course:";
            if (txtAttID.Text != "" && txtAttName.Text != "")
            {
                try
                {
                    con.Open();

                    string q3 = "UPDATE tbl_attendence_master SET att_id=@aid,att_name=@anm,att_attstatus=@dattstats,att_date=@attdt,att_memtype=@amemtyp,att_attby=@attby WHERE att_id=@aid";
                    cmd = new SqlCommand(q3, con);

                    int attidd = Convert.ToInt32(txtAttID.Text);

                    cmd.Parameters.Add(new SqlParameter("aid", attidd));
                    cmd.Parameters.Add(new SqlParameter("anm", txtAttName.Text));
                    cmd.Parameters.Add(new SqlParameter("dattstats", cmbxAttendence.Text));
                    cmd.Parameters.Add(new SqlParameter("attdt", dtpAttDate.Value.ToShortDateString())); //date only
                    cmd.Parameters.Add(new SqlParameter("amemtyp", cmbxMemberType.Text));
                    cmd.Parameters.Add(new SqlParameter("attby", cmbxAttBy.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxAttend.Visible = false; 
                        MessageBox.Show("Attendence Updated !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvAttendInfo1.Visible = true;
                        AttendShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("Attendence Update Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    AttendShowGrid(); 
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
                label26.Visible = txtSearchByName.Visible = btnExport.Visible = false; 
                MessageBox.Show("Select A Record To Update??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            AttendShowGrid();

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            label26.Visible = txtSearchByName.Visible = btnExport.Visible = true;
            txtSearchByName.Focus();

            AttendShowGrid(); 
            grbxAttend.Visible = false;
            dgrvAttendInfo1.Visible = true;
        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtAttID.Text != "") 
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT att_id AS ID,att_name AS Name,att_attstatus AS Status,att_date AS Date,att_memtype As MemberType,att_attby As AttendenceBy FROM tbl_attendence_master WHERE att_name LIKE '" + txtSearchByName.Text + "%'"; 
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvAttendInfo1.DataSource = dt;
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
                AttendShowGrid();  
            }   
        }

        private void btnExport_Click(object sender, EventArgs e)
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

                worksheet.Name = "Attendence_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrvAttendInfo1.Columns.Count + 1; i++)     // storing header part in Excel    
                {
                    worksheet.Cells[1, i] = dgrvAttendInfo1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgrvAttendInfo1.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrvAttendInfo1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrvAttendInfo1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Attend_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain frMN = new frmMain();
            frMN.Show();
            this.Hide();
        }
       

    }
}
