namespace QLHS_Form_Lop
{
    partial class Form_BangDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaLop = new System.Windows.Forms.CheckBox();
            this.cboNamHoc = new System.Windows.Forms.CheckBox();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.viewnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet8 = new QLHS_Form_Lop.QLHSDataSet8();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.tblLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet7 = new QLHS_Form_Lop.QLHSDataSet7();
            this.tblHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet9 = new QLHS_Form_Lop.QLHSDataSet9();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrDiemCT = new System.Windows.Forms.DataGridView();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tblLopTableAdapter = new QLHS_Form_Lop.QLHSDataSet7TableAdapters.tblLopTableAdapter();
            this.view_namhocTableAdapter = new QLHS_Form_Lop.QLHSDataSet8TableAdapters.view_namhocTableAdapter();
            this.tblHocSinhTableAdapter = new QLHS_Form_Lop.QLHSDataSet9TableAdapters.tblHocSinhTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewnamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet9)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiemCT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(296, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "BẢNG ĐIỂM HỌC SINH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.cboNamHoc);
            this.groupBox1.Controls.Add(this.cbNamHoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbMaLop);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboMaLop
            // 
            this.cboMaLop.AutoSize = true;
            this.cboMaLop.Location = new System.Drawing.Point(170, 63);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(18, 17);
            this.cboMaLop.TabIndex = 26;
            this.cboMaLop.UseVisualStyleBackColor = true;
            this.cboMaLop.CheckedChanged += new System.EventHandler(this.CboMaLop_CheckedChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.AutoSize = true;
            this.cboNamHoc.Location = new System.Drawing.Point(563, 63);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(18, 17);
            this.cboNamHoc.TabIndex = 22;
            this.cboNamHoc.UseVisualStyleBackColor = true;
            this.cboNamHoc.CheckedChanged += new System.EventHandler(this.CboNamHoc_CheckedChanged);
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.DataSource = this.viewnamhocBindingSource;
            this.cbNamHoc.DisplayMember = "sNamHoc";
            this.cbNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Location = new System.Drawing.Point(589, 56);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(154, 30);
            this.cbNamHoc.TabIndex = 19;
            this.cbNamHoc.ValueMember = "sNamHoc";
            // 
            // viewnamhocBindingSource
            // 
            this.viewnamhocBindingSource.DataMember = "view_namhoc";
            this.viewnamhocBindingSource.DataSource = this.qLHSDataSet8;
            // 
            // qLHSDataSet8
            // 
            this.qLHSDataSet8.DataSetName = "QLHSDataSet8";
            this.qLHSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(461, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Năm học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(93, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Mã lớp";
            // 
            // cbMaLop
            // 
            this.cbMaLop.DataSource = this.tblLopBindingSource;
            this.cbMaLop.DisplayMember = "sMaLop";
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(203, 56);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(155, 30);
            this.cbMaLop.TabIndex = 16;
            this.cbMaLop.ValueMember = "sMaLop";
            // 
            // tblLopBindingSource
            // 
            this.tblLopBindingSource.DataMember = "tblLop";
            this.tblLopBindingSource.DataSource = this.qLHSDataSet7;
            // 
            // qLHSDataSet7
            // 
            this.qLHSDataSet7.DataSetName = "QLHSDataSet7";
            this.qLHSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHocSinhBindingSource
            // 
            this.tblHocSinhBindingSource.DataMember = "tblHocSinh";
            this.tblHocSinhBindingSource.DataSource = this.qLHSDataSet9;
            // 
            // qLHSDataSet9
            // 
            this.qLHSDataSet9.DataSetName = "QLHSDataSet9";
            this.qLHSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrDiemCT);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(939, 405);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrDiemCT
            // 
            this.dgrDiemCT.AllowUserToAddRows = false;
            this.dgrDiemCT.AllowUserToDeleteRows = false;
            this.dgrDiemCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiemCT.Location = new System.Drawing.Point(6, 26);
            this.dgrDiemCT.Name = "dgrDiemCT";
            this.dgrDiemCT.ReadOnly = true;
            this.dgrDiemCT.RowTemplate.Height = 24;
            this.dgrDiemCT.Size = new System.Drawing.Size(927, 371);
            this.dgrDiemCT.TabIndex = 16;
            this.dgrDiemCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgrDiemCT_CellClick);
            // 
            // btnXemDS
            // 
            this.btnXemDS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.Location = new System.Drawing.Point(167, 272);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(103, 45);
            this.btnXemDS.TabIndex = 12;
            this.btnXemDS.Text = "Xem DS";
            this.btnXemDS.UseVisualStyleBackColor = true;
            this.btnXemDS.Click += new System.EventHandler(this.BtnXemDS_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(335, 272);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(104, 45);
            this.btnChiTiet.TabIndex = 13;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.BtnChiTiet_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDS.Location = new System.Drawing.Point(506, 272);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(105, 45);
            this.btnInDS.TabIndex = 14;
            this.btnInDS.Text = "In DS";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.BtnInDS_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(675, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 45);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // tblLopTableAdapter
            // 
            this.tblLopTableAdapter.ClearBeforeFill = true;
            // 
            // view_namhocTableAdapter
            // 
            this.view_namhocTableAdapter.ClearBeforeFill = true;
            // 
            // tblHocSinhTableAdapter
            // 
            this.tblHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // Form_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 741);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnXemDS);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_BangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_BangDiem_FormClosing);
            this.Load += new System.EventHandler(this.Form_BangDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewnamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet9)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiemCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private System.Windows.Forms.Label label2;
        private QLHSDataSet7 qLHSDataSet7;
        private System.Windows.Forms.BindingSource tblLopBindingSource;
        private QLHSDataSet7TableAdapters.tblLopTableAdapter tblLopTableAdapter;
        private QLHSDataSet8 qLHSDataSet8;
        private System.Windows.Forms.BindingSource viewnamhocBindingSource;
        private QLHSDataSet8TableAdapters.view_namhocTableAdapter view_namhocTableAdapter;
        private QLHSDataSet9 qLHSDataSet9;
        private System.Windows.Forms.BindingSource tblHocSinhBindingSource;
        private QLHSDataSet9TableAdapters.tblHocSinhTableAdapter tblHocSinhTableAdapter;
        private System.Windows.Forms.CheckBox cboNamHoc;
        private System.Windows.Forms.DataGridView dgrDiemCT;
        private System.Windows.Forms.CheckBox cboMaLop;
    }
}