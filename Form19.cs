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
    public partial class frmSalary : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmSalary()
        {
            InitializeComponent();
        }

        private void frmSalary_Load(object sender, EventArgs e)
        {
            grbxAddSalary.Visible = false;
            SalaryShowGrid();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = false;
            
        }

        private void SalaryShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT sal_srno AS SrNo,sal_ename AS Name,sal_edoj AS DateofJoining,sal_erole AS Role,sal_basic AS BasicSalary,sal_deduc AS Deduction,sal_netsal As NetSalary,sal_bankname AS AcNo,sal_bankifsc AS IFSC,sal_month AS Month,sal_transdate AS TransDate,sal_status AS Status FROM tbl_salary_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvSalaryInfo1.DataSource = dt;  
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
            label2.Text = "Add Salary:";
            grbxAddSalary.Visible = true;
            dgrvSalaryInfo1.Visible = false;

            int index = dt.Rows.Count - 1;
            int srNO = Convert.ToInt32(dt.Rows[index][0]) + 1;
            txtSrNo.ReadOnly = true;
            txtSrNo.Text = srNO.ToString();
            txtName.Focus();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = false;
        }

//**************************************Salary Cal
        private void SalaryAmtCal()
        {
            int BasicSal, DeductSal;

            BasicSal = Convert.ToInt32(cmbxBasSal.Text);
            DeductSal = Convert.ToInt32(txtDeduc.Text);

            txtNetSal.Text = Convert.ToString(BasicSal - DeductSal); 
        }
        private void txtDeduc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SalaryAmtCal();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                // MessageBox.Show("Paid amount not empty!!");
                txtDeduc.Text = "";
                txtNetSal.Text = "";
            }
        }

        //******************************************************Salary Cal
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSrNo.Text != "" && txtName.Text != "" && cmbxBasSal.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_salary_master VALUES(@ssrrn,@senm,@sedojdt,@serole,@sbas,@sded,@snetsl,@sbanknmacc,@sbankifsc,@smont,@strdt,@sstats)";
                    cmd = new SqlCommand(q2, con);

                    int srnum = Convert.ToInt32(txtSrNo.Text);
                    int bsal=Convert.ToInt32(cmbxBasSal.Text);
                    int dsal=Convert.ToInt32(txtDeduc.Text);
                    int netsal=Convert.ToInt32(txtNetSal.Text);

                    cmd.Parameters.Add(new SqlParameter("ssrrn", srnum));        //int in dbs table so need conversion
                    cmd.Parameters.Add(new SqlParameter("senm", txtName.Text)); 
                    cmd.Parameters.Add(new SqlParameter("sedojdt", dtpDoj.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("serole", cmbxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("sbas", bsal));          // int in dbs table so need conversion
                    cmd.Parameters.Add(new SqlParameter("sded", dsal));           //
                    cmd.Parameters.Add(new SqlParameter("snetsl", netsal));        //
                    cmd.Parameters.Add(new SqlParameter("sbanknmacc", txtBankAccNo.Text));
                    cmd.Parameters.Add(new SqlParameter("sbankifsc", txtBankIfsc.Text));
                    cmd.Parameters.Add(new SqlParameter("smont", cmbxSalMonth.Text));
                    cmd.Parameters.Add(new SqlParameter("strdt", dtpTransDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("sstats", cmbxSalStatus.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Salary Details Saved Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAddSalary.Visible = false; 

                        dgrvSalaryInfo1.Visible = true;
                        SalaryShowGrid();
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
                MessageBox.Show("Click on Add & Fill Details first!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
        }

        private void ClearnSet()
        {
           // txtSrNo.Text = "";

            txtName.Text = "";
            dtpDoj.Value = DateTime.Today;
            cmbxRole.Text = "--Select--";
            cmbxBasSal.Text="--Select--";
            txtDeduc.Text = "";
            txtNetSal.Text = "";
            txtBankAccNo.Text = "";
            txtBankIfsc.Text = "";
            cmbxSalMonth.Text = "--Select--";
            dtpTransDate.Value = DateTime.Today;
            cmbxSalStatus.Text = "--Select--";
            txtName.Focus();

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = false;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAddSalary.Visible = false;
            dgrvSalaryInfo1.Visible = true;
            SalaryShowGrid();
        }

        private void dgrvSalaryInfo1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Update:";
            txtSrNo.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDoj.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbxRole.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbxBasSal.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDeduc.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNetSal.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBankAccNo.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBankIfsc.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[8].Value.ToString();
            cmbxSalMonth.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[9].Value.ToString();
            dtpTransDate.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[10].Value.ToString();
            cmbxSalStatus.Text = dgrvSalaryInfo1.Rows[e.RowIndex].Cells[11].Value.ToString();

            dgrvSalaryInfo1.Hide();  //dgrvSalaryInfo1.Visible = false;
            grbxAddSalary.Visible = true;
            txtSrNo.ReadOnly = true;

            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = false;
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update:";
            if (txtSrNo.Text != "" && txtName.Text != "" && cmbxBasSal.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q3 = "UPDATE tbl_salary_master SET sal_srno=@ssrrn,sal_ename=@senm,sal_edoj=@sedojdt,sal_erole=@serole,sal_basic=@sbas,sal_deduc=@sded,sal_netsal=@snetsl,sal_bankname=@sbanknmacc,sal_bankifsc=@sbankifsc,sal_month=@smont,sal_transdate=@strdt,sal_status=@sstats WHERE sal_srno=@ssrrn";
                    cmd = new SqlCommand(q3, con);

                    int srnum = Convert.ToInt32(txtSrNo.Text);

                    cmd.Parameters.Add(new SqlParameter("ssrrn", srnum));
                    cmd.Parameters.Add(new SqlParameter("senm", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("sedojdt", dtpDoj.Value.ToShortDateString())); //dtpDoj.Text
                    cmd.Parameters.Add(new SqlParameter("serole", cmbxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("sbas", cmbxBasSal.Text));
                    cmd.Parameters.Add(new SqlParameter("sded", txtDeduc.Text));
                    cmd.Parameters.Add(new SqlParameter("snetsl", txtNetSal.Text));
                    cmd.Parameters.Add(new SqlParameter("sbanknmacc", txtBankAccNo.Text));
                    cmd.Parameters.Add(new SqlParameter("sbankifsc", txtBankIfsc.Text));
                    cmd.Parameters.Add(new SqlParameter("smont", cmbxSalMonth.Text));
                    cmd.Parameters.Add(new SqlParameter("strdt", dtpTransDate.Value.ToShortDateString()));
                    cmd.Parameters.Add(new SqlParameter("sstats", cmbxSalStatus.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxAddSalary.Visible = false;
                        MessageBox.Show("Salary Details Updated Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvSalaryInfo1.Visible = true;
                        SalaryShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("Salary Updatation Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    SalaryShowGrid(); 
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
                label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = false;
                MessageBox.Show("Select A Record To Update??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            SalaryShowGrid(); 
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            label12.Visible = txtSearchByName.Visible = btnExportData.Visible = btnReportPrint.Visible = true;
            txtSearchByName.Focus(); 

            SalaryShowGrid(); 
            grbxAddSalary.Visible = false;
            dgrvSalaryInfo1.Visible = true;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "")
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT sal_srno AS SrNo,sal_ename AS Name,sal_edoj AS DateofJoining,sal_erole AS Role,sal_basic AS BasicSalary,sal_deduc AS Deduction,sal_netsal As NetSalary,sal_bankname AS AcNo,sal_bankifsc AS IFSC,sal_month AS Month,sal_transdate AS TransDate,sal_status AS Status FROM tbl_salary_master WHERE sal_ename LIKE '" + txtSearchByName.Text + "%'";
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvSalaryInfo1.DataSource = dt;
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
                SalaryShowGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deletion Not Allowed For Salary Records!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnDelete.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frmM = new frmMain();
            frmM.Show();

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

                worksheet.Name = "Salary_Details";
                //Changing the name of active sheet

                for (int i = 1; i < dgrvSalaryInfo1.Columns.Count + 1; i++)     // storing header part in Excel   
                {
                    worksheet.Cells[1, i] = dgrvSalaryInfo1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgrvSalaryInfo1.Rows.Count - 1; i++)    // storing Each row and column value to excel sheet  
                {
                    for (int j = 0; j < dgrvSalaryInfo1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrvSalaryInfo1.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application        to save samefilename  with diff seconds
                workbook.SaveAs("E:\\Salary_Data_Export" + DateTime.UtcNow.Second.ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
            frmSalaryReport frmSR = new frmSalaryReport();
            frmSR.Show();
            this.Hide();
        }

      
        

       

       
    }
}
