namespace ISMS_Project
{
    partial class frmEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnquiry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExportData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnqNo = new System.Windows.Forms.TextBox();
            this.dtpEnq = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbboxQuali = new System.Windows.Forms.ComboBox();
            this.txtForCourses = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cmbboxStatus = new System.Windows.Forms.ComboBox();
            this.grbxAddEnq = new System.Windows.Forms.GroupBox();
            this.cmbbxForCourse = new System.Windows.Forms.ComboBox();
            this.dgrdviewEnq = new System.Windows.Forms.DataGridView();
            this.dB_StudentDataSet = new ISMS_Project.DB_StudentDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grbxAddEnq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdviewEnq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enquiry";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(23, 48);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 56);
            this.btnAddNew.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAddNew, "Add New");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(23, 110);
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
            this.btnView.Location = new System.Drawing.Point(23, 172);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 54);
            this.btnView.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnView, "Show");
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(23, 232);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(23, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(23, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSearch, "Search-Export");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(23, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Enquiry:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnExportData.Image")));
            this.btnExportData.Location = new System.Drawing.Point(865, 8);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(41, 40);
            this.btnExportData.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnExportData, "Export Data");
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enquiry No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Qualification";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "For Courses";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Contact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(70, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Status";
            // 
            // txtEnqNo
            // 
            this.txtEnqNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtEnqNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnqNo.Location = new System.Drawing.Point(169, 54);
            this.txtEnqNo.Name = "txtEnqNo";
            this.txtEnqNo.Size = new System.Drawing.Size(215, 23);
            this.txtEnqNo.TabIndex = 17;
            // 
            // dtpEnq
            // 
            this.dtpEnq.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnq.Location = new System.Drawing.Point(169, 95);
            this.dtpEnq.Name = "dtpEnq";
            this.dtpEnq.Size = new System.Drawing.Size(215, 23);
            this.dtpEnq.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 19;
            // 
            // cmbboxQuali
            // 
            this.cmbboxQuali.BackColor = System.Drawing.SystemColors.Info;
            this.cmbboxQuali.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxQuali.FormattingEnabled = true;
            this.cmbboxQuali.Items.AddRange(new object[] {
            "MCA",
            "BCA",
            "MSC",
            "BSC",
            "MA",
            "BA",
            "MCOM",
            "BCOM",
            "BE",
            "ME",
            "BTECH",
            "MTECH",
            "HSC",
            "SSC",
            "Others"});
            this.cmbboxQuali.Location = new System.Drawing.Point(169, 174);
            this.cmbboxQuali.Name = "cmbboxQuali";
            this.cmbboxQuali.Size = new System.Drawing.Size(215, 24);
            this.cmbboxQuali.TabIndex = 20;
            this.cmbboxQuali.Text = "--Select--";
            // 
            // txtForCourses
            // 
            this.txtForCourses.BackColor = System.Drawing.SystemColors.Info;
            this.txtForCourses.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForCourses.Location = new System.Drawing.Point(169, 215);
            this.txtForCourses.Name = "txtForCourses";
            this.txtForCourses.Size = new System.Drawing.Size(215, 23);
            this.txtForCourses.TabIndex = 21;
            this.txtForCourses.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(169, 255);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 57);
            this.txtAddress.TabIndex = 22;
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.SystemColors.Info;
            this.txtContact.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(169, 330);
            this.txtContact.MaxLength = 10;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(215, 23);
            this.txtContact.TabIndex = 23;
            // 
            // cmbboxStatus
            // 
            this.cmbboxStatus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbboxStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbboxStatus.FormattingEnabled = true;
            this.cmbboxStatus.Items.AddRange(new object[] {
            "Enquired",
            "Interested ",
            "Not Interested ",
            "Taken",
            "Not Taken"});
            this.cmbboxStatus.Location = new System.Drawing.Point(169, 367);
            this.cmbboxStatus.Name = "cmbboxStatus";
            this.cmbboxStatus.Size = new System.Drawing.Size(215, 24);
            this.cmbboxStatus.TabIndex = 24;
            this.cmbboxStatus.Text = "--Select--";
            // 
            // grbxAddEnq
            // 
            this.grbxAddEnq.Controls.Add(this.cmbbxForCourse);
            this.grbxAddEnq.Controls.Add(this.label8);
            this.grbxAddEnq.Controls.Add(this.label2);
            this.grbxAddEnq.Controls.Add(this.txtAddress);
            this.grbxAddEnq.Controls.Add(this.cmbboxStatus);
            this.grbxAddEnq.Controls.Add(this.dtpEnq);
            this.grbxAddEnq.Controls.Add(this.label9);
            this.grbxAddEnq.Controls.Add(this.label7);
            this.grbxAddEnq.Controls.Add(this.txtContact);
            this.grbxAddEnq.Controls.Add(this.txtEnqNo);
            this.grbxAddEnq.Controls.Add(this.label3);
            this.grbxAddEnq.Controls.Add(this.txtName);
            this.grbxAddEnq.Controls.Add(this.label10);
            this.grbxAddEnq.Controls.Add(this.label6);
            this.grbxAddEnq.Controls.Add(this.cmbboxQuali);
            this.grbxAddEnq.Controls.Add(this.label4);
            this.grbxAddEnq.Controls.Add(this.label5);
            this.grbxAddEnq.Controls.Add(this.txtForCourses);
            this.grbxAddEnq.Location = new System.Drawing.Point(102, 64);
            this.grbxAddEnq.Name = "grbxAddEnq";
            this.grbxAddEnq.Size = new System.Drawing.Size(409, 461);
            this.grbxAddEnq.TabIndex = 25;
            this.grbxAddEnq.TabStop = false;
            // 
            // cmbbxForCourse
            // 
            this.cmbbxForCourse.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxForCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxForCourse.FormattingEnabled = true;
            this.cmbbxForCourse.Items.AddRange(new object[] {
            "--Select--",
            "C",
            "C++",
            "C & C++",
            "Java",
            "Adv.Java",
            ".Net",
            "SQL",
            "C#.Net",
            "ASP.Net",
            "ASP.NET MVC",
            "Computer Basics",
            "Data Structure"});
            this.cmbbxForCourse.Location = new System.Drawing.Point(169, 214);
            this.cmbbxForCourse.Name = "cmbbxForCourse";
            this.cmbbxForCourse.Size = new System.Drawing.Size(215, 24);
            this.cmbbxForCourse.TabIndex = 21;
            this.cmbbxForCourse.Text = "--Select--";
            // 
            // dgrdviewEnq
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdviewEnq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdviewEnq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrdviewEnq.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrdviewEnq.Location = new System.Drawing.Point(102, 64);
            this.dgrdviewEnq.Name = "dgrdviewEnq";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdviewEnq.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrdviewEnq.Size = new System.Drawing.Size(1067, 493);
            this.dgrdviewEnq.TabIndex = 26;
            this.dgrdviewEnq.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrdviewEnq_RowHeaderMouseDoubleClick);
            // 
            // dB_StudentDataSet
            // 
            this.dB_StudentDataSet.DataSetName = "DB_StudentDataSet";
            this.dB_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(322, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Search By ID";
            this.label11.Visible = false;
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(427, 17);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(127, 23);
            this.txtSearchByID.TabIndex = 28;
            this.txtSearchByID.Visible = false;
            this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(731, 17);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(127, 23);
            this.txtSearchByName.TabIndex = 30;
            this.txtSearchByName.Visible = false;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(600, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Search By Name";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(268, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Total Records:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Info;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(370, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "label14";
            // 
            // frmEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 608);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgrdviewEnq);
            this.Controls.Add(this.grbxAddEnq);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEnquiry_Load);
            this.grbxAddEnq.ResumeLayout(false);
            this.grbxAddEnq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdviewEnq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnqNo;
        private System.Windows.Forms.DateTimePicker dtpEnq;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbboxQuali;
        private System.Windows.Forms.TextBox txtForCourses;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cmbboxStatus;
        private System.Windows.Forms.GroupBox grbxAddEnq;
        private System.Windows.Forms.DataGridView dgrdviewEnq;
        private DB_StudentDataSet dB_StudentDataSet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbbxForCourse;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}