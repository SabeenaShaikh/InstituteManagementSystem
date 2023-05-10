namespace ISMS_Project
{
    partial class frmCertificates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificates));
            this.btnExportData = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grbxAddCerti = new System.Windows.Forms.GroupBox();
            this.cmbxInstitute = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCertNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxCourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxDuration = new System.Windows.Forms.ComboBox();
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
            this.btnCertiPrint = new System.Windows.Forms.Button();
            this.dgrvCertInfo1 = new System.Windows.Forms.DataGridView();
            this.grbxAddCerti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCertInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnExportData.Image")));
            this.btnExportData.Location = new System.Drawing.Point(764, 29);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(41, 40);
            this.btnExportData.TabIndex = 45;
            this.toolTip1.SetToolTip(this.btnExportData, "Export Data");
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(623, 39);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(127, 23);
            this.txtSearchByName.TabIndex = 44;
            this.txtSearchByName.Visible = false;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(490, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Search By Name";
            this.label12.Visible = false;
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(341, 38);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(127, 23);
            this.txtSearchByID.TabIndex = 42;
            this.txtSearchByID.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Search By ID";
            this.label11.Visible = false;
            // 
            // grbxAddCerti
            // 
            this.grbxAddCerti.Controls.Add(this.cmbxInstitute);
            this.grbxAddCerti.Controls.Add(this.label8);
            this.grbxAddCerti.Controls.Add(this.dtpIssueDate);
            this.grbxAddCerti.Controls.Add(this.label15);
            this.grbxAddCerti.Controls.Add(this.dtpTo);
            this.grbxAddCerti.Controls.Add(this.cmbxStatus);
            this.grbxAddCerti.Controls.Add(this.label14);
            this.grbxAddCerti.Controls.Add(this.label10);
            this.grbxAddCerti.Controls.Add(this.txtCertNo);
            this.grbxAddCerti.Controls.Add(this.label13);
            this.grbxAddCerti.Controls.Add(this.cmbxCourse);
            this.grbxAddCerti.Controls.Add(this.label2);
            this.grbxAddCerti.Controls.Add(this.label7);
            this.grbxAddCerti.Controls.Add(this.txtStudID);
            this.grbxAddCerti.Controls.Add(this.label3);
            this.grbxAddCerti.Controls.Add(this.txtStudName);
            this.grbxAddCerti.Controls.Add(this.dtpFrom);
            this.grbxAddCerti.Controls.Add(this.label6);
            this.grbxAddCerti.Controls.Add(this.label5);
            this.grbxAddCerti.Controls.Add(this.cmbxDuration);
            this.grbxAddCerti.Controls.Add(this.label4);
            this.grbxAddCerti.Location = new System.Drawing.Point(122, 81);
            this.grbxAddCerti.Name = "grbxAddCerti";
            this.grbxAddCerti.Size = new System.Drawing.Size(409, 461);
            this.grbxAddCerti.TabIndex = 40;
            this.grbxAddCerti.TabStop = false;
            // 
            // cmbxInstitute
            // 
            this.cmbxInstitute.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxInstitute.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxInstitute.FormattingEnabled = true;
            this.cmbxInstitute.Items.AddRange(new object[] {
            "DISHA COMPUTER KALEWADI PUNE",
            "OTHER INSTITUTE"});
            this.cmbxInstitute.Location = new System.Drawing.Point(168, 297);
            this.cmbxInstitute.Name = "cmbxInstitute";
            this.cmbxInstitute.Size = new System.Drawing.Size(215, 24);
            this.cmbxInstitute.TabIndex = 53;
            this.cmbxInstitute.Text = "--Select--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Institute";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(168, 336);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(130, 23);
            this.dtpIssueDate.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(42, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "Date of Issue";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(168, 257);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(215, 23);
            this.dtpTo.TabIndex = 49;
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Items.AddRange(new object[] {
            "Completed",
            "Not Completed",
            "Finish Within 2 Weeks",
            "Finish Within 1 Week"});
            this.cmbxStatus.Location = new System.Drawing.Point(168, 373);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(215, 24);
            this.cmbxStatus.TabIndex = 49;
            this.cmbxStatus.Text = "--Select--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "To";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Status";
            // 
            // txtCertNo
            // 
            this.txtCertNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCertNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertNo.Location = new System.Drawing.Point(168, 84);
            this.txtCertNo.Name = "txtCertNo";
            this.txtCertNo.Size = new System.Drawing.Size(215, 23);
            this.txtCertNo.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Certificate No.";
            // 
            // cmbxCourse
            // 
            this.cmbxCourse.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCourse.FormattingEnabled = true;
            this.cmbxCourse.Items.AddRange(new object[] {
            "--Select--",
            "C",
            "C++",
            "Core Java",
            "Adv Java",
            "DS",
            ".NET",
            "PHP",
            "Python"});
            this.cmbxCourse.Location = new System.Drawing.Point(169, 148);
            this.cmbxCourse.Name = "cmbxCourse";
            this.cmbxCourse.Size = new System.Drawing.Size(215, 24);
            this.cmbxCourse.TabIndex = 21;
            this.cmbxCourse.Text = "--Select--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Certificate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Course";
            // 
            // txtStudID
            // 
            this.txtStudID.BackColor = System.Drawing.SystemColors.Info;
            this.txtStudID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudID.Location = new System.Drawing.Point(169, 54);
            this.txtStudID.Name = "txtStudID";
            this.txtStudID.Size = new System.Drawing.Size(215, 23);
            this.txtStudID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student ID";
            // 
            // txtStudName
            // 
            this.txtStudName.BackColor = System.Drawing.SystemColors.Info;
            this.txtStudName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudName.Location = new System.Drawing.Point(169, 115);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(215, 23);
            this.txtStudName.TabIndex = 19;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(168, 224);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(215, 23);
            this.dtpFrom.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // cmbxDuration
            // 
            this.cmbxDuration.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxDuration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDuration.FormattingEnabled = true;
            this.cmbxDuration.Items.AddRange(new object[] {
            "1 Month",
            "2 Months",
            "3 Months",
            "4 Months",
            "6 Months"});
            this.cmbxDuration.Location = new System.Drawing.Point(168, 185);
            this.cmbxDuration.Name = "cmbxDuration";
            this.cmbxDuration.Size = new System.Drawing.Size(215, 24);
            this.cmbxDuration.TabIndex = 20;
            this.cmbxDuration.Text = "--Select--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "From";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(35, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 39;
            this.toolTip1.SetToolTip(this.btnClose, "Close Window");
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
            this.toolTip1.SetToolTip(this.btnSearch, "Search");
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
            this.toolTip1.SetToolTip(this.btnAddNew, "Add New Certificate");
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
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Certificates";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnCertiPrint
            // 
            this.btnCertiPrint.AutoSize = true;
            this.btnCertiPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnCertiPrint.Image")));
            this.btnCertiPrint.Location = new System.Drawing.Point(811, 28);
            this.btnCertiPrint.Name = "btnCertiPrint";
            this.btnCertiPrint.Size = new System.Drawing.Size(41, 41);
            this.btnCertiPrint.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnCertiPrint, "Print Certificate");
            this.btnCertiPrint.UseVisualStyleBackColor = true;
            this.btnCertiPrint.Click += new System.EventHandler(this.btnCertiPrint_Click);
            // 
            // dgrvCertInfo1
            // 
            this.dgrvCertInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvCertInfo1.Location = new System.Drawing.Point(122, 75);
            this.dgrvCertInfo1.Name = "dgrvCertInfo1";
            this.dgrvCertInfo1.Size = new System.Drawing.Size(1045, 459);
            this.dgrvCertInfo1.TabIndex = 46;
            this.dgrvCertInfo1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvCertInfo1_RowHeaderMouseDoubleClick);
            // 
            // frmCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 586);
            this.Controls.Add(this.btnCertiPrint);
            this.Controls.Add(this.dgrvCertInfo1);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grbxAddCerti);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "frmCertificates";
            this.Text = "Form11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCertificates_Load);
            this.grbxAddCerti.ResumeLayout(false);
            this.grbxAddCerti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvCertInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grbxAddCerti;
        private System.Windows.Forms.ComboBox cmbxCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbxInstitute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCertNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgrvCertInfo1;
        private System.Windows.Forms.Button btnCertiPrint;

    }
}