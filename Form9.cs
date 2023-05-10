using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;            //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;   //
using System.Configuration;    //

namespace ISMS_Project
{

    public partial class frmFees : Form
    {
        public static int RecNo;
        public static string RecDate="";
        public static string StudName="";
        public static string CourseName = "";
        public static int TotFees;
        public static int PaidFees;
        public static int BalFees;
        public static string DueDate = "";
        public static string PayMode = "";

        SqlConnection con;      //
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmFees()
        {
            InitializeComponent();
        }  

        private void frmFees_Load(object sender, EventArgs e)
        {

            btnEditUpdate.Enabled = false;  //dont allows to update/delete saved feereciepts
            btnDelete.Enabled = false;

            grbxPayFees.Visible = false;  
            StudFeesShowGrid();

            dgrv2FeesInfo.Visible = false;
            label7.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintReciept.Visible = false;
        }

        private void StudFeesShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT stud_id As StudentID,stud_admdate As AdmDate,stud_name AS Name,stud_course AS Course,stud_fees AS TotalFees FROM tbl_student_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgv1Studinfo.DataSource = dt;
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

        //************studinfogrid,feesmaster table recno+1 and Feeamt cal*************//
        private void btnPayFees_Click(object sender, EventArgs e)
        {
            grbxPayFees.Visible = false;
            dgrv2FeesInfo.Visible = false;

            if (txtRecieptNo.Text == "")
            {
                MessageBox.Show("Please Select Student To Pay Fees");
                dgv1Studinfo.Visible = true;
            }        
            else
            {
            MessageBox.Show("Please Select The Student");
            }
            grbxPayFees.Visible = false;
            dgv1Studinfo.Visible = true;   
            dgrv2FeesInfo.Visible = false;

            label7.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintReciept.Visible = false;
        }
        //************studinfogrid,feesmaster table recno+1 and Feeamt cal*************//
        private void dgv1Studinfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Pay Fees:";
            grbxPayFees.Visible = true;
            dgv1Studinfo.Hide();

            //int index = dt.Rows.Count - 1;
            //int crsID = Convert.ToInt32(dt.Rows[index][0]) + 1;
            SqlCommand cmd2;
            SqlDataReader dr2;
            DataTable dt2;

            con.Open();                                         //to get last RecNo and + 1 and Assgin to txtreciept
            string q2 = "SELECT rec_id FROM tbl_fees_master";   //stud name course & totalfee from studentmaster table
            cmd2 = new SqlCommand(q2, con);
            dr2 = cmd2.ExecuteReader();
            dt2 = new DataTable();
            dt2.Load(dr2);
            int index = dt2.Rows.Count - 1;
            int NewRec = Convert.ToInt32(dt2.Rows[index][0]) + 1;
            txtRecieptNo.ReadOnly = true;
            txtRecieptNo.Text = NewRec.ToString();
            txtStudName.Focus();

            //txtRecieptNo.Text = 
            //dtpRecDate.Text=
            //and Other some fields= from forms control,feestable and Studentmaters studinfogrid()
            txtStudName.Text = dgv1Studinfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCourse.Text = dgv1Studinfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTotalFeesAmt.Text = dgv1Studinfo.Rows[e.RowIndex].Cells[4].Value.ToString();

            con.Close();

            label7.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintReciept.Visible = false;  
        }

        private void FeeAmtCal()
        {
            int totamt, paidamt;

            totamt=Convert.ToInt32(txtTotalFeesAmt.Text);
            paidamt=Convert.ToInt32(txtPaidAmt.Text);

            txtBalAmt.Text = Convert.ToString(totamt - paidamt);
        }

        private void txtPaidAmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FeeAmtCal();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                // MessageBox.Show("Paid amount not empty!!");
               txtPaidAmt.Text = ""; txtBalAmt.Text = "";                
            }

        }
    //************studinfogrid,feesmaster table recno+1 and Feeamt cal*************//

        private void btnSaveFeeRec_Click(object sender, EventArgs e)
        {
            if (txtRecieptNo.Text != "" && txtStudName.Text != "" && txtCourse.Text != "" && txtTotalFeesAmt.Text != "" && txtPaidAmt.Text!="" && txtBalAmt.Text!="")
            {
                try
                {
                    con.Open();

                    string q3 = "INSERT INTO tbl_fees_master VALUES(@recno,@recdt,@stdnm,@stdcrs,@stdtotfee,@piad,@bal,@duedt,@paymod,@trnsid,@delflg)";
                    cmd = new SqlCommand(q3, con);

                    int recnum = Convert.ToInt32(txtRecieptNo.Text);
                    int stdtotfees = Convert.ToInt32(txtTotalFeesAmt.Text);
                    int paidfees = Convert.ToInt32(txtPaidAmt.Text);
                    int balamt = Convert.ToInt32(txtBalAmt.Text);
                    int delfl=0;
                    cmd.Parameters.Add(new SqlParameter("recno", recnum));
                    cmd.Parameters.Add(new SqlParameter("recdt", dtpRecDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("stdnm", txtStudName.Text));
                    cmd.Parameters.Add(new SqlParameter("stdcrs", txtCourse.Text));
                    cmd.Parameters.Add(new SqlParameter("stdtotfee", stdtotfees));
                    cmd.Parameters.Add(new SqlParameter("piad", paidfees));
                    cmd.Parameters.Add(new SqlParameter("bal",balamt));

                    cmd.Parameters.Add(new SqlParameter("duedt", dtpFeesDue.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("paymod", cmbbxPayMode.Text));
                    cmd.Parameters.Add(new SqlParameter("trnsid", txtTransID.Text));
                    cmd.Parameters.Add(new SqlParameter("delflg", delfl));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Fees Paid & Reciept is Saved. !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxPayFees.Visible = false;
                        dgv1Studinfo.Visible = false; //showing dgv2FeesInfo
                        dgrv2FeesInfo.Visible = true;

                        //StudFeesShowGrid();         //showing RecFeesShowGrid();
                        con.Close();
                        RecFeesShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("An Error!! Reciept Not Saved,Try Again.", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearnSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Reciept Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please,Click on PayFees & Fill Info first!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
        }

         private void RecFeesShowGrid()
        {

           // con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            SqlDataReader dr22;
            SqlCommand cmd22;
            DataTable dt22;

            try
            {
                con.Open();
                string q22 = "SELECT rec_id As RecieptNo,rec_date As Date,rec_stud_name AS Name,rec_stud_course AS Course,rec_stud_totalfee AS TotalFees,rec_paidfee As Paid,rec_balancefee As Balance,rec_duedate As DueDate,rec_paymode As PaymentMode,rec_transid As TransactionID FROM tbl_fees_master";
                cmd22 = new SqlCommand(q22, con);
                dr22 = cmd22.ExecuteReader();
                dt22 = new DataTable();
                dt22.Load(dr22);

                dgrv2FeesInfo.DataSource = dt22;
                
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



        private void ClearnSet()
        {
            txtRecieptNo.Text = "";
            dtpRecDate.Value = DateTime.Today;
            txtStudName.Text = "";
            txtCourse.Text = "";
            txtTotalFeesAmt.Text = "";
            txtPaidAmt.Text = "";
            txtBalAmt.Text = "";
            dtpFeesDue.Value = DateTime.Today;
            cmbbxPayMode.Text = "--Select--";
            txtTransID.Text = "N/A";
            txtPaidAmt.Focus();

            label7.Visible = txtSearchByName.Visible = false;
        }



        private void btnViewFees_Click(object sender, EventArgs e)
        {
             ClearnSet();
             grbxPayFees.Visible = false;
             dgv1Studinfo.Visible = false;
             dgrv2FeesInfo.Visible = true;
             //StudFeesShowGrid();
             RecFeesShowGrid();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ClearnSet();
            label7.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintReciept.Visible = true;  
            txtSearchByName.Focus();

            grbxPayFees.Visible = false;
            dgv1Studinfo.Visible = false;
            dgrv2FeesInfo.Visible = true;
            //StudFeesShowGrid();
            RecFeesShowGrid();

        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {

            if (txtSearchByName.Text != "") 
            {
                // con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

                SqlDataReader dr33;
                SqlCommand cmd33;
                DataTable dt33; 

                try
                {
                    
                    con.Open();
                    string q33 = "SELECT rec_id As RecieptNo,rec_date As Date,rec_stud_name AS Name,rec_stud_course AS Course,rec_stud_totalfee AS TotalFees,rec_paidfee As Paid,rec_balancefee As Balance,rec_duedate As DueDate,rec_paymode As PaymentMode,rec_transid As TransactionID FROM tbl_fees_master WHERE rec_stud_name LIKE '" + txtSearchByName.Text + "%'"; 
                    cmd33 = new SqlCommand(q33, con);
                    dr33 = cmd33.ExecuteReader();
                    dt33 = new DataTable();
                    dt33.Load(dr33);

                    dgrv2FeesInfo.DataSource = dt33;
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
                RecFeesShowGrid();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // ClearnSet();
            frmMain frmMai = new frmMain();
            frmMai.Show();
            this.Hide();
        }

    
        private void dgrv2FeesInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            //int num = Convert.ToInt32(dgrv2FeesInfo.Rows[e.RowIndex].Cells[0].Value);
            //RecNo = num; //trans data to another frm use stat vars
            //RecDate = dgrv2FeesInfo.Rows[e.RowIndex].Cells[1].Value.ToString();       //used in frmprinteciept
            //StudName = dgrv2FeesInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            //CourseName = dgrv2FeesInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            //TotFees = Convert.ToInt32(dgrv2FeesInfo.Rows[e.RowIndex].Cells[4].Value);
            //PaidFees = Convert.ToInt32(dgrv2FeesInfo.Rows[e.RowIndex].Cells[5].Value);
            //BalFees = Convert.ToInt32(dgrv2FeesInfo.Rows[e.RowIndex].Cells[6].Value);
            //DueDate = dgrv2FeesInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
            //PayMode = dgrv2FeesInfo.Rows[e.RowIndex].Cells[8].Value.ToString();

            //frmPrintReciept frmPrec = new frmPrintReciept();                         Form10 printRec
            //frmPrec.Show();
            //this.Hide();

            int num = Convert.ToInt32(dgrv2FeesInfo.Rows[e.RowIndex].Cells[0].Value);
            RecNo = num;         //trans data to another frm use stat vars

            frmFeeRecPrint frmFRP = new frmFeeRecPrint();
            frmFRP.Show();
            this.Hide();
        }

        private void btnPrintReciept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Reciept To Print?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ClearnSet();
            label7.Visible = txtSearchByName.Visible = btnExport.Visible = btnPrintReciept.Visible = false;
           // txtSearchByName.Focus();

            grbxPayFees.Visible = false;
            dgv1Studinfo.Visible = false;
            dgrv2FeesInfo.Visible = true;
            //StudFeesShowGrid();
            RecFeesShowGrid();
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

                worksheet.Name = "Fees_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrv2FeesInfo.Columns.Count + 1; i++)     // storing header part in Excel  
                {
                    worksheet.Cells[1, i] = dgrv2FeesInfo.Columns[i - 1].HeaderText; 
                }

                for (int i = 0; i < dgrv2FeesInfo.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrv2FeesInfo.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrv2FeesInfo.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Fees_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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
