using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;                  //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;       //
using System.Configuration;        //

namespace ISMS_Project
{
    public partial class frmLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public static string USER = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT count(*) FROM tbl_users_master where user_name=@uname AND use_pass=@upass";
                cmd = new SqlCommand(q, con);

                cmd.Parameters.Add(new SqlParameter("uname", txtUsername.Text));
                cmd.Parameters.Add(new SqlParameter("upass", txtPassword.Text));

                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    // MessageBox.Show("Welcome  "+txtUsername.Text.ToUpper());
                    USER = txtUsername.Text.ToUpper();
                    frmProcess frmProc = new frmProcess();
                    frmProc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            #region static login   
            //    string User = "";
            //    string Pass = "";  

            //    if (User == txtUsername.Text && Pass == txtPassword.Text)
            //    {
            //        //MessageBox.Show("Welcome :"+" "+User.ToUpper(),"Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        //MessageBox.Show("Welcome : "+" "+User.ToUpper());
            //        USER = txtUsername.Text.ToUpper();
            //        frmProcess frmProc = new frmProcess();
            //        frmProc.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sorry !! Invalid Username or Password.", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtUsername.Text = txtPassword.Text = "";
            //        txtUsername.Focus();
            //    }
        }
        #endregion static login  

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new frmFirst().Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
