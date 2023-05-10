namespace ISMS_Project
{
    partial class frmFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFees));
            this.dgv1Studinfo = new System.Windows.Forms.DataGridView();
            this.grbxPayFees = new System.Windows.Forms.GroupBox();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.dtpFeesDue = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBalAmt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaidAmt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTechMobile = new System.Windows.Forms.TextBox();
            this.txtTotalFeesAmt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.dtpRecDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtRecieptNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbxPayMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnViewFees = new System.Windows.Forms.Button();
            this.btnSaveFeeRec = new System.Windows.Forms.Button();
            this.btnPayFees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrintReciept = new System.Windows.Forms.Button();
            this.dgrv2FeesInfo = new System.Windows.Forms.DataGridView();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Studinfo)).BeginInit();
            this.grbxPayFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv2FeesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1Studinfo
            // 
            this.dgv1Studinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Studinfo.Location = new System.Drawing.Point(135, 72);
            this.dgv1Studinfo.Name = "dgv1Studinfo";
            this.dgv1Studinfo.Size = new System.Drawing.Size(581, 439);
            this.dgv1Studinfo.TabIndex = 40;
            this.dgv1Studinfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1Studinfo_RowHeaderMouseDoubleClick);
            // 
            // grbxPayFees
            // 
            this.grbxPayFees.Controls.Add(this.txtTransID);
            this.grbxPayFees.Controls.Add(this.dtpFeesDue);
            this.grbxPayFees.Controls.Add(this.label14);
            this.grbxPayFees.Controls.Add(this.txtBalAmt);
            this.grbxPayFees.Controls.Add(this.label13);
            this.grbxPayFees.Controls.Add(this.txtPaidAmt);
            this.grbxPayFees.Controls.Add(this.label12);
            this.grbxPayFees.Controls.Add(this.txtTechMobile);
            this.grbxPayFees.Controls.Add(this.txtTotalFeesAmt);
            this.grbxPayFees.Controls.Add(this.label11);
            this.grbxPayFees.Controls.Add(this.txtCourse);
            this.grbxPayFees.Controls.Add(this.dtpRecDate);
            this.grbxPayFees.Controls.Add(this.label10);
            this.grbxPayFees.Controls.Add(this.label8);
            this.grbxPayFees.Controls.Add(this.txtStudName);
            this.grbxPayFees.Controls.Add(this.txtRecieptNo);
            this.grbxPayFees.Controls.Add(this.label2);
            this.grbxPayFees.Controls.Add(this.label3);
            this.grbxPayFees.Controls.Add(this.label6);
            this.grbxPayFees.Controls.Add(this.cmbbxPayMode);
            this.grbxPayFees.Controls.Add(this.label4);
            this.grbxPayFees.Controls.Add(this.label5);
            this.grbxPayFees.Location = new System.Drawing.Point(144, 72);
            this.grbxPayFees.Name = "grbxPayFees";
            this.grbxPayFees.Size = new System.Drawing.Size(513, 417);
            this.grbxPayFees.TabIndex = 39;
            this.grbxPayFees.TabStop = false;
            // 
            // txtTransID
            // 
            this.txtTransID.BackColor = System.Drawing.SystemColors.Info;
            this.txtTransID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.Location = new System.Drawing.Point(144, 366);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(229, 23);
            this.txtTransID.TabIndex = 51;
            this.txtTransID.Text = "NA";
            // 
            // dtpFeesDue
            // 
            this.dtpFeesDue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFeesDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFeesDue.Location = new System.Drawing.Point(144, 291);
            this.dtpFeesDue.Name = "dtpFeesDue";
            this.dtpFeesDue.Size = new System.Drawing.Size(120, 23);
            this.dtpFeesDue.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "Due Date";
            // 
            // txtBalAmt
            // 
            this.txtBalAmt.BackColor = System.Drawing.SystemColors.Info;
            this.txtBalAmt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalAmt.Location = new System.Drawing.Point(144, 259);
            this.txtBalAmt.Name = "txtBalAmt";
            this.txtBalAmt.Size = new System.Drawing.Size(229, 23);
            this.txtBalAmt.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 261);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Balance ";
            // 
            // txtPaidAmt
            // 
            this.txtPaidAmt.BackColor = System.Drawing.SystemColors.Info;
            this.txtPaidAmt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmt.Location = new System.Drawing.Point(144, 215);
            this.txtPaidAmt.Name = "txtPaidAmt";
            this.txtPaidAmt.Size = new System.Drawing.Size(229, 23);
            this.txtPaidAmt.TabIndex = 46;
            this.txtPaidAmt.TextChanged += new System.EventHandler(this.txtPaidAmt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Paid";
            // 
            // txtTechMobile
            // 
            this.txtTechMobile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTechMobile.Location = new System.Drawing.Point(579, 361);
            this.txtTechMobile.Name = "txtTechMobile";
            this.txtTechMobile.Size = new System.Drawing.Size(229, 23);
            this.txtTechMobile.TabIndex = 18;
            // 
            // txtTotalFeesAmt
            // 
            this.txtTotalFeesAmt.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalFeesAmt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFeesAmt.Location = new System.Drawing.Point(144, 184);
            this.txtTotalFeesAmt.Name = "txtTotalFeesAmt";
            this.txtTotalFeesAmt.Size = new System.Drawing.Size(229, 23);
            this.txtTotalFeesAmt.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Total Fees";
            // 
            // txtCourse
            // 
            this.txtCourse.BackColor = System.Drawing.SystemColors.Info;
            this.txtCourse.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(144, 153);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(229, 23);
            this.txtCourse.TabIndex = 42;
            // 
            // dtpRecDate
            // 
            this.dtpRecDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRecDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecDate.Location = new System.Drawing.Point(144, 82);
            this.dtpRecDate.Name = "dtpRecDate";
            this.dtpRecDate.Size = new System.Drawing.Size(120, 23);
            this.dtpRecDate.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Trans. ID";
            // 
            // txtStudName
            // 
            this.txtStudName.BackColor = System.Drawing.SystemColors.Info;
            this.txtStudName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudName.Location = new System.Drawing.Point(144, 121);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(229, 23);
            this.txtStudName.TabIndex = 14;
            // 
            // txtRecieptNo
            // 
            this.txtRecieptNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtRecieptNo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecieptNo.Location = new System.Drawing.Point(144, 53);
            this.txtRecieptNo.Name = "txtRecieptNo";
            this.txtRecieptNo.Size = new System.Drawing.Size(228, 23);
            this.txtRecieptNo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pay Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Receipt No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pay Mode";
            // 
            // cmbbxPayMode
            // 
            this.cmbbxPayMode.BackColor = System.Drawing.SystemColors.Info;
            this.cmbbxPayMode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPayMode.FormattingEnabled = true;
            this.cmbbxPayMode.Items.AddRange(new object[] {
            "Cash",
            "Transfer"});
            this.cmbbxPayMode.Location = new System.Drawing.Point(144, 336);
            this.cmbbxPayMode.Name = "cmbbxPayMode";
            this.cmbbxPayMode.Size = new System.Drawing.Size(229, 24);
            this.cmbbxPayMode.TabIndex = 15;
            this.cmbbxPayMode.Text = "--Select--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Course";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(41, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 56);
            this.btnDelete.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete Not Allowed");
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(41, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 56);
            this.btnClose.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(41, 297);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 56);
            this.btnSearch.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnSearch, "Search-Export");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.AutoSize = true;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(41, 234);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "Edit Not Allowed");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnViewFees
            // 
            this.btnViewFees.AutoSize = true;
            this.btnViewFees.Image = ((System.Drawing.Image)(resources.GetObject("btnViewFees.Image")));
            this.btnViewFees.Location = new System.Drawing.Point(41, 171);
            this.btnViewFees.Name = "btnViewFees";
            this.btnViewFees.Size = new System.Drawing.Size(54, 54);
            this.btnViewFees.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnViewFees, "View Fees Details");
            this.btnViewFees.UseVisualStyleBackColor = true;
            this.btnViewFees.Click += new System.EventHandler(this.btnViewFees_Click);
            // 
            // btnSaveFeeRec
            // 
            this.btnSaveFeeRec.AutoSize = true;
            this.btnSaveFeeRec.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFeeRec.Image")));
            this.btnSaveFeeRec.Location = new System.Drawing.Point(41, 108);
            this.btnSaveFeeRec.Name = "btnSaveFeeRec";
            this.btnSaveFeeRec.Size = new System.Drawing.Size(56, 56);
            this.btnSaveFeeRec.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnSaveFeeRec, "Save Reciept");
            this.btnSaveFeeRec.UseVisualStyleBackColor = true;
            this.btnSaveFeeRec.Click += new System.EventHandler(this.btnSaveFeeRec_Click);
            // 
            // btnPayFees
            // 
            this.btnPayFees.AutoSize = true;
            this.btnPayFees.Image = ((System.Drawing.Image)(resources.GetObject("btnPayFees.Image")));
            this.btnPayFees.Location = new System.Drawing.Point(41, 45);
            this.btnPayFees.Name = "btnPayFees";
            this.btnPayFees.Size = new System.Drawing.Size(56, 56);
            this.btnPayFees.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnPayFees, "Pay Fees");
            this.btnPayFees.UseVisualStyleBackColor = true;
            this.btnPayFees.Click += new System.EventHandler(this.btnPayFees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fees Details";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(591, 21);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(41, 40);
            this.btnExport.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnExport, "Export Data");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrintReciept
            // 
            this.btnPrintReciept.AutoSize = true;
            this.btnPrintReciept.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReciept.Image")));
            this.btnPrintReciept.Location = new System.Drawing.Point(638, 20);
            this.btnPrintReciept.Name = "btnPrintReciept";
            this.btnPrintReciept.Size = new System.Drawing.Size(41, 41);
            this.btnPrintReciept.TabIndex = 52;
            this.toolTip1.SetToolTip(this.btnPrintReciept, "Print Reciept");
            this.btnPrintReciept.UseVisualStyleBackColor = true;
            this.btnPrintReciept.Click += new System.EventHandler(this.btnPrintReciept_Click);
            // 
            // dgrv2FeesInfo
            // 
            this.dgrv2FeesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv2FeesInfo.Location = new System.Drawing.Point(144, 67);
            this.dgrv2FeesInfo.Name = "dgrv2FeesInfo";
            this.dgrv2FeesInfo.Size = new System.Drawing.Size(938, 516);
            this.dgrv2FeesInfo.TabIndex = 41;
            this.dgrv2FeesInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrv2FeesInfo_RowHeaderMouseDoubleClick);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearchByName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(451, 30);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(137, 23);
            this.txtSearchByName.TabIndex = 43;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(318, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Search By Name";
            // 
            // frmFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 596);
            this.Controls.Add(this.btnPrintReciept);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgrv2FeesInfo);
            this.Controls.Add(this.dgv1Studinfo);
            this.Controls.Add(this.grbxPayFees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnViewFees);
            this.Controls.Add(this.btnSaveFeeRec);
            this.Controls.Add(this.btnPayFees);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form9";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Studinfo)).EndInit();
            this.grbxPayFees.ResumeLayout(false);
            this.grbxPayFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv2FeesInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1Studinfo;
        private System.Windows.Forms.GroupBox grbxPayFees;
        private System.Windows.Forms.TextBox txtTechMobile;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRecieptNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxPayMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnViewFees;
        private System.Windows.Forms.Button btnSaveFeeRec;
        private System.Windows.Forms.Button btnPayFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtTotalFeesAmt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.DateTimePicker dtpRecDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.DateTimePicker dtpFeesDue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBalAmt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPaidAmt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgrv2FeesInfo;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrintReciept;
    }
}