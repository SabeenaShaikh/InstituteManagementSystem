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
    public partial class frmFirst : Form
    {
        public frmFirst()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            frmLog.Show();
            this.Hide();
        }

        
    }
}
