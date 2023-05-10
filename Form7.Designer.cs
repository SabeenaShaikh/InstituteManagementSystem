namespace ISMS_Project
{
    partial class frmCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCrsID = new System.Windows.Forms.TextBox();
            this.cmbbxCrsName = new System.Windows.Forms.ComboBox();
            this.cmbbxCrsDur = new System.Windows.Forms.ComboBox();
            this.cmbbxCrsFees = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbxCourses = new System.Windows.Forms.GroupBox();
            this.dgrvCourses = new System.Windows.Forms.DataGridView();
            this.txtSearchByCourse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbxCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Courses";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.AutoSize = true;
            this.btnAddCourse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCourse.Image")));
            this.btnAddCourse.Location = new System.Drawing.Point(31, 56);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(56, 56);
            this.btnAddCourse.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAddCourse, "Add Course");
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(31, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(31, 182);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(54, 54);
            this.btnView.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnView, "View");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(31, 245);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(31, 308);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(31, 434);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(31, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Course ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fees";
            // 
            // txtCrsID
            // 
            this.txtCrsID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCrsID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrsID.Location = new System.Drawing.Point(165, 86);
            this.txtCrsID.Name = "txtCrsID";
            this.txtCrsID.Size = new System.Drawing.Size(147, 23);
            this.txtCrsID.TabIndex = 13;
            // 
            // cmbbxCrsName
            // 
            this.cmbbxCrsName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxCrsName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCrsName.FormattingEnabled = true;
            this.cmbbxCrsName.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Adv Java",
            ".Net",
            "SQL",
            "C#.NET",
            "ASP.NET",
            "ASP.NET MVC",
            "Python",
            "Adv Python",
            "Computer Basics",
            "MSCIT",
            "CCC",
            "HTML",
            "CSS",
            "AngularJS",
            "JavaScript"});
            this.cmbbxCrsName.Location = new System.Drawing.Point(165, 125);
            this.cmbbxCrsName.Name = "cmbbxCrsName";
            this.cmbbxCrsName.Size = new System.Drawing.Size(235, 24);
            this.cmbbxCrsName.TabIndex = 14;
            this.cmbbxCrsName.Text = "--Select--";
            // 
            // cmbbxCrsDur
            // 
            this.cmbbxCrsDur.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxCrsDur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCrsDur.FormattingEnabled = true;
            this.cmbbxCrsDur.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "6 Months",
            "12 Months"});
            this.cmbbxCrsDur.Location = new System.Drawing.Point(165, 162);
            this.cmbbxCrsDur.Name = "cmbbxCrsDur";
            this.cmbbxCrsDur.Size = new System.Drawing.Size(147, 24);
            this.cmbbxCrsDur.TabIndex = 15;
            this.cmbbxCrsDur.Text = "--Select--";
            // 
            // cmbbxCrsFees
            // 
            this.cmbbxCrsFees.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxCrsFees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCrsFees.FormattingEnabled = true;
            this.cmbbxCrsFees.Items.AddRange(new object[] {
            "500",
            "1000",
            "1200",
            "1500",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000",
            "25000",
            "300000"});
            this.cmbbxCrsFees.Location = new System.Drawing.Point(165, 204);
            this.cmbbxCrsFees.Name = "cmbbxCrsFees";
            this.cmbbxCrsFees.Size = new System.Drawing.Size(147, 24);
            this.cmbbxCrsFees.TabIndex = 16;
            this.cmbbxCrsFees.Text = "--Select--";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // grbxCourses
            // 
            this.grbxCourses.Controls.Add(this.txtCrsID);
            this.grbxCourses.Controls.Add(this.cmbbxCrsFees);
            this.grbxCourses.Controls.Add(this.label2);
            this.grbxCourses.Controls.Add(this.cmbbxCrsDur);
            this.grbxCourses.Controls.Add(this.label3);
            this.grbxCourses.Controls.Add(this.cmbbxCrsName);
            this.grbxCourses.Controls.Add(this.label4);
            this.grbxCourses.Controls.Add(this.label5);
            this.grbxCourses.Controls.Add(this.label6);
            this.grbxCourses.Location = new System.Drawing.Point(147, 82);
            this.grbxCourses.Name = "grbxCourses";
            this.grbxCourses.Size = new System.Drawing.Size(442, 362);
            this.grbxCourses.TabIndex = 19;
            this.grbxCourses.TabStop = false;
            // 
            // dgrvCourses
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvCourses.Location = new System.Drawing.Point(120, 82);
            this.dgrvCourses.Name = "dgrvCourses";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvCourses.Size = new System.Drawing.Size(833, 438);
            this.dgrvCourses.TabIndex = 20;
            this.dgrvCourses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvCourses_RowHeaderMouseDoubleClick);
            // 
            // txtSearchByCourse
            // 
            this.txtSearchByCourse.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByCourse.Location = new System.Drawing.Point(526, 42);
            this.txtSearchByCourse.Name = "txtSearchByCourse";
            this.txtSearchByCourse.Size = new System.Drawing.Size(147, 23);
            this.txtSearchByCourse.TabIndex = 22;
            this.txtSearchByCourse.TextChanged += new System.EventHandler(this.txtSearchByCourse_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search By Course";
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 532);
            this.Controls.Add(this.txtSearchByCourse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgrvCourses);
            this.Controls.Add(this.grbxCourses);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.grbxCourses.ResumeLayout(false);
            this.grbxCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCrsID;
        private System.Windows.Forms.ComboBox cmbbxCrsName;
        private System.Windows.Forms.ComboBox cmbbxCrsDur;
        private System.Windows.Forms.ComboBox cmbbxCrsFees;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grbxCourses;
        private System.Windows.Forms.DataGridView dgrvCourses;
        private System.Windows.Forms.TextBox txtSearchByCourse;
        private System.Windows.Forms.Label label7;
    }
}