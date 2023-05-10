using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;            //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;   //
using System.Configuration;    //

namespace ISMS_Project
{
    public partial class frmTeachers : Form
    {
        SqlConnection con;       //
        SqlCommand cmd;  
        SqlDataReader dr;
        DataTable dt;

        public frmTeachers()
        {
            InitializeComponent();
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            grbxTeachers.Visible = false;
            TeachersShowGrid();

            label10.Visible = txtSearchByName.Visible = false;
        }

        private void TeachersShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT teach_id AS TeacherID,teach_name AS Name,teach_qual AS Qualification,teach_subject AS Subject,teach_salary AS Salary,teach_mobile AS Mobile,teach_address AS Address FROM tbl_teachers_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvTeachers.DataSource = dt;
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

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            label2.Text = "Add Course:";
            grbxTeachers.Visible = true;
            dgrvTeachers.Visible = false;

            int index = dt.Rows.Count - 1;
            int teachID = Convert.ToInt32(dt.Rows[index][0]) + 1;
            txtTeachID.ReadOnly = true;
            txtTeachID.Text = teachID.ToString();
            txtTechName.Focus();

            label10.Visible = txtSearchByName.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeachID.Text != "" && txtTechName.Text != "--Select--" && cmbbxTechQual.Text != "--Select--" && cmbbxTechSub.Text != "--Select--" && cmbbxTechSal.Text != "--Select--" && txtTechMobile.Text != "" && txtTeachAdd.Text != "")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_teachers_master VALUES(@tcid,@tcnm,@tcqal,@tcsub,@tcsal,@tcmob,@tcadd)";
                    cmd = new SqlCommand(q2, con);

                    int tcrid = Convert.ToInt32(txtTeachID.Text);

                    cmd.Parameters.Add(new SqlParameter("tcid", tcrid));
                    cmd.Parameters.Add(new SqlParameter("tcnm", txtTechName.Text));
                    cmd.Parameters.Add(new SqlParameter("tcqal", cmbbxTechQual.Text));
                    cmd.Parameters.Add(new SqlParameter("tcsub", cmbbxTechSub.Text));
                    cmd.Parameters.Add(new SqlParameter("tcsal", cmbbxTechSal.Text));
                    cmd.Parameters.Add(new SqlParameter("tcmob", txtTechMobile.Text));
                    cmd.Parameters.Add(new SqlParameter("tcadd", txtTeachAdd.Text));
               
                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Teacher Saved Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxTeachers.Visible = false;

                       dgrvTeachers.Visible = true;
                       TeachersShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ClearnSet();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please,Click on Add & Fill Information first!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
        }

        private void ClearnSet()
        {
            txtTeachID.Text = ""; 
            txtTechName.Text = ""; 
            cmbbxTechQual.Text = "--Select--"; 
            cmbbxTechSub.Text = "--Select--";
            cmbbxTechSal.Text="--Select--";
            txtTechMobile.Text = ""; 
            txtTeachAdd.Text = "";

            txtTechName.Focus();

           //Search:: label7.Visible = txtSearchByCourse.Visible = false;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxTeachers.Visible = false; 
            dgrvTeachers.Visible = true;
            TeachersShowGrid();
        }


        private void dgrvTeachers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Update/Delete Teacher:";
            txtTeachID.Text = dgrvTeachers.Rows[e.RowIndex].Cells[0].Value.ToString(); 
            txtTechName.Text = dgrvTeachers.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbbxTechQual.Text = dgrvTeachers.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            cmbbxTechSub.Text = dgrvTeachers.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbbxTechSal.Text = dgrvTeachers.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTechMobile.Text = dgrvTeachers.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTeachAdd.Text = dgrvTeachers.Rows[e.RowIndex].Cells[6].Value.ToString();

            dgrvTeachers.Hide();  //dgrvTeachers.Visible = false;
            grbxTeachers.Visible = true;
            txtTeachID.ReadOnly = true;

            label10.Visible = txtSearchByName.Visible = false;
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update:";
            if (txtTeachID.Text != "" && txtTechName.Text != "" && cmbbxTechQual.Text != "--Select--" && cmbbxTechSub.Text != "--Select--" && cmbbxTechSal.Text != "--Select--" && txtTechMobile.Text != "" && txtTeachAdd.Text != "")  
            {
                try
                {
                    con.Open(); 

                    string q3 = "UPDATE tbl_teachers_master SET teach_id=@tcid,teach_name=@tcnm,teach_qual=@tcqal,teach_subject=@tcsub,teach_salary=@tcsal,teach_mobile=@tcmob,teach_address=@tcadd WHERE teach_id=@tcid";
                    cmd = new SqlCommand(q3, con);

                    int tcrid = Convert.ToInt32(txtTeachID.Text);

                    cmd.Parameters.Add(new SqlParameter("tcid", tcrid));
                    cmd.Parameters.Add(new SqlParameter("tcnm", txtTechName.Text));
                    cmd.Parameters.Add(new SqlParameter("tcqal", cmbbxTechQual.Text));
                    cmd.Parameters.Add(new SqlParameter("tcsub", cmbbxTechSub.Text));
                    cmd.Parameters.Add(new SqlParameter("tcsal", cmbbxTechSal.Text));
                    cmd.Parameters.Add(new SqlParameter("tcmob", txtTechMobile.Text));
                    cmd.Parameters.Add(new SqlParameter("tcadd", txtTeachAdd.Text));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxTeachers.Visible = false; 
                        MessageBox.Show("Record Updated !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvTeachers.Visible = true;
                        TeachersShowGrid(); 
                    }
                    else
                    {
                        MessageBox.Show("Record Update Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    TeachersShowGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Already Exists!!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                label10.Visible = txtSearchByName.Visible = false;
                MessageBox.Show("Please Select A Record To Update?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            TeachersShowGrid(); 

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label10.Visible = txtSearchByName.Visible = true;
            txtSearchByName.Focus();

            TeachersShowGrid();
            grbxTeachers.Visible = false;
            dgrvTeachers.Visible = true;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByName.Text != "")
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT teach_id AS TeacherID,teach_name AS Name,teach_qual AS Qualification,teach_subject AS Subject,teach_salary AS Salary,teach_mobile AS Mobile,teach_address AS Address FROM tbl_teachers_master WHERE teach_name LIKE '" + txtSearchByName.Text + "%'";
                   
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvTeachers.DataSource = dt; 
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
                TeachersShowGrid(); 
            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete:";
            if (txtTeachID.Text != "")
            {
                try
                {
                    string q4 = "DELETE FROM tbl_teachers_master WHERE teach_id=@tcid";
                    cmd = new SqlCommand(q4, con);
                    con.Open();

                    int tcrid = Convert.ToInt32(txtTeachID.Text);
                    cmd.Parameters.Add(new SqlParameter("tcid", tcrid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grbxTeachers.Visible = false; 
                        MessageBox.Show("Reocrd Deleted. !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Record Deletion Failed. !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    TeachersShowGrid(); 
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
                label10.Visible = txtSearchByName.Visible = false;
                MessageBox.Show("Please Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();
            dgrvTeachers.Visible = true; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // ClearnSet();
            frmMain frmMai = new frmMain();
            frmMai.Show();
            this.Hide();
        }
       
  
    }
}
