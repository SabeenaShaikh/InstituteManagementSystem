namespace ISMS_Project
{
    partial class frmExpences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpences));
            this.btnExportData = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grbxAddExp = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpdt = new System.Windows.Forms.DateTimePicker();
            this.txtExpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpDescr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxExpBy = new System.Windows.Forms.ComboBox();
            this.tblusersmasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_StudentDataSet = new ISMS_Project.DB_StudentDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgrvExpInfo = new System.Windows.Forms.DataGridView();
            this.tbl_users_masterTableAdapter = new ISMS_Project.DB_StudentDataSetTableAdapters.tbl_users_masterTableAdapter();
            this.grbxAddExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersmasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvExpInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Image = ((System.Drawing.Image)(resources.GetObject("btnExportData.Image")));
            this.btnExportData.Location = new System.Drawing.Point(582, 36);
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
            this.txtSearchByName.Location = new System.Drawing.Point(448, 45);
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
            this.label12.Location = new System.Drawing.Point(317, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Search By Name";
            this.label12.Visible = false;
            // 
            // grbxAddExp
            // 
            this.grbxAddExp.Controls.Add(this.label9);
            this.grbxAddExp.Controls.Add(this.txtAmt);
            this.grbxAddExp.Controls.Add(this.label2);
            this.grbxAddExp.Controls.Add(this.dtpExpdt);
            this.grbxAddExp.Controls.Add(this.txtExpID);
            this.grbxAddExp.Controls.Add(this.label3);
            this.grbxAddExp.Controls.Add(this.txtExpDescr);
            this.grbxAddExp.Controls.Add(this.label6);
            this.grbxAddExp.Controls.Add(this.cmbxExpBy);
            this.grbxAddExp.Controls.Add(this.label4);
            this.grbxAddExp.Controls.Add(this.label5);
            this.grbxAddExp.Location = new System.Drawing.Point(128, 95);
            this.grbxAddExp.Name = "grbxAddExp";
            this.grbxAddExp.Size = new System.Drawing.Size(458, 286);
            this.grbxAddExp.TabIndex = 40;
            this.grbxAddExp.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Amount";
            // 
            // txtAmt
            // 
            this.txtAmt.BackColor = System.Drawing.SystemColors.Info;
            this.txtAmt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(109, 201);
            this.txtAmt.MaxLength = 10;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(215, 23);
            this.txtAmt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add Expense:";
            // 
            // dtpExpdt
            // 
            this.dtpExpdt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpdt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpdt.Location = new System.Drawing.Point(270, 63);
            this.dtpExpdt.Name = "dtpExpdt";
            this.dtpExpdt.Size = new System.Drawing.Size(133, 23);
            this.dtpExpdt.TabIndex = 18;
            // 
            // txtExpID
            // 
            this.txtExpID.BackColor = System.Drawing.SystemColors.Info;
            this.txtExpID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpID.Location = new System.Drawing.Point(109, 63);
            this.txtExpID.Name = "txtExpID";
            this.txtExpID.Size = new System.Drawing.Size(86, 23);
            this.txtExpID.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Expense ID";
            // 
            // txtExpDescr
            // 
            this.txtExpDescr.BackColor = System.Drawing.SystemColors.Info;
            this.txtExpDescr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDescr.Location = new System.Drawing.Point(109, 108);
            this.txtExpDescr.Name = "txtExpDescr";
            this.txtExpDescr.Size = new System.Drawing.Size(294, 23);
            this.txtExpDescr.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Exp. By";
            // 
            // cmbxExpBy
            // 
            this.cmbxExpBy.BackColor = System.Drawing.SystemColors.Info;
            this.cmbxExpBy.DataSource = this.tblusersmasterBindingSource;
            this.cmbxExpBy.DisplayMember = "user_name";
            this.cmbxExpBy.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxExpBy.FormattingEnabled = true;
            this.cmbxExpBy.Location = new System.Drawing.Point(109, 154);
            this.cmbxExpBy.Name = "cmbxExpBy";
            this.cmbxExpBy.Size = new System.Drawing.Size(215, 24);
            this.cmbxExpBy.TabIndex = 20;
            this.cmbxExpBy.ValueMember = "user_name";
            // 
            // tblusersmasterBindingSource
            // 
            this.tblusersmasterBindingSource.DataMember = "tbl_users_master";
            this.tblusersmasterBindingSource.DataSource = this.dB_StudentDataSet;
            // 
            // dB_StudentDataSet
            // 
            this.dB_StudentDataSet.DataSetName = "DB_StudentDataSet";
            this.dB_StudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(30, 420);
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
            this.btnSearch.Location = new System.Drawing.Point(30, 296);
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
            this.btnDelete.Location = new System.Drawing.Point(30, 358);
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
            this.btnEditUpdate.Enabled = false;
            this.btnEditUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnEditUpdate.Image")));
            this.btnEditUpdate.Location = new System.Drawing.Point(30, 234);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(56, 56);
            this.btnEditUpdate.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnEditUpdate, "EditUpdate");
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.Location = new System.Drawing.Point(30, 174);
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
            this.btnSave.Location = new System.Drawing.Point(30, 112);
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
            this.btnAddNew.Location = new System.Drawing.Point(30, 50);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 56);
            this.btnAddNew.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnAddNew, "Add Expenses ");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Expenses ";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // dgrvExpInfo
            // 
            this.dgrvExpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvExpInfo.Location = new System.Drawing.Point(128, 95);
            this.dgrvExpInfo.Name = "dgrvExpInfo";
            this.dgrvExpInfo.Size = new System.Drawing.Size(694, 409);
            this.dgrvExpInfo.TabIndex = 46;
            this.dgrvExpInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrvExpInfo_RowHeaderMouseDoubleClick);
            // 
            // tbl_users_masterTableAdapter
            // 
            this.tbl_users_masterTableAdapter.ClearBeforeFill = true;
            // 
            // frmExpences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 537);
            this.Controls.Add(this.dgrvExpInfo);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grbxAddExp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Name = "frmExpences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form13";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExpences_Load);
            this.grbxAddExp.ResumeLayout(false);
            this.grbxAddExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblusersmasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_StudentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvExpInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbxAddExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpdt;
        private System.Windows.Forms.TextBox txtExpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpDescr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxExpBy;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgrvExpInfo;
        private DB_StudentDataSet dB_StudentDataSet;
        private System.Windows.Forms.BindingSource tblusersmasterBindingSource;
        private DB_StudentDataSetTableAdapters.tbl_users_masterTableAdapter tbl_users_masterTableAdapter;
    }
}