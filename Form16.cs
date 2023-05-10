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
    public partial class frmAdmFormPrint : Form
    {
        public frmAdmFormPrint()
        {
            InitializeComponent();
        }

       
        private void frmAdmFormPrint_Load(object sender, EventArgs e)
        {
            // this.crystalReportViewer1.RefreshReport();
        }
       

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            CrystalReport11 cr = new CrystalReport11();
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ToString();

            if (txtStudID.Text != "")
            {
                int stdID = int.Parse(txtStudID.Text);

                string sql = "Select * From tbl_student_master where stud_id='" + stdID + "' ";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(ds, "tbl_student_master");
                DataTable dt = ds.Tables["tbl_student_master"];

                cr.SetDataSource(ds.Tables["tbl_student_master"]);
                //
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Enter valid Student ID??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frmMN = new frmMain();
            frmMN.Show();

            this.Hide();
        }

    }
}
