namespace ISMS_Project
{
    partial class frmCampus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampus));
            this.btnExportData = new System.Windows.Forms.Button();
            this.txtSearchByCompany = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbxAddCamp = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxSal = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxRole = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxJobLoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpCamp = new System.Windows.Forms.DateTimePicker();
            this.txtCampID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxCompany = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgrvCampInfo = new System.Windows.Forms.DataGridView();
            this.grbxAddCamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCampInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnExportData.Image")));
            this.btnExportData.Location = new System.Drawing.Point(719, 18);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(41, 40);
            this.btnExportData.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btnExportData, "Export Data");
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // txtSearchByCompany
            // 
            this.txtSearchByCompany.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByCompany.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByCompany.Location = new System.Drawing.Point(576, 27);
            this.txtSearchByCompany.Name = "txtSearchByCompany";
            this.txtSearchByCompany.Size = new System.Drawing.Size(137, 23);
            this.txtSearchByCompany.TabIndex = 44;
            this.txtSearchByCompany.Visible = false;
            this.txtSearchByCompany.TextChanged += new System.EventHandler(this.txtSearchByCompany_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(416, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Search By Company";
            this.label12.Visible = false;
            // 
            // grbxAddCamp
            // 
            this.grbxAddCamp.Controls.Add(this.label5);
            this.grbxAddCamp.Controls.Add(this.cmbxSal);
            this.grbxAddCamp.Controls.Add(this.label13);
            this.grbxAddCamp.Controls.Add(this.cmbxRole);
            this.grbxAddCamp.Controls.Add(this.label11);
            this.grbxAddCamp.Controls.Add(this.cmbxJobLoc);
            this.grbxAddCamp.Controls.Add(this.label8);
            this.grbxAddCamp.Controls.Add(this.label2);
            this.grbxAddCamp.Controls.Add(this.txtAddress);
            this.grbxAddCamp.Controls.Add(this.cmbxStatus);
            this.grbxAddCamp.Controls.Add(this.dtpCamp);
            this.grbxAddCamp.Controls.Add(this.txtCampID);
            this.grbxAddCamp.Controls.Add(this.label3);
            this.grbxAddCamp.Controls.Add(this.label10);
            this.grbxAddCamp.Controls.Add(this.label6);
            this.grbxAddCamp.Controls.Add(this.cmbxCompany);
            this.grbxAddCamp.Controls.Add(this.label4);
            this.grbxAddCamp.Location = new System.Drawing.Point(114, 67);
            this.grbxAddCamp.Name = "grbxAddCamp";
            this.grbxAddCamp.Size = new System.Drawing.Size(466, 461);
            this.grbxAddCamp.TabIndex = 40;
            this.grbxAddCamp.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Job Location";
            // 
            // cmbxSal
            // 
            this.cmbxSal.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxSal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSal.FormattingEnabled = true;
            this.cmbxSal.Items.AddRange(new object[] {
            "10000",
            "20000",
            "15000",
            "25000",
            "30000",
            "45000",
            "\t\t\t"});
            this.cmbxSal.Location = new System.Drawing.Point(169, 295);
            this.cmbxSal.Name = "cmbxSal";
            this.cmbxSal.Size = new System.Drawing.Size(215, 24);
            this.cmbxSal.TabIndex = 23;
            this.cmbxSal.Text = "--Select--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Salary";
            // 
            // cmbxRole
            // 
            this.cmbxRole.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxRole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRole.FormattingEnabled = true;
            this.cmbxRole.Items.AddRange(new object[] {
            ".Net Developer",
            "Java Developer",
            "Php Developer",
            "Sql Developer",
            "Fresher",
            "",
            ""});
            this.cmbxRole.Location = new System.Drawing.Point(169, 265);
            this.cmbxRole.Name = "cmbxRole";
            this.cmbxRole.Size = new System.Drawing.Size(215, 24);
            this.cmbxRole.TabIndex = 22;
            this.cmbxRole.Text = "--Select--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Role";
            // 
            // cmbxJobLoc
            // 
            this.cmbxJobLoc.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxJobLoc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxJobLoc.FormattingEnabled = true;
            this.cmbxJobLoc.Items.AddRange(new object[] {
            "Pune",
            "Mumbai",
            "Hydrabad"});
            this.cmbxJobLoc.Location = new System.Drawing.Point(169, 235);
            this.cmbxJobLoc.Name = "cmbxJobLoc";
            this.cmbxJobLoc.Size = new System.Drawing.Size(215, 24);
            this.cmbxJobLoc.TabIndex = 21;
            this.cmbxJobLoc.Text = "--Select--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Campus:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(169, 168);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 57);
            this.txtAddress.TabIndex = 20;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Not Confirmed",
            "Posponded"});
            this.cmbxStatus.Location = new System.Drawing.Point(169, 339);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(215, 24);
            this.cmbxStatus.TabIndex = 24;
            this.cmbxStatus.Text = "--Select--";
            // 
            // dtpCamp
            // 
            this.dtpCamp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCamp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCamp.Location = new System.Drawing.Point(169, 95);
            this.dtpCamp.Name = "dtpCamp";
            this.dtpCamp.Size = new System.Drawing.Size(215, 23);
            this.dtpCamp.TabIndex = 18;
            // 
            // txtCampID
            // 
            this.txtCampID.BackColor = System.Drawing.SystemColors.Info;
            this.txtCampID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCampID.Location = new System.Drawing.Point(169, 54);
            this.txtCampID.Name = "txtCampID";
            this.txtCampID.Size = new System.Drawing.Size(215, 23);
            this.txtCampID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Campus ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Company";
            // 
            // cmbxCompany
            // 
            this.cmbxCompany.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxCompany.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCompany.FormattingEnabled = true;
            this.cmbxCompany.Items.AddRange(new object[] {
            "BitWise Inc.",
            "Wipro",
            "TCS",
            "Accenture",
            "Fujitsu",
            "Capgemini",
            "Syntel\t\t"});
            this.cmbxCompany.Location = new System.Drawing.Point(169, 138);
            this.cmbxCompany.Name = "cmbxCompany";
            this.cmbxCompany.Size = new System.Drawing.Size(215, 24);
            this.cmbxCompany.TabIndex = 19;
            this.cmbxCompany.Text = "--Select--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(35, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(35, 297);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnSearch, "Search-Export");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(35, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(35, 235);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(35, 175);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 54);
            this.btnView.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnView, "View");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(35, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(35, 51);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 56);
            this.btnAddNew.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnAddNew, "New Campus");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Campus";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dgrvCampInfo
            // 
            this.dgrvCampInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCampInfo.Location = new System.Drawing.Point(114, 67);
            this.dgrvCampInfo.Name = "dgrvCampInfo";
            this.dgrvCampInfo.Size = new System.Drawing.Size(950, 363);
            this.dgrvCampInfo.TabIndex = 46;
            this.dgrvCampInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvCampInfo_RowHeaderMouseDoubleClick);
            // 
            // frmCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 556);
            this.Controls.Add(this.dgrvCampInfo);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtSearchByCompany);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbxAddCamp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "frmCampus";
            this.Text = "Form12";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCampus_Load);
            this.grbxAddCamp.ResumeLayout(false);
            this.grbxAddCamp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCampInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.TextBox txtSearchByCompany;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbxAddCamp;
        private System.Windows.Forms.ComboBox cmbxJobLoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.DateTimePicker dtpCamp;
        private System.Windows.Forms.TextBox txtCampID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbxSal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxRole;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgrvCampInfo;
        private System.Windows.Forms.Label label5;
    }
}