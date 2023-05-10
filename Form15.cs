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
    public partial class frmFeeRecPrint : Form
    {
        public frmFeeRecPrint()
        {
            InitializeComponent();
        }

        private void frmFeeRecPrint_Load(object sender, EventArgs e)
        {
            txtRecieptNo.Text=frmFees.RecNo.ToString();   //Rec id from gridview
           // this.crystalReportViewer1.RefreshReport();
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            CrystalReport22 cr = new CrystalReport22();
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ToString();

            if (txtRecieptNo.Text != "")
            {
                int RecN = int.Parse(txtRecieptNo.Text);

                string sql = "Select * From tbl_fees_master where rec_id='" + RecN + "' ";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(ds, "tbl_fees_master");
                DataTable dt = ds.Tables["tbl_fees_master"];

                cr.SetDataSource(ds.Tables["tbl_fees_master"]);
                //
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
            }
            else
            {
                MessageBox.Show("Enter valid reciept No.??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
