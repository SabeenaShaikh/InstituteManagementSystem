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
    public partial class frmAdmin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            grbxAddUser.Visible = false; 
            UsersShowGrid();

            label12.Visible = txtSearchByName.Visible = false; 

        }

        private void UsersShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT user_id AS UserID,user_name AS Username,use_pass AS Password FROM tbl_users_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvUsersInfo.DataSource = dt; 
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            label2.Text = "Add New User:";
            grbxAddUser.Visible = true;
            dgrvUsersInfo.Visible = false;

            int index = dt.Rows.Count - 1;
            int usrID = Convert.ToInt32(dt.Rows[index][0]) + 1;   //incr and showing in txtUserID but not storing bcoz column is Identity
            txtUserID.ReadOnly = true;
            txtUserID.Text = usrID.ToString();
            txtUser.Focus();

            label12.Visible = txtSearchByName.Visible = false; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtUser.Text !="" && txtPass.Text!="")
            {
                try
                {
                    con.Open(); 

                    string q2 = "INSERT INTO tbl_users_master VALUES(@usrnm,@usrps)";  // @usrid, 
                    cmd = new SqlCommand(q2, con);

                    //int urid = Convert.ToInt32(txtUserID.Text);
                    //cmd.Parameters.Add(new SqlParameter("usrid", urid));

                    cmd.Parameters.Add(new SqlParameter("usrnm", txtUser.Text));
                    cmd.Parameters.Add(new SqlParameter("usrps", txtPass.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("User Added Successfully.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxAddUser.Visible = false;

                        dgrvUsersInfo.Visible = true;
                        UsersShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearnSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtUserID.Text = ""; 
            txtUser.Text = "";
            txtPass.Text = "";
            txtUser.Focus();

            label12.Visible = txtSearchByName.Visible = false; 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxAddUser.Visible = false; 
            dgrvUsersInfo.Visible = true;
            UsersShowGrid(); 
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update User:";
            if (txtUserID.Text != "" && txtUser.Text != "" && txtPass.Text != "")
            {
                try
                {
                    con.Open();

                    string q3 = "UPDATE tbl_users_master SET user_name=@usrnm,use_pass=@usrps WHERE user_id=@usrid"; //user_id=@usrid,  identity col cant update so not passing
                    cmd = new SqlCommand(q3, con);

                    int urid = Convert.ToInt32(txtUserID.Text);

                    cmd.Parameters.Add(new SqlParameter("usrid", urid));
                    cmd.Parameters.Add(new SqlParameter("usrnm", txtUser.Text));
                    cmd.Parameters.Add(new SqlParameter("usrps", txtPass.Text));
                  
                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxAddUser.Visible = false; 
                        MessageBox.Show("User Updated Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvUsersInfo.Visible = true;
                        UsersShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("User Updation Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    UsersShowGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                label12.Visible = txtSearchByName.Visible = false; 
                MessageBox.Show("Select A Record To Update?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            UsersShowGrid();
        }

        private void dgrvUsersInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Update/Delete User:";
            txtUserID.Text = dgrvUsersInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUser.Text = dgrvUsersInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPass.Text = dgrvUsersInfo.Rows[e.RowIndex].Cells[2].Value.ToString();


            dgrvUsersInfo.Hide();  //dgrvUsersInfo.Visible = false;
            grbxAddUser.Visible = true;
            txtUserID.ReadOnly = true;

            label12.Visible = txtSearchByName.Visible = false; 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label12.Visible = txtSearchByName.Visible = true;
            txtSearchByName.Focus();  

            UsersShowGrid(); 
            grbxAddUser.Visible = false;
            dgrvUsersInfo.Visible = true;
        }
        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "") 
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT user_id AS UserID,user_name AS Username,use_pass AS Password FROM tbl_users_master WHERE user_name LIKE '" + txtSearchByName.Text + "%'";
                    cmd = new SqlCommand(q5, con); 

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvUsersInfo.DataSource = dt; 
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
                UsersShowGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete USer:";
            if (txtUserID.Text != "") 
            {
                try
                {
                    string q4 = "DELETE FROM tbl_users_master WHERE user_id=@usrid";
                    cmd = new SqlCommand(q4, con);
                    con.Open();

                    int urid = Convert.ToInt32(txtUserID.Text);
                    cmd.Parameters.Add(new SqlParameter("usrid", urid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grbxAddUser.Visible = false;
                        MessageBox.Show("User Deleted Successfully.!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("User Deletion Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    UsersShowGrid(); 
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
                label12.Visible = txtSearchByName.Visible = false; 
                MessageBox.Show("Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();
            dgrvUsersInfo.Visible = true; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frMN = new frmMain();
            frMN.Show();
            this.Close();
        }

       
    }
}
