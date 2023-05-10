namespace ISMS_Project
{
    partial class frmTeachers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeachers));
            this.dgrvTeachers = new System.Windows.Forms.DataGridView();
            this.grbxTeachers = new System.Windows.Forms.GroupBox();
            this.txtTeachAdd = new System.Windows.Forms.TextBox();
            this.txtTechMobile = new System.Windows.Forms.TextBox();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeachID = new System.Windows.Forms.TextBox();
            this.cmbbxTechSal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbxTechSub = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxTechQual = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).BeginInit();
            this.grbxTeachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrvTeachers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrvTeachers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrvTeachers.Location = new System.Drawing.Point(124, 62);
            this.dgrvTeachers.Name = "dgrvTeachers";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrvTeachers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrvTeachers.Size = new System.Drawing.Size(884, 446);
            this.dgrvTeachers.TabIndex = 30;
            this.dgrvTeachers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvTeachers_RowHeaderMouseDoubleClick);
            // 
            // grbxTeachers
            // 
            this.grbxTeachers.Controls.Add(this.txtTeachAdd);
            this.grbxTeachers.Controls.Add(this.txtTechMobile);
            this.grbxTeachers.Controls.Add(this.txtTechName);
            this.grbxTeachers.Controls.Add(this.label9);
            this.grbxTeachers.Controls.Add(this.label8);
            this.grbxTeachers.Controls.Add(this.label7);
            this.grbxTeachers.Controls.Add(this.txtTeachID);
            this.grbxTeachers.Controls.Add(this.cmbbxTechSal);
            this.grbxTeachers.Controls.Add(this.label2);
            this.grbxTeachers.Controls.Add(this.cmbbxTechSub);
            this.grbxTeachers.Controls.Add(this.label3);
            this.grbxTeachers.Controls.Add(this.cmbbxTechQual);
            this.grbxTeachers.Controls.Add(this.label4);
            this.grbxTeachers.Controls.Add(this.label5);
            this.grbxTeachers.Controls.Add(this.label6);
            this.grbxTeachers.Location = new System.Drawing.Point(153, 62);
            this.grbxTeachers.Name = "grbxTeachers";
            this.grbxTeachers.Size = new System.Drawing.Size(513, 417);
            this.grbxTeachers.TabIndex = 29;
            this.grbxTeachers.TabStop = false;
            // 
            // txtTeachAdd
            // 
            this.txtTeachAdd.BackColor = System.Drawing.SystemColors.Info;
            this.txtTeachAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachAdd.Location = new System.Drawing.Point(152, 287);
            this.txtTeachAdd.Multiline = true;
            this.txtTeachAdd.Name = "txtTeachAdd";
            this.txtTeachAdd.Size = new System.Drawing.Size(252, 67);
            this.txtTeachAdd.TabIndex = 19;
            // 
            // txtTechMobile
            // 
            this.txtTechMobile.BackColor = System.Drawing.SystemColors.Info;
            this.txtTechMobile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechMobile.Location = new System.Drawing.Point(152, 252);
            this.txtTechMobile.MaxLength = 10;
            this.txtTechMobile.Name = "txtTechMobile";
            this.txtTechMobile.Size = new System.Drawing.Size(252, 23);
            this.txtTechMobile.TabIndex = 18;
            // 
            // txtTechName
            // 
            this.txtTechName.BackColor = System.Drawing.SystemColors.Info;
            this.txtTechName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechName.Location = new System.Drawing.Point(152, 91);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(252, 23);
            this.txtTechName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salary";
            // 
            // txtTeachID
            // 
            this.txtTeachID.BackColor = System.Drawing.SystemColors.Info;
            this.txtTeachID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeachID.Location = new System.Drawing.Point(152, 52);
            this.txtTeachID.Name = "txtTeachID";
            this.txtTeachID.Size = new System.Drawing.Size(252, 23);
            this.txtTeachID.TabIndex = 13;
            // 
            // cmbbxTechSal
            // 
            this.cmbbxTechSal.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxTechSal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTechSal.FormattingEnabled = true;
            this.cmbbxTechSal.Items.AddRange(new object[] {
            "4000",
            "5000",
            "15000",
            "10000",
            "25000",
            "300000"});
            this.cmbbxTechSal.Location = new System.Drawing.Point(152, 212);
            this.cmbbxTechSal.Name = "cmbbxTechSal";
            this.cmbbxTechSal.Size = new System.Drawing.Size(252, 24);
            this.cmbbxTechSal.TabIndex = 17;
            this.cmbbxTechSal.Text = "--Select--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Teacher:";
            // 
            // cmbbxTechSub
            // 
            this.cmbbxTechSub.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxTechSub.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTechSub.FormattingEnabled = true;
            this.cmbbxTechSub.Items.AddRange(new object[] {
            "C ",
            "C++",
            "Core Java",
            "Adv Java",
            "DS",
            ".NET",
            "PHP",
            "Python"});
            this.cmbbxTechSub.Location = new System.Drawing.Point(152, 170);
            this.cmbbxTechSub.Name = "cmbbxTechSub";
            this.cmbbxTechSub.Size = new System.Drawing.Size(252, 24);
            this.cmbbxTechSub.TabIndex = 16;
            this.cmbbxTechSub.Text = "--Select--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teacher ID";
            // 
            // cmbbxTechQual
            // 
            this.cmbbxTechQual.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxTechQual.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTechQual.FormattingEnabled = true;
            this.cmbbxTechQual.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BSC",
            "MSC",
            "BE(IT/CS)",
            "ME(IT/CS)",
            "Graduate IT",
            "Post Graduate IT"});
            this.cmbbxTechQual.Location = new System.Drawing.Point(152, 131);
            this.cmbbxTechQual.Name = "cmbbxTechQual";
            this.cmbbxTechQual.Size = new System.Drawing.Size(252, 24);
            this.cmbbxTechQual.TabIndex = 15;
            this.cmbbxTechQual.Text = "--Select--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qualification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subject";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(30, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(30, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(30, 297);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(30, 234);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(30, 171);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(54, 54);
            this.btnView.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnView, "View");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(30, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.AutoSize = true;
            this.btnAddTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTeacher.Image")));
            this.btnAddTeacher.Location = new System.Drawing.Point(30, 45);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(56, 56);
            this.btnAddTeacher.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnAddTeacher, "Add Teacher");
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Teachers";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(473, 24);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(189, 23);
            this.txtSearchByName.TabIndex = 32;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Search By Name";
            // 
            // frmTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 535);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgrvTeachers);
            this.Controls.Add(this.grbxTeachers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTeachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvTeachers)).EndInit();
            this.grbxTeachers.ResumeLayout(false);
            this.grbxTeachers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvTeachers;
        private System.Windows.Forms.GroupBox grbxTeachers;
        private System.Windows.Forms.TextBox txtTeachID;
        private System.Windows.Forms.ComboBox cmbbxTechSal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbxTechSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxTechQual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeachAdd;
        private System.Windows.Forms.TextBox txtTechMobile;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label10;
    }
}