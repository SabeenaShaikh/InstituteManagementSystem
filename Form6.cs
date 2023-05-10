using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;


namespace ISMS_Project
{
    public partial class frmAddmission : Form
    {
        SqlConnection con;  
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmAddmission()
        {
            InitializeComponent();
        }

        private void frmAddmission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_fees_master' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_courses_master' table. You can move, or remove it, as needed.
            ////this.tbl_courses_masterTableAdapter.Fill(this.dB_StudentDataSet.tbl_courses_master);
            // TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_courses_master' table. You can move, or remove it, as needed.
            //// TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_student_master' table. You can move, or remove it, as needed.
            //this.tbl_student_masterTableAdapter.Fill(this.dB_StudentDataSet.tbl_student_master);
            ClearnSet();
            grpboxAddm.Visible = false;
            AdmShowGrid();

            label25.Visible = label26.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintAddmForm.Visible = false;

            label13.Visible = label14.Visible = true;
            AllCounts();
        }

        private void AllCounts()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();

                //all rows count & except stud_delete_flag !=1
                string qcnt0 = "SELECT COUNT(*) FROM tbl_student_master WHERE stud_delete_flag<>1";
                cmd = new SqlCommand(qcnt0, con);
                Int32 count0 = (Int32)cmd.ExecuteScalar();
                label16.Text = count0.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); //do comment later befor depoly/setup
            }
            finally
            {
                con.Close();
            }
        }
        private void AdmShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT stud_id AS StudentID,stud_admdate AS AdmDate,stud_name AS Name,stud_dob AS DoB,stud_gender AS Gender,stud_mobile AS Mobile,stud_email AS EMail,stud_address AS Address,stud_course AS Course,stud_fees AS TotalFees,stud_duration AS Duration,stud_faculty AS Faculty,stud_batchtime AS Time,stud_status AS Status,stud_placedate AS Date,stud_place AS Place FROM tbl_student_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrdviewAdm.DataSource = dt;
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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            grpboxAddm.Visible = true;
            dgrdviewAdm.Visible = false;

            int index = dt.Rows.Count - 1;
            int studID = Convert.ToInt32(dt.Rows[index][0]) + 1;  //1117+1 =1118 & So on

            txtStudID.ReadOnly = true;
            txtStudID.Text = studID.ToString();
            txtStudName.Focus();

            label25.Visible = label26.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintAddmForm.Visible = false;

            label17.Visible = label16.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtStudName.Text!="" && rdbtnMale.Checked==false ||rdbtnFemale.Checked==false && txtMobile.Text!="" && txtEmail.Text!="" && txtAddress.Text!="" && txtPlace.Text!="")
            {
                try
                {
                    con.Open();

                    string q2="INSERT INTO tbl_student_master VALUES(@stdid,@stdadt,@stdnm,@stddb,@stdgend,@stdmob,@stdemail,@stdadd,@stdcrse,@stdfee,@stddur,@stdfacl,@stdbtime,@stdstts,@stdplcdt,@stdplc,@delflag)";
                    cmd=new SqlCommand(q2,con);

                   int stid=Convert.ToInt32(txtStudID.Text);
                   int stfee=Convert.ToInt32(cmbbxFees.Text);
                   int stdelflag=0;
                   string stdgen="Unknown";
                if(rdbtnMale.Checked==true)
                    stdgen=rdbtnMale.Text;
                else
                    stdgen=rdbtnFemale.Text; 

                cmd.Parameters.Add(new SqlParameter("stdid",stid));
                cmd.Parameters.Add(new SqlParameter("stdadt",dtpAdmDate.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("stdnm",txtStudName.Text));
                cmd.Parameters.Add(new SqlParameter("stddb",dtpStudDob.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("stdgend",stdgen));
                cmd.Parameters.Add(new SqlParameter("stdmob",txtMobile.Text));
                cmd.Parameters.Add(new SqlParameter("stdemail",txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("stdadd",txtAddress.Text));
                cmd.Parameters.Add(new SqlParameter("stdcrse",cmbbxCourse.Text));
                cmd.Parameters.Add(new SqlParameter("stdfee",stfee));
                cmd.Parameters.Add(new SqlParameter("stddur",cmbbxDuration.Text));
                cmd.Parameters.Add(new SqlParameter("stdfacl",cmbbxFaculty.Text));
                cmd.Parameters.Add(new SqlParameter("stdbtime",cmbbxBatchTime.Text));
                cmd.Parameters.Add(new SqlParameter("stdstts",cmbbxStatus.Text));
                cmd.Parameters.Add(new SqlParameter("stdplcdt",dtpPlace.Value.ToShortDateString()));
                cmd.Parameters.Add(new SqlParameter("stdplc",txtPlace.Text));
                cmd.Parameters.Add(new SqlParameter("delflag",stdelflag));

                int ans=cmd.ExecuteNonQuery();
                if(ans>0)
                {
                    MessageBox.Show("Record Saved Successfully!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grpboxAddm.Visible = false;
                   
                    dgrdviewAdm.Visible=true; 
                    AdmShowGrid();
                    AllCounts();
                    label17.Visible = label16.Visible = true;
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
                MessageBox.Show("Please,Click on Add & Fill Information first!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            
        }

        private void ClearnSet()  
        {
            dtpAdmDate.Value = DateTime.Today;
            txtStudID.Text = "";
            txtStudName.Text = "";
            dtpStudDob.Value = DateTime.Today;
            // rdbtnMale.Checked = false;
            //rdbtnFemale.Checked = false;
            txtMobile.Text = txtEmail.Text = txtAddress.Text = "";

            cmbbxCourse.Text = cmbbxFees.Text = cmbbxDuration.Text = cmbbxFaculty.Text = cmbbxBatchTime.Text = cmbbxStatus.Text = "--Select--";
            dtpPlace.Value = DateTime.Today;
            txtPlace.Text = "";

            label25.Visible = label26.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintAddmForm.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grpboxAddm.Visible = false;
            dgrdviewAdm.Visible = true;
            AdmShowGrid();

            label17.Visible = label16.Visible = true;
        }

        private void dgrdviewAdm_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtStudID.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpAdmDate.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStudName.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpStudDob.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgrdviewAdm.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
                rdbtnMale.Checked = true;
            else
                rdbtnFemale.Checked = true;

            txtMobile.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[7].Value.ToString();
            cmbbxCourse.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbbxFees.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[9].Value.ToString();
            cmbbxDuration.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbbxFaculty.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[11].Value.ToString();
            cmbbxBatchTime.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[12].Value.ToString();
            cmbbxStatus.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[13].Value.ToString();
            dtpPlace.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtPlace.Text = dgrdviewAdm.Rows[e.RowIndex].Cells[15].Value.ToString();

            dgrdviewAdm.Hide();
            grpboxAddm.Visible = true;

            label17.Visible = label16.Visible = false;

        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (txtStudName.Text != "" && rdbtnMale.Checked == false || rdbtnFemale.Checked == false && txtMobile.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtPlace.Text != "")
            {
                try
                {
                    con.Open();

                    string q3 = "UPDATE tbl_student_master SET stud_id=@stdid,stud_admdate=@stdadt,stud_name=@stdnm,stud_dob=@stddb,stud_gender=@stdgend,stud_mobile=@stdmob,stud_email=@stdemail,stud_address=@stdadd,stud_course=@stdcrse,stud_fees=@stdfee,stud_duration=@stddur,stud_faculty=@stdfacl,stud_batchtime=@stdbtime,stud_status=@stdstts,stud_placedate=@stdplcdt,stud_place=@stdplc,stud_delete_flag=@delflag WHERE stud_id=@stdid ";
                    cmd = new SqlCommand(q3, con);

                    int stid = Convert.ToInt32(txtStudID.Text);
                    int stfee = Convert.ToInt32(cmbbxFees.Text);
                    int stdelflag = 0;
                    string stdgen = "Unknown";
                    if (rdbtnMale.Checked == true)
                        stdgen = rdbtnMale.Text;
                    else
                        stdgen = rdbtnFemale.Text;

                    cmd.Parameters.Add(new SqlParameter("stdid", stid));
                    cmd.Parameters.Add(new SqlParameter("stdadt", dtpAdmDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("stdnm", txtStudName.Text));
                    cmd.Parameters.Add(new SqlParameter("stddb", dtpStudDob.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("stdgend", stdgen));
                    cmd.Parameters.Add(new SqlParameter("stdmob", txtMobile.Text));
                    cmd.Parameters.Add(new SqlParameter("stdemail", txtEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("stdadd", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("stdcrse", cmbbxCourse.Text));
                    cmd.Parameters.Add(new SqlParameter("stdfee", stfee));
                    cmd.Parameters.Add(new SqlParameter("stddur", cmbbxDuration.Text));
                    cmd.Parameters.Add(new SqlParameter("stdfacl", cmbbxFaculty.Text));
                    cmd.Parameters.Add(new SqlParameter("stdbtime", cmbbxBatchTime.Text));
                    cmd.Parameters.Add(new SqlParameter("stdstts", cmbbxStatus.Text));
                    cmd.Parameters.Add(new SqlParameter("stdplcdt", dtpPlace.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("stdplc", txtPlace.Text));
                    cmd.Parameters.Add(new SqlParameter("delflag", stdelflag));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grpboxAddm.Visible = false; 
                        MessageBox.Show("Record Updated Successful !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrdviewAdm.Visible = true;
                        AdmShowGrid();
                        AllCounts();
                        label17.Visible = label16.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Record Updates Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    AdmShowGrid();
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
                label25.Visible = label26.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintAddmForm.Visible = false;
                MessageBox.Show("Please Select A Record To Update?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                label17.Visible = label16.Visible = false;
            }
            ClearnSet();
            dgrdviewAdm.Visible = true;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label25.Visible = label26.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintAddmForm.Visible = true;
            AdmShowGrid();
            grpboxAddm.Visible = false;
            dgrdviewAdm.Visible = true;
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "")
            {
                try
                {
                    con.Open();
                    string q4 = "SELECT stud_id AS StudentID,stud_admdate AS AdmDate,stud_name AS Name,stud_dob AS DoB,stud_gender AS Gender,stud_mobile AS Mobile,stud_email AS EMail,stud_address AS Address,stud_course AS Course,stud_fees AS TotalFees,stud_duration AS Duration,stud_faculty AS Faculty,stud_batchtime AS Time,stud_status AS Status,stud_placedate AS Date,stud_place AS Place FROM tbl_student_master WHERE stud_id=@stid";
                    cmd = new SqlCommand(q4, con);

                    int sid = Convert.ToInt32(txtSearchByID.Text);
                    cmd.Parameters.Add(new SqlParameter("stid", sid));
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrdviewAdm.DataSource = dt;
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
               // MessageBox.Show("Enter only numeric data.");
                AdmShowGrid();
            }   
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "")
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT stud_id AS StudentID,stud_admdate AS AdmDate,stud_name AS Name,stud_dob AS DoB,stud_gender AS Gender,stud_mobile AS Mobile,stud_email AS EMail,stud_address AS Address,stud_course AS Course,stud_fees AS TotalFees,stud_duration AS Duration,stud_faculty AS Faculty,stud_batchtime AS Time,stud_status AS Status,stud_placedate AS Date,stud_place AS Place FROM tbl_student_master WHERE stud_name LIKE '" +txtSearchByName.Text + "%'";
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrdviewAdm.DataSource = dt;
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
                AdmShowGrid();
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStudID.Text != "")
            {
                try
                {
                    string q = "DELETE FROM tbl_student_master WHERE stud_id=@stid";
                    cmd = new SqlCommand(q, con);
                    con.Open();

                    int sid = Convert.ToInt32(txtStudID.Text);
                    cmd.Parameters.Add(new SqlParameter("stid", sid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grpboxAddm.Visible = false;
                        MessageBox.Show("Record Deletion Successful !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllCounts();
                        label17.Visible = label16.Visible = true;
                        
                    }
                    else
                    {
                        label17.Visible = label16.Visible = false;
                        MessageBox.Show("Record Deletion Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    AdmShowGrid();
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
                label25.Visible = label25.Visible = txtSearchByID.Visible = txtSearchByName.Visible = false;
                MessageBox.Show("Please Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();
           // grpboxAddm.Visible=true;
            dgrdviewAdm.Visible=true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frmMN = new frmMain();
            frmMN.Show();
            this.Hide();
        }

        private void btnPrintAddmForm_Click(object sender, EventArgs e)
        {
            
           // MessageBox.Show("Select Addmission Form To Print?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            //for this take dgrdviewAdm2 with same info  & vis=true & other false to print - & trans griddata to form frmFormPrint bcox this is used edit delete search when dbl click
            frmAdmFormPrint frmAFPR = new frmAdmFormPrint();
            frmAFPR.Show();
            this.Hide();
        }
        
        private void btnExport_Click(object sender, EventArgs e) //from .NET Tab Microsoft.Office.Interop.Excel Ref added for excelexport
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

                worksheet.Name = "Students_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrdviewAdm.Columns.Count + 1; i++)     // storing header part in Excel  
                {
                    worksheet.Cells[1, i] = dgrdviewAdm.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgrdviewAdm.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrdviewAdm.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrdviewAdm.Rows[i].Cells[j].Value.ToString(); 
                    }
                }


                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Students_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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
