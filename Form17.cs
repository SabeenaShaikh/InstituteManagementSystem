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
    public partial class frmPrintCertificate : Form
    {
        public frmPrintCertificate()
        {
            InitializeComponent();
        }

        private void frmPrintCertificate_Load(object sender, EventArgs e)
        {
            // this.crystalReportViewer1.RefreshReport();
        }

        private void btnGenCertificate_Click(object sender, EventArgs e)
        {
            CrystalReport33 cr = new CrystalReport33();       //for certificate
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ToString();

            if (txtCertiNo.Text != "") 
            {
                int CrtNo = int.Parse(txtCertiNo.Text);

                string sql = "Select * From tbl_Certificates_master where std_certino='" + CrtNo + "' ";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(ds, "tbl_Certificates_master");
                DataTable dt = ds.Tables["tbl_Certificates_master"];

                cr.SetDataSource(ds.Tables["tbl_Certificates_master"]);
                //
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Enter valid Certificate No.??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
