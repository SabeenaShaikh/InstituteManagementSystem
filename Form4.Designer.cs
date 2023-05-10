namespace ISMS_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCertificates = new System.Windows.Forms.Button();
            this.btnCampus = new System.Windows.Forms.Button();
            this.btnExpences = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWecUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 763);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 795);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Day";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEnquiry.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnEnquiry.Image")));
            this.btnEnquiry.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEnquiry.Location = new System.Drawing.Point(29, 57);
            this.btnEnquiry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(80, 70);
            this.btnEnquiry.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnEnquiry, "Enquiry");
            this.btnEnquiry.UseVisualStyleBackColor = true;
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // btnAdmission
            // 
            this.btnAdmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdmission.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmission.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmission.Image")));
            this.btnAdmission.Location = new System.Drawing.Point(29, 134);
            this.btnAdmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(80, 70);
            this.btnAdmission.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAdmission, "Admission");
            this.btnAdmission.UseVisualStyleBackColor = true;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCourses.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourses.Image = ((System.Drawing.Image)(resources.GetObject("btnCourses.Image")));
            this.btnCourses.Location = new System.Drawing.Point(29, 212);
            this.btnCourses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(80, 70);
            this.btnCourses.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCourses, "Courses");
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTeachers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachers.Image = ((System.Drawing.Image)(resources.GetObject("btnTeachers.Image")));
            this.btnTeachers.Location = new System.Drawing.Point(29, 289);
            this.btnTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(80, 70);
            this.btnTeachers.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnTeachers, "Teachers");
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1349, 757);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 828);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnFees
            // 
            this.btnFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFees.Image = ((System.Drawing.Image)(resources.GetObject("btnFees.Image")));
            this.btnFees.Location = new System.Drawing.Point(29, 367);
            this.btnFees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFees.Name = "btnFees";
            this.btnFees.Size = new System.Drawing.Size(80, 70);
            this.btnFees.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnFees, "Fees");
            this.btnFees.UseVisualStyleBackColor = true;
            this.btnFees.Click += new System.EventHandler(this.btnFees_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(113, 677);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(80, 70);
            this.btnLogout.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnLogout, "Logout");
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(29, 677);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(80, 70);
            this.btnMinimize.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCertificates
            // 
            this.btnCertificates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCertificates.BackgroundImage")));
            this.btnCertificates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCertificates.Location = new System.Drawing.Point(29, 444);
            this.btnCertificates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCertificates.Name = "btnCertificates";
            this.btnCertificates.Size = new System.Drawing.Size(80, 70);
            this.btnCertificates.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCertificates, "Certificates");
            this.btnCertificates.UseVisualStyleBackColor = true;
            this.btnCertificates.Click += new System.EventHandler(this.btnCertificates_Click);
            // 
            // btnCampus
            // 
            this.btnCampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCampus.BackgroundImage")));
            this.btnCampus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCampus.Location = new System.Drawing.Point(29, 522);
            this.btnCampus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCampus.Name = "btnCampus";
            this.btnCampus.Size = new System.Drawing.Size(80, 70);
            this.btnCampus.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnCampus, "Campus");
            this.btnCampus.UseVisualStyleBackColor = true;
            this.btnCampus.Click += new System.EventHandler(this.btnCampus_Click);
            // 
            // btnExpences
            // 
            this.btnExpences.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpences.BackgroundImage")));
            this.btnExpences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpences.Location = new System.Drawing.Point(29, 599);
            this.btnExpences.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpences.Name = "btnExpences";
            this.btnExpences.Size = new System.Drawing.Size(80, 70);
            this.btnExpences.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnExpences, "Expences");
            this.btnExpences.UseVisualStyleBackColor = true;
            this.btnExpences.Click += new System.EventHandler(this.btnExpences_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(113, 212);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(80, 70);
            this.btnAdmin.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnAdmin, "Admin");
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalary.BackgroundImage")));
            this.btnSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalary.Location = new System.Drawing.Point(113, 134);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(80, 70);
            this.btnSalary.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnSalary, "Salary");
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttendence.BackgroundImage")));
            this.btnAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAttendence.Location = new System.Drawing.Point(113, 57);
            this.btnAttendence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(80, 70);
            this.btnAttendence.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnAttendence, "Attendence");
            this.btnAttendence.UseVisualStyleBackColor = true;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Welcome:";
            // 
            // lblWecUser
            // 
            this.lblWecUser.AutoSize = true;
            this.lblWecUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWecUser.Location = new System.Drawing.Point(304, 32);
            this.lblWecUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWecUser.Name = "lblWecUser";
            this.lblWecUser.Size = new System.Drawing.Size(105, 23);
            this.lblWecUser.TabIndex = 26;
            this.lblWecUser.Text = "Logged User";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1567, 950);
            this.Controls.Add(this.lblWecUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnAttendence);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExpences);
            this.Controls.Add(this.btnCampus);
            this.Controls.Add(this.btnCertificates);
            this.Controls.Add(this.btnFees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnAdmission);
            this.Controls.Add(this.btnEnquiry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::I_SMS_MAIN::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEnquiry;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnFees;
        private System.Windows.Forms.Button btnCertificates;
        private System.Windows.Forms.Button btnCampus;
        private System.Windows.Forms.Button btnExpences;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWecUser;
    }
}