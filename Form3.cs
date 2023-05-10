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
    public partial class frmProcess : Form
    {
        public frmProcess()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Fun_ProgressBar();
        }

        public void Fun_ProgressBar()
        {
            progressBar1.Increment(1);
            label2.Text = "" + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                frmMain frmMai = new frmMain();
                frmMai.Show();
                this.Hide();
            }
        }

    }
}
