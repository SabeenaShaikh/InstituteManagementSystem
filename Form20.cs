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
    public partial class frmSalaryReport : Form
    {
        public frmSalaryReport()
        {
            InitializeComponent();
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            // this.crystalReportViewer1.RefreshReport();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            CrystalReport44 cr4 = new CrystalReport44();
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ToString();

            if (txtSrNoReport.Text != "") 
            {
                int salsrNo = int.Parse(txtSrNoReport.Text);

                string sql = "Select * From tbl_salary_master where sal_srno='" + salsrNo + "' ";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(ds, "tbl_salary_master");
                DataTable dt = ds.Tables["tbl_salary_master"];

                cr4.SetDataSource(ds.Tables["tbl_salary_master"]);
                //
                crystalReportViewer1.ReportSource = cr4;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Enter valid SR No.??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frmm = new frmMain();
            frmm.Show();

            this.Hide();
        }
    }
}
