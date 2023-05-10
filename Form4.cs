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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Today.ToShortDateString();
            label3.Text = DateTime.Today.DayOfWeek.ToString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            frmEnquiry frmEnq = new frmEnquiry();
            frmEnq.Show();

            this.Hide();
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            frmAddmission frmAdd = new frmAddmission();
            frmAdd.Show();

            this.Hide();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            frmCourses frmCRS = new frmCourses();
            frmCRS.Show();
            this.Hide();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers frmTech = new frmTeachers();
            frmTech.Show();
            this.Hide();

        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            frmFees frmFEE = new frmFees();
            frmFEE.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWecUser.Text = frmLogin.USER;
        }

        private void btnCertificates_Click(object sender, EventArgs e)
        {
            frmCertificates frmCERT = new frmCertificates();
            frmCERT.Show();
            //this.Hide();         imp to note stud details frm window for certi details while creating 
        }

        private void btnCampus_Click(object sender, EventArgs e)
        {
            frmCampus frmCA = new frmCampus();
            frmCA.Show();
            this.Hide();

        }

        private void btnExpences_Click(object sender, EventArgs e)
        {
            frmExpences frmEXP = new frmExpences();
            frmEXP.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmADN = new frmAdmin();
            frmADN.Show();

            this.Hide();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            frmAttend frmATT = new frmAttend();
            frmATT.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalary frmSAL = new frmSalary();
            frmSAL.Show();

            this.Hide();
        }

        
    }
}
