using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISMS_Project
{
    public partial class frmPrintReciept : Form
    {
        
        
        public frmPrintReciept()
        {
            InitializeComponent();
        }

        private void frmPrintReciept_Load(object sender, EventArgs e)
        {
             lblRecNo.Text = frmFees.RecNo.ToString();
             lblRecDate.Text = frmFees.RecDate;
             lblStudName.Text = frmFees.StudName;
             lblCourseName.Text = frmFees.CourseName;
             lblTotFees.Text = frmFees.TotFees.ToString();
             lblPFees.Text = frmFees.PaidFees.ToString();
             lblPaidFees.Text = frmFees.PaidFees.ToString();
             lblBalFees.Text = frmFees.BalFees.ToString();
             lblDueDate.Text = frmFees.DueDate;
             lblPayMode.Text = frmFees.PayMode;          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmFees frmFEE = new frmFees();
            frmFEE.Show();

            this.Hide();
        }
    }
}
