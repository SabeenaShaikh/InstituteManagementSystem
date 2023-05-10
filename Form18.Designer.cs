namespace ISMS_Project
{
    partial class frmAttend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttend));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dtpAttDate = new System.Windows.Forms.DateTimePicker();
            this.txtAttID = new System.Windows.Forms.TextBox();
            this.cmbxAttendence = new System.Windows.Forms.ComboBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbxAttend = new System.Windows.Forms.GroupBox();
            this.txtAttName = new System.Windows.Forms.TextBox();
            this.cmbxAttBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxMemberType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrvAttendInfo1 = new System.Windows.Forms.DataGridView();
            this.grbxAttend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAttendInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendence";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(524, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(54, 40);
            this.btnExport.TabIndex = 89;
            this.toolTip1.SetToolTip(this.btnExport, "Export Data");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(47, 291);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 52);
            this.btnSearch.TabIndex = 80;
            this.toolTip1.SetToolTip(this.btnSearch, "Search User");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(48, 349);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 52);
            this.btnClose.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnClose, "Delete User");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(47, 236);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(48, 52);
            this.btnEdit.TabIndex = 79;
            this.toolTip1.SetToolTip(this.btnEdit, "EditUpdate");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(47, 192);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(48, 52);
            this.btnView.TabIndex = 78;
            this.toolTip1.SetToolTip(this.btnView, "View Users");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(47, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 52);
            this.btnSave.TabIndex = 77;
            this.toolTip1.SetToolTip(this.btnSave, "Save User");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(47, 89);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 52);
            this.btnNew.TabIndex = 76;
            this.toolTip1.SetToolTip(this.btnNew, "Add New User");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtpAttDate
            // 
            this.dtpAttDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAttDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAttDate.Location = new System.Drawing.Point(142, 165);
            this.dtpAttDate.Name = "dtpAttDate";
            this.dtpAttDate.Size = new System.Drawing.Size(165, 21);
            this.dtpAttDate.TabIndex = 85;
            // 
            // txtAttID
            // 
            this.txtAttID.BackColor = System.Drawing.SystemColors.Info;
            this.txtAttID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttID.Location = new System.Drawing.Point(142, 54);
            this.txtAttID.Name = "txtAttID";
            this.txtAttID.Size = new System.Drawing.Size(165, 21);
            this.txtAttID.TabIndex = 82;
            // 
            // cmbxAttendence
            // 
            this.cmbxAttendence.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxAttendence.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAttendence.FormattingEnabled = true;
            this.cmbxAttendence.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Leave"});
            this.cmbxAttendence.Location = new System.Drawing.Point(142, 127);
            this.cmbxAttendence.Name = "cmbxAttendence";
            this.cmbxAttendence.Size = new System.Drawing.Size(165, 21);
            this.cmbxAttendence.TabIndex = 84;
            this.cmbxAttendence.Text = "--Select--";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(367, 45);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(141, 22);
            this.txtSearchByName.TabIndex = 88;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(249, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 14);
            this.label26.TabIndex = 65;
            this.label26.Text = "Search By Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 14);
            this.label2.TabIndex = 69;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 71;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 14);
            this.label4.TabIndex = 72;
            this.label4.Text = "Attendence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 73;
            this.label5.Text = "Date";
            // 
            // grbxAttend
            // 
            this.grbxAttend.Controls.Add(this.txtAttName);
            this.grbxAttend.Controls.Add(this.cmbxAttBy);
            this.grbxAttend.Controls.Add(this.label8);
            this.grbxAttend.Controls.Add(this.cmbxMemberType);
            this.grbxAttend.Controls.Add(this.label7);
            this.grbxAttend.Controls.Add(this.label6);
            this.grbxAttend.Controls.Add(this.label5);
            this.grbxAttend.Controls.Add(this.cmbxAttendence);
            this.grbxAttend.Controls.Add(this.label4);
            this.grbxAttend.Controls.Add(this.txtAttID);
            this.grbxAttend.Controls.Add(this.label3);
            this.grbxAttend.Controls.Add(this.dtpAttDate);
            this.grbxAttend.Controls.Add(this.label2);
            this.grbxAttend.Location = new System.Drawing.Point(152, 112);
            this.grbxAttend.Name = "grbxAttend";
            this.grbxAttend.Size = new System.Drawing.Size(441, 322);
            this.grbxAttend.TabIndex = 74;
            this.grbxAttend.TabStop = false;
            // 
            // txtAttName
            // 
            this.txtAttName.BackColor = System.Drawing.SystemColors.Info;
            this.txtAttName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttName.Location = new System.Drawing.Point(142, 90);
            this.txtAttName.Name = "txtAttName";
            this.txtAttName.Size = new System.Drawing.Size(165, 21);
            this.txtAttName.TabIndex = 83;
            // 
            // cmbxAttBy
            // 
            this.cmbxAttBy.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxAttBy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAttBy.FormattingEnabled = true;
            this.cmbxAttBy.Items.AddRange(new object[] {
            "admin",
            "sabeena",
            "shivani"});
            this.cmbxAttBy.Location = new System.Drawing.Point(142, 253);
            this.cmbxAttBy.Name = "cmbxAttBy";
            this.cmbxAttBy.Size = new System.Drawing.Size(165, 21);
            this.cmbxAttBy.TabIndex = 87;
            this.cmbxAttBy.Text = "--Select--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 14);
            this.label8.TabIndex = 87;
            this.label8.Text = "Attend. By";
            // 
            // cmbxMemberType
            // 
            this.cmbxMemberType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxMemberType.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMemberType.FormattingEnabled = true;
            this.cmbxMemberType.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Other"});
            this.cmbxMemberType.Location = new System.Drawing.Point(142, 210);
            this.cmbxMemberType.Name = "cmbxMemberType";
            this.cmbxMemberType.Size = new System.Drawing.Size(165, 21);
            this.cmbxMemberType.TabIndex = 86;
            this.cmbxMemberType.Text = "--Select--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 75;
            this.label7.Text = "Member Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Add Attendence:";
            // 
            // dgrvAttendInfo1
            // 
            this.dgrvAttendInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvAttendInfo1.Location = new System.Drawing.Point(128, 89);
            this.dgrvAttendInfo1.Name = "dgrvAttendInfo1";
            this.dgrvAttendInfo1.Size = new System.Drawing.Size(934, 411);
            this.dgrvAttendInfo1.TabIndex = 91;
            this.dgrvAttendInfo1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvAttendInfo1_RowHeaderMouseDoubleClick);
            // 
            // frmAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 531);
            this.Controls.Add(this.dgrvAttendInfo1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grbxAttend);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form18";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAttend_Load);
            this.grbxAttend.ResumeLayout(false);
            this.grbxAttend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvAttendInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpAttDate;
        private System.Windows.Forms.TextBox txtAttID;
        private System.Windows.Forms.ComboBox cmbxAttendence;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbxAttend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbxMemberType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxAttBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgrvAttendInfo1;
        private System.Windows.Forms.TextBox txtAttName;
    }
}