namespace ISMS_Project
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportPrint = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbxAddSalary = new System.Windows.Forms.GroupBox();
            this.cmbxSalMonth = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBankIfsc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBankAccNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNetSal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTransDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbxSalStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbxRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSrNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeduc = new System.Windows.Forms.TextBox();
            this.dtpDoj = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxBasSal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgrvSalaryInfo1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbxAddSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalaryInfo1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salary";
            // 
            // btnReportPrint
            // 
            this.btnReportPrint.AutoSize = true;
            this.btnReportPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnReportPrint.Image")));
            this.btnReportPrint.Location = new System.Drawing.Point(620, 28);
            this.btnReportPrint.Name = "btnReportPrint";
            this.btnReportPrint.Size = new System.Drawing.Size(49, 41);
            this.btnReportPrint.TabIndex = 82;
            this.btnReportPrint.UseVisualStyleBackColor = true;
            this.btnReportPrint.Click += new System.EventHandler(this.btnReportPrint_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnExportData.Image")));
            this.btnExportData.Location = new System.Drawing.Point(565, 28);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(49, 40);
            this.btnExportData.TabIndex = 81;
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(423, 37);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(136, 23);
            this.txtSearchByName.TabIndex = 80;
            this.txtSearchByName.Visible = false;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(292, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 71;
            this.label12.Text = "Search By Name";
            this.label12.Visible = false;
            // 
            // grbxAddSalary
            // 
            this.grbxAddSalary.Controls.Add(this.cmbxSalMonth);
            this.grbxAddSalary.Controls.Add(this.label11);
            this.grbxAddSalary.Controls.Add(this.txtBankIfsc);
            this.grbxAddSalary.Controls.Add(this.label14);
            this.grbxAddSalary.Controls.Add(this.txtBankAccNo);
            this.grbxAddSalary.Controls.Add(this.label9);
            this.grbxAddSalary.Controls.Add(this.txtNetSal);
            this.grbxAddSalary.Controls.Add(this.label8);
            this.grbxAddSalary.Controls.Add(this.dtpTransDate);
            this.grbxAddSalary.Controls.Add(this.label15);
            this.grbxAddSalary.Controls.Add(this.cmbxSalStatus);
            this.grbxAddSalary.Controls.Add(this.label10);
            this.grbxAddSalary.Controls.Add(this.txtName);
            this.grbxAddSalary.Controls.Add(this.label13);
            this.grbxAddSalary.Controls.Add(this.cmbxRole);
            this.grbxAddSalary.Controls.Add(this.label2);
            this.grbxAddSalary.Controls.Add(this.label7);
            this.grbxAddSalary.Controls.Add(this.txtSrNo);
            this.grbxAddSalary.Controls.Add(this.label3);
            this.grbxAddSalary.Controls.Add(this.txtDeduc);
            this.grbxAddSalary.Controls.Add(this.dtpDoj);
            this.grbxAddSalary.Controls.Add(this.label6);
            this.grbxAddSalary.Controls.Add(this.label5);
            this.grbxAddSalary.Controls.Add(this.cmbxBasSal);
            this.grbxAddSalary.Controls.Add(this.label4);
            this.grbxAddSalary.Location = new System.Drawing.Point(127, 84);
            this.grbxAddSalary.Name = "grbxAddSalary";
            this.grbxAddSalary.Size = new System.Drawing.Size(400, 445);
            this.grbxAddSalary.TabIndex = 68;
            this.grbxAddSalary.TabStop = false;
            // 
            // cmbxSalMonth
            // 
            this.cmbxSalMonth.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxSalMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSalMonth.FormattingEnabled = true;
            this.cmbxSalMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbxSalMonth.Location = new System.Drawing.Point(172, 350);
            this.cmbxSalMonth.Name = "cmbxSalMonth";
            this.cmbxSalMonth.Size = new System.Drawing.Size(215, 24);
            this.cmbxSalMonth.TabIndex = 77;
            this.cmbxSalMonth.Text = "--Select--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(44, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Salary Month";
            // 
            // txtBankIfsc
            // 
            this.txtBankIfsc.BackColor = System.Drawing.SystemColors.Info;
            this.txtBankIfsc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankIfsc.Location = new System.Drawing.Point(172, 321);
            this.txtBankIfsc.Name = "txtBankIfsc";
            this.txtBankIfsc.Size = new System.Drawing.Size(215, 23);
            this.txtBankIfsc.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 16);
            this.label14.TabIndex = 56;
            this.label14.Text = "Bank IFSC";
            // 
            // txtBankAccNo
            // 
            this.txtBankAccNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtBankAccNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAccNo.Location = new System.Drawing.Point(172, 292);
            this.txtBankAccNo.Name = "txtBankAccNo";
            this.txtBankAccNo.Size = new System.Drawing.Size(215, 23);
            this.txtBankAccNo.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Bank A/c No.";
            // 
            // txtNetSal
            // 
            this.txtNetSal.BackColor = System.Drawing.SystemColors.Info;
            this.txtNetSal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetSal.Location = new System.Drawing.Point(172, 260);
            this.txtNetSal.Name = "txtNetSal";
            this.txtNetSal.Size = new System.Drawing.Size(215, 23);
            this.txtNetSal.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Net Salary";
            // 
            // dtpTransDate
            // 
            this.dtpTransDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransDate.Location = new System.Drawing.Point(172, 381);
            this.dtpTransDate.Name = "dtpTransDate";
            this.dtpTransDate.Size = new System.Drawing.Size(130, 23);
            this.dtpTransDate.TabIndex = 78;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "Date";
            // 
            // cmbxSalStatus
            // 
            this.cmbxSalStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxSalStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSalStatus.FormattingEnabled = true;
            this.cmbxSalStatus.Items.AddRange(new object[] {
            "Cerdited",
            "Not Cerdited",
            "On Hold"});
            this.cmbxSalStatus.Location = new System.Drawing.Point(172, 409);
            this.cmbxSalStatus.Name = "cmbxSalStatus";
            this.cmbxSalStatus.Size = new System.Drawing.Size(215, 24);
            this.cmbxSalStatus.TabIndex = 79;
            this.cmbxSalStatus.Text = "--Select--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Salary Status";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(172, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Name";
            // 
            // cmbxRole
            // 
            this.cmbxRole.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxRole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxRole.FormattingEnabled = true;
            this.cmbxRole.Items.AddRange(new object[] {
            "Trainer/Faculty",
            "Other"});
            this.cmbxRole.Location = new System.Drawing.Point(173, 143);
            this.cmbxRole.Name = "cmbxRole";
            this.cmbxRole.Size = new System.Drawing.Size(215, 24);
            this.cmbxRole.TabIndex = 71;
            this.cmbxRole.Text = "--Select--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Role";
            // 
            // txtSrNo
            // 
            this.txtSrNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtSrNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrNo.Location = new System.Drawing.Point(173, 49);
            this.txtSrNo.Name = "txtSrNo";
            this.txtSrNo.Size = new System.Drawing.Size(215, 23);
            this.txtSrNo.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sr.No";
            // 
            // txtDeduc
            // 
            this.txtDeduc.BackColor = System.Drawing.SystemColors.Info;
            this.txtDeduc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeduc.Location = new System.Drawing.Point(172, 216);
            this.txtDeduc.Name = "txtDeduc";
            this.txtDeduc.Size = new System.Drawing.Size(215, 23);
            this.txtDeduc.TabIndex = 73;
            this.txtDeduc.TextChanged += new System.EventHandler(this.txtDeduc_TextChanged);
            // 
            // dtpDoj
            // 
            this.dtpDoj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoj.Location = new System.Drawing.Point(172, 108);
            this.dtpDoj.Name = "dtpDoj";
            this.dtpDoj.Size = new System.Drawing.Size(215, 23);
            this.dtpDoj.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Joining Date";
            // 
            // cmbxBasSal
            // 
            this.cmbxBasSal.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxBasSal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxBasSal.FormattingEnabled = true;
            this.cmbxBasSal.Items.AddRange(new object[] {
            "5000",
            "6000",
            "7000",
            "8000",
            "10000",
            "20000"});
            this.cmbxBasSal.Location = new System.Drawing.Point(172, 180);
            this.cmbxBasSal.Name = "cmbxBasSal";
            this.cmbxBasSal.Size = new System.Drawing.Size(215, 24);
            this.cmbxBasSal.TabIndex = 72;
            this.cmbxBasSal.Text = "--Select--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Deduction";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(28, 431);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 67;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(28, 307);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btnSearch, "Search-Export");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(28, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Not Allowed.");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(28, 245);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(28, 185);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 54);
            this.btnView.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnView, "View");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(28, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 56);
            this.btnSave.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(28, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 56);
            this.btnAddNew.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnAddNew, "Add New ");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgrvSalaryInfo1
            // 
            this.dgrvSalaryInfo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvSalaryInfo1.Location = new System.Drawing.Point(117, 84);
            this.dgrvSalaryInfo1.Name = "dgrvSalaryInfo1";
            this.dgrvSalaryInfo1.Size = new System.Drawing.Size(1187, 513);
            this.dgrvSalaryInfo1.TabIndex = 83;
            this.dgrvSalaryInfo1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvSalaryInfo1_RowHeaderMouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 541);
            this.Controls.Add(this.dgrvSalaryInfo1);
            this.Controls.Add(this.btnReportPrint);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbxAddSalary);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form19";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalary_Load);
            this.grbxAddSalary.ResumeLayout(false);
            this.grbxAddSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvSalaryInfo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportPrint;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbxAddSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTransDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbxSalStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbxRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSrNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeduc;
        private System.Windows.Forms.DateTimePicker dtpDoj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxBasSal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgrvSalaryInfo1;
        private System.Windows.Forms.TextBox txtBankIfsc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBankAccNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNetSal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbxSalMonth;
        private System.Windows.Forms.Label label11;
    }
}