using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;                 //
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;   //
using System.Configuration;    //


namespace ISMS_Project
{
    public partial class frmCourses : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            grbxCourses.Visible = false;
            CourseShowGrid();

            label7.Visible = txtSearchByCourse.Visible = false;

        }
        private void CourseShowGrid()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ISMS_Project_DB_StudentConnectionString"].ConnectionString);

            try
            {
                con.Open();
                string q = "SELECT crs_id AS CourseID,crs_name AS Name,crs_duration AS Duration,crs_fees AS Fees FROM tbl_courses_master";
                cmd = new SqlCommand(q, con);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);

                dgrvCourses.DataSource = dt;
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

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            label2.Text = "Add Course:";
            grbxCourses.Visible = true;
            dgrvCourses.Visible = false;

            int index = dt.Rows.Count - 1;
            int crsID = Convert.ToInt32(dt.Rows[index][0]) + 1;  
            txtCrsID.ReadOnly = true;
            txtCrsID.Text = crsID.ToString();
            cmbbxCrsName.Focus();

            label7.Visible = txtSearchByCourse.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCrsID.Text != "" && cmbbxCrsName.Text!= "--Select--" && cmbbxCrsDur.Text!= "--Select--" && cmbbxCrsFees.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q2 = "INSERT INTO tbl_courses_master VALUES(@crid,@crnm,@crdur,@crfee)";
                    cmd = new SqlCommand(q2, con);

                    int courseid = Convert.ToInt32(txtCrsID.Text);
                    int coursefee = Convert.ToInt32(cmbbxCrsFees.Text);

                    cmd.Parameters.Add(new SqlParameter("crid", courseid));
                    cmd.Parameters.Add(new SqlParameter("crnm", cmbbxCrsName.Text));
                    cmd.Parameters.Add(new SqlParameter("crdur", cmbbxCrsDur.Text));
                    cmd.Parameters.Add(new SqlParameter("crfee", coursefee));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        MessageBox.Show("Course Added Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grbxCourses.Visible = false;

                        dgrvCourses.Visible = true;
                        CourseShowGrid();
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
            txtCrsID.Text = "";
            cmbbxCrsName.Text = "--Select--";
            cmbbxCrsDur.Text = "--Select--";
            cmbbxCrsFees.Text = "--Select--";
            cmbbxCrsName.Focus();

            label7.Visible = txtSearchByCourse.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ClearnSet();
            grbxCourses.Visible = false;
            dgrvCourses.Visible = true;
            CourseShowGrid();
        }

        private void dgrvCourses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = "Update/Delete Course:";
            txtCrsID.Text = dgrvCourses.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbbxCrsName.Text = dgrvCourses.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbbxCrsDur.Text = dgrvCourses.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbbxCrsFees.Text = dgrvCourses.Rows[e.RowIndex].Cells[3].Value.ToString();

            dgrvCourses.Hide();  //dgrvCourses.Visible = false;
            grbxCourses.Visible = true;
            txtCrsID.ReadOnly = true;

            label7.Visible = txtSearchByCourse.Visible = false;
        }
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            label2.Text = "Update Course:";
            if (txtCrsID.Text != "" && cmbbxCrsName.Text != "--Select--" && cmbbxCrsDur.Text != "--Select--" && cmbbxCrsFees.Text != "--Select--")
            {
                try
                {
                    con.Open();

                    string q3 = "UPDATE tbl_courses_master SET crs_id=@crid,crs_name=@crnm,crs_duration=@crdur,crs_fees=@crfee WHERE crs_id=@crid";
                    cmd = new SqlCommand(q3, con);

                    int courseid = Convert.ToInt32(txtCrsID.Text);
                    int coursefee = Convert.ToInt32(cmbbxCrsFees.Text);

                    cmd.Parameters.Add(new SqlParameter("crid", courseid));
                    cmd.Parameters.Add(new SqlParameter("crnm", cmbbxCrsName.Text));
                    cmd.Parameters.Add(new SqlParameter("crdur", cmbbxCrsDur.Text));
                    cmd.Parameters.Add(new SqlParameter("crfee", coursefee));

                    int ans = cmd.ExecuteNonQuery();
                    if (ans > 0)
                    {
                        grbxCourses.Visible = false;
                        MessageBox.Show("Course Updated Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearnSet();
                        dgrvCourses.Visible = true;
                        CourseShowGrid();
                    }
                    else
                    {
                        MessageBox.Show("Record Update Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    CourseShowGrid();
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
                label7.Visible = txtSearchByCourse.Visible = false;
                MessageBox.Show("Please Select A Record To Update?", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearnSet();
            CourseShowGrid();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label2.Text = "Delete Course:";
            if (txtCrsID.Text!= "")
            {
                try
                {
                    string q4 = "DELETE FROM tbl_courses_master WHERE crs_id=@crid";
                    cmd = new SqlCommand(q4, con);
                    con.Open();

                    int crsid = Convert.ToInt32(txtCrsID.Text);
                    cmd.Parameters.Add(new SqlParameter("crid", crsid));

                    int ans = cmd.ExecuteNonQuery();
                    con.Close();
                    if (ans > 0)
                    {
                        grbxCourses.Visible = false;
                        MessageBox.Show("Course Deleted Successfully !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Course Deletion Failed !!", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ClearnSet();
                    CourseShowGrid();
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
                label7.Visible = txtSearchByCourse.Visible =false;
                MessageBox.Show("Please Select A Record To Delete??", "Message::", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearnSet();         
            dgrvCourses.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            label7.Visible = txtSearchByCourse.Visible = true;
            txtSearchByCourse.Focus();

            CourseShowGrid();
            grbxCourses.Visible = false;
            dgrvCourses.Visible = true;
        }

        private void txtSearchByCourse_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByCourse.Text != "")
            {
                try
                {
                    con.Open();
                    string q5 = "SELECT crs_id AS CourseID,crs_name AS Name,crs_duration AS Duration,crs_fees AS Fees FROM tbl_courses_master WHERE crs_name LIKE '" + txtSearchByCourse.Text + "%'";
                    cmd = new SqlCommand(q5, con);

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgrvCourses.DataSource = dt; 
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
                CourseShowGrid();
            }   
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
