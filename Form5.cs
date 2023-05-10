using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;  //db conn
using System.Configuration;  //also added reference 
  
//DataReader Conn Architecture
//Parameterized Query  eg. @enq_no
//DataGridView is used- bcoz datareader doesnt support navigations |< <<  >> >| & forword manner uses only

namespace ISMS_Project
{
    public partial class frmEnquiry : Form
    {
        SqlConnection con;  //object creation for db conn
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmEnquiry()
        {
            InitializeComponent();
        }

        private void frmEnquiry_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dB_StudentDataSet.tbl_enquiry_master' table. You can move, or remove it, as needed.
            //this.tbl_enquiry_masterTableAdapter.Fill(this.dB_StudentDataSet.tbl_enquiry_master);   //so remove data bind to grdview bcoz show all fileds
           
            grbxAddEnq.Visible =false;
            btnExportData.Visible = false;
            EnqShowGrid();

            label13.Visible = label14.Visible = true;
            AllCounts();
        }

        private void AllCounts() 
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();

                //all rows count & except enq_delete_flag !=1
                string qcnt0 = "SELECT COUNT(*) FROM tbl_enquiry_master WHERE enq_delete_flag<>1";
                cmd = new SqlCommand(qcnt0, con);
                Int32 count0 = (Int32)cmd.ExecuteScalar();
               label14.Text = count0.ToString();
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

        private void EnqShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                //so remove data bind to grdview bcoz wants to show perticular fields using query
                string q = "Select enq_no As EnquiryNo,enq_date As Date,enq_name As Name,enq_quali As Qualification,enq_course As Courses,enq_add As Address,enq_contact As MobileNo,enq_status As Status From tbl_enquiry_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrdviewEnq.DataSource = dt;

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
            grbxAddEnq.Visible = true;
            label2.Text = "Add Enquiry";
            dgrdviewEnq.Visible = false;

            int index = dt.Rows.Count - 1;  //pointing last row from tbl_Enuiry_Master
            int enqNo = Convert.ToInt32(dt.Rows[index][0]) + 1;

            txtEnqNo.ReadOnly = true;
            txtEnqNo.Text = enqNo++.ToString();
            txtName.Focus();

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible =false;
            //we cant use ClearnSet() here
            label13.Visible = label14.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && cmbboxQuali.Text != "" && cmbbxForCourse.Text != "" && txtAddress.Text != "" && txtContact.Text != "" && cmbboxStatus.Text != "")
            {
                try
                {
                    con.Open();
                    string q = "Insert into tbl_enquiry_master values(@eqno,@eqdt,@eqnm,@equal,@eqcrs,@eqadd,@eqcont,@eqsts,@delflag)"; //@eqdelflag 0 by def
                    cmd = new SqlCommand(q, con);

                    int eqn = Convert.ToInt32(txtEnqNo.Text);
                    int eqdelflag = 0;
                    cmd.Parameters.Add(new SqlParameter("eqno", eqn));
                    cmd.Parameters.Add(new SqlParameter("eqdt", dtpEnq.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("eqnm", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("equal", cmbboxQuali.Text));
                    cmd.Parameters.Add(new SqlParameter("eqcrs", cmbbxForCourse.Text));
                    cmd.Parameters.Add(new SqlParameter("eqadd", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("eqcont", txtContact.Text));
                    cmd.Parameters.Add(new SqlParameter("eqsts", cmbboxStatus.Text));
                    cmd.Parameters.Add(new SqlParameter("delflag", eqdelflag)); //@eqdelflag 0 by def

                    int ans = cmd.ExecuteNonQuery();  //return type is int so need conversion

                    if (ans > 0 )
                    { 
                        MessageBox.Show("Enquiry Saved Successfully!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AllCounts();
                        grbxAddEnq.Visible =false;
                        dgrdviewEnq.Visible = true; 
                        EnqShowGrid();

                        label13.Visible = label14.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    ClearnSet();
                   //EnqShowGrid();

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

        private void ClearnSet()      //for frmEnquiry Save & Clear after saved info for next record if any
        {
            txtEnqNo.ReadOnly = true;
            txtEnqNo.Text = "";
            dtpEnq.Value = DateTime.Today;
            txtName.Text = "";
            cmbboxQuali.Text = "--Select--";
            cmbbxForCourse.Text = "--Select--";
            txtAddress.Text = "";
            txtContact.Text = "";
            cmbboxStatus.Text = "--Select--"; //cmbboxStatus.ResetText();

            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = false;

        }

        private void btnView_Click(object sender, EventArgs e)
        {

            ClearnSet();
            grbxAddEnq.Visible = true;
            dgrdviewEnq.Visible = true;
            EnqShowGrid();
            label13.Visible = label14.Visible = true;
        }

        private void dgrdviewEnq_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtEnqNo.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtpEnq.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbboxQuali.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbbxForCourse.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbboxStatus.Text = dgrdviewEnq.Rows[e.RowIndex].Cells[7].Value.ToString();

            dgrdviewEnq.Hide();  //to alternatively use both enquryadd and dgvrecselection for update or delete time
            grbxAddEnq.Visible = true;

            label13.Visible = label14.Visible = false;
            
        }
        private void btnEditUpdate_Click(object sender, EventArgs e)   //edit & update using dgviews data
        {
            
            label2.Text = "Update Enquiry";
            if (txtName.Text != "" && cmbboxQuali.Text != "" && cmbbxForCourse.Text != "" && txtAddress.Text != "" && txtContact.Text != "" && cmbboxStatus.Text != "")
            {
                try
                {
                    con.Open();
                    string q2 = "UPDATE tbl_enquiry_master SET enq_no=@eqno,enq_date=@eqdt,enq_name=@eqnm,enq_quali=@equal,enq_course=@eqcrs,enq_add=@eqadd,enq_contact=@eqcont,enq_status=@eqsts,enq_delete_flag=@delflag WHERE enq_no=@eqno "; //@eqdelflag 0 by def
                    cmd = new SqlCommand(q2, con);

                    int eqn = Convert.ToInt32(txtEnqNo.Text);
                    int eqdelflag = 0;
                    cmd.Parameters.Add(new SqlParameter("eqno", eqn));
                    cmd.Parameters.Add(new SqlParameter("eqdt", dtpEnq.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("eqnm", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("equal", cmbboxQuali.Text));
                    cmd.Parameters.Add(new SqlParameter("eqcrs", cmbbxForCourse.Text));
                    cmd.Parameters.Add(new SqlParameter("eqadd", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("eqcont", txtContact.Text));
                    cmd.Parameters.Add(new SqlParameter("eqsts", cmbboxStatus.Text));     //@eqdelflag 0 by def
                    cmd.Parameters.Add(new SqlParameter("delflag", eqdelflag));

                    int ans = cmd.ExecuteNonQuery();  //return type is int so need conversion

                    if (ans > 0 )
                    {
                        
                        MessageBox.Show("Record Updated Successfully!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AllCounts();
                        label13.Visible = label14.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Problem With Updating Record!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                    ClearnSet();
                    EnqShowGrid();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Record !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = false;
                MessageBox.Show("Please Select A Record To Update??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label13.Visible = label14.Visible = false;
  
            }

            ClearnSet();
            grbxAddEnq.Visible = true;
            dgrdviewEnq.Visible = true;
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible =btnExportData.Visible= true;
            label13.Visible = label14.Visible = false;


            EnqShowGrid();              //changes appeared after any operation
           // ClearnSet();
            grbxAddEnq.Visible = false;
            dgrdviewEnq.Visible = true; //just making visible/appeared
            
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete Enquiry";
            if (txtEnqNo.Text != "")
            {
                try
                {
                    string q="DELETE FROM tbl_enquiry_master WHERE enq_no=@eqno";
                    cmd=new SqlCommand(q,con);
                    con.Open();

                    int eno=Convert.ToInt32(txtEnqNo.Text);
                    cmd.Parameters.Add(new SqlParameter("eqno",eno));
                    
                    int ans=cmd.ExecuteNonQuery();
                    con.Close();
                    if(ans>0)
                    {
                        
                          MessageBox.Show("Enquiry Deleted Successfully!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          AllCounts();
                          label13.Visible = label14.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Problem With Deletion Of Record!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    EnqShowGrid();
                }
                catch(Exception ex)
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
                label11.Visible = label12.Visible = txtSearchByID.Visible = txtSearchByName.Visible = btnExportData.Visible = false;
                label13.Visible = label14.Visible = false;

               MessageBox.Show("Please Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            ClearnSet();
            grbxAddEnq.Visible =true;
            dgrdviewEnq.Visible = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearnSet();
            frmMain frmMai = new frmMain();
            frmMai.Show();
            this.Hide();
        }

        private void txtSearchByID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByID.Text != "")
            {
                try
                {
                    con.Open();
                    string q = "Select enq_no As EnquiryNo,enq_date As Date,enq_name As Name,enq_quali As Qualification,enq_course As Courses,enq_add As Address,enq_contact As MobileNo,enq_status As Status From tbl_enquiry_master WHERE enq_no=@eqno";
                    cmd = new SqlCommand(q, con);

                    int eqn = Convert.ToInt32(txtSearchByID.Text);
                    cmd.Parameters.Add(new SqlParameter("eqno", eqn));
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);

                    dgrdviewEnq.DataSource = dt;

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
                //MessageBox.Show("Not Blank");
                EnqShowGrid();
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text!= "")
            {
                try
                {
                    con.Open();
                    string q = "Select enq_no As EnquiryNo,enq_date As Date,enq_name As Name,enq_quali As Qualification,enq_course As Courses,enq_add As Address,enq_contact As MobileNo,enq_status As Status From tbl_enquiry_master WHERE enq_name LIKE '" +txtSearchByName.Text + "%'";
                    cmd = new SqlCommand(q, con);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);

                    dgrdviewEnq.DataSource = dt;

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
                //MessageBox.Show("Not Blank");
                EnqShowGrid();
            }

        }

        private void btnExportData_Click(object sender, EventArgs e)  //from .NET Tab Microsoft.Office.Interop.Excel Ref added for excelexport
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

                worksheet.Name = "Enquiry_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrdviewEnq.Columns.Count + 1; i++)     // storing header part in Excel  
                {
                    worksheet.Cells[1, i] = dgrdviewEnq.Columns[i - 1].HeaderText; 
                }

                for (int i = 0; i < dgrdviewEnq.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrdviewEnq.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrdviewEnq.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application                    diff with seconds to save samefilename
                workbook.SaveAs("E:\\Enq_Data_Export"+DateTime.UtcNow.Second.ToString()+".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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


   