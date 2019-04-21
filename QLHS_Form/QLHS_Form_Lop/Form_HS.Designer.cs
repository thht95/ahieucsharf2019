namespace QLHS_Form_Lop
{
    partial class Form_HS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.mskNienkhoa = new System.Windows.Forms.MaskedTextBox();
            this.cboMalop = new System.Windows.Forms.ComboBox();
            this.tblLopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet1 = new QLHS_Form_Lop.QLHSDataSet1();
            this.rdoGTnu = new System.Windows.Forms.RadioButton();
            this.rdoGTnam = new System.Windows.Forms.RadioButton();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet = new QLHS_Form_Lop.QLHSDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrHS = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMa = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTimMa = new System.Windows.Forms.ComboBox();
            this.tblHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet2 = new QLHS_Form_Lop.QLHSDataSet2();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblLopTableAdapter = new QLHS_Form_Lop.QLHSDataSetTableAdapters.tblLopTableAdapter();
            this.tblLopTableAdapter1 = new QLHS_Form_Lop.QLHSDataSet1TableAdapters.tblLopTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblHocSinhTableAdapter = new QLHS_Form_Lop.QLHSDataSet2TableAdapters.tblHocSinhTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHS)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaysinh);
            this.groupBox1.Controls.Add(this.mskNienkhoa);
            this.groupBox1.Controls.Add(this.cboMalop);
            this.groupBox1.Controls.Add(this.rdoGTnu);
            this.groupBox1.Controls.Add(this.rdoGTnam);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMaHS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaysinh.Location = new System.Drawing.Point(140, 178);
            this.txtNgaysinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(139, 27);
            this.txtNgaysinh.TabIndex = 25;
            this.txtNgaysinh.Value = new System.DateTime(2017, 7, 10, 0, 0, 0, 0);
            // 
            // mskNienkhoa
            // 
            this.mskNienkhoa.Location = new System.Drawing.Point(140, 301);
            this.mskNienkhoa.Mask = "0000-0000";
            this.mskNienkhoa.Name = "mskNienkhoa";
            this.mskNienkhoa.Size = new System.Drawing.Size(179, 27);
            this.mskNienkhoa.TabIndex = 24;
            // 
            // cboMalop
            // 
            this.cboMalop.DataSource = this.tblLopBindingSource1;
            this.cboMalop.DisplayMember = "sMaLop";
            this.cboMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMalop.FormattingEnabled = true;
            this.cboMalop.Location = new System.Drawing.Point(140, 349);
            this.cboMalop.Name = "cboMalop";
            this.cboMalop.Size = new System.Drawing.Size(179, 30);
            this.cboMalop.TabIndex = 23;
            this.cboMalop.ValueMember = "sMaLop";
            // 
            // tblLopBindingSource1
            // 
            this.tblLopBindingSource1.DataMember = "tblLop";
            this.tblLopBindingSource1.DataSource = this.qLHSDataSet1;
            // 
            // qLHSDataSet1
            // 
            this.qLHSDataSet1.DataSetName = "QLHSDataSet1";
            this.qLHSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdoGTnu
            // 
            this.rdoGTnu.AutoSize = true;
            this.rdoGTnu.Location = new System.Drawing.Point(229, 139);
            this.rdoGTnu.Name = "rdoGTnu";
            this.rdoGTnu.Size = new System.Drawing.Size(50, 26);
            this.rdoGTnu.TabIndex = 22;
            this.rdoGTnu.TabStop = true;
            this.rdoGTnu.Text = "Nữ";
            this.rdoGTnu.UseVisualStyleBackColor = true;
            // 
            // rdoGTnam
            // 
            this.rdoGTnam.AutoSize = true;
            this.rdoGTnam.Location = new System.Drawing.Point(140, 139);
            this.rdoGTnam.Name = "rdoGTnam";
            this.rdoGTnam.Size = new System.Drawing.Size(62, 26);
            this.rdoGTnam.TabIndex = 21;
            this.rdoGTnam.TabStop = true;
            this.rdoGTnam.Text = "Nam";
            this.rdoGTnam.UseVisualStyleBackColor = true;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(140, 224);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(179, 55);
            this.txtDiachi.TabIndex = 18;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(140, 99);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(179, 27);
            this.txtHoten.TabIndex = 16;
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(140, 51);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(179, 27);
            this.txtMaHS.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(16, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Niên khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(16, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(16, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Họ và tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mã học sinh";
            // 
            // tblLopBindingSource
            // 
            this.tblLopBindingSource.DataMember = "tblLop";
            this.tblLopBindingSource.DataSource = this.qLHSDataSet;
            // 
            // qLHSDataSet
            // 
            this.qLHSDataSet.DataSetName = "QLHSDataSet";
            this.qLHSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrHS);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(388, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrHS
            // 
            this.dgrHS.AllowUserToAddRows = false;
            this.dgrHS.AllowUserToDeleteRows = false;
            this.dgrHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHS.Location = new System.Drawing.Point(6, 26);
            this.dgrHS.Name = "dgrHS";
            this.dgrHS.ReadOnly = true;
            this.dgrHS.RowTemplate.Height = 24;
            this.dgrHS.Size = new System.Drawing.Size(842, 392);
            this.dgrHS.TabIndex = 9;
            this.dgrHS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrHS_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbMa);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cboTimMa);
            this.groupBox3.Controls.Add(this.txtTimTen);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(12, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1200, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cbMa
            // 
            this.cbMa.AutoSize = true;
            this.cbMa.Location = new System.Drawing.Point(351, 28);
            this.cbMa.Name = "cbMa";
            this.cbMa.Size = new System.Drawing.Size(18, 17);
            this.cbMa.TabIndex = 9;
            this.cbMa.UseVisualStyleBackColor = true;
            this.cbMa.CheckedChanged += new System.EventHandler(this.cbLop_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(627, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Họ và tên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(995, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(109, 34);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(275, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã HS";
            // 
            // cboTimMa
            // 
            this.cboTimMa.DataSource = this.tblHocSinhBindingSource;
            this.cboTimMa.DisplayMember = "sMaHS";
            this.cboTimMa.FormattingEnabled = true;
            this.cboTimMa.Location = new System.Drawing.Point(376, 21);
            this.cboTimMa.Name = "cboTimMa";
            this.cboTimMa.Size = new System.Drawing.Size(157, 30);
            this.cboTimMa.TabIndex = 15;
            this.cboTimMa.ValueMember = "sMaHS";
            // 
            // tblHocSinhBindingSource
            // 
            this.tblHocSinhBindingSource.DataMember = "tblHocSinh";
            this.tblHocSinhBindingSource.DataSource = this.qLHSDataSet2;
            // 
            // qLHSDataSet2
            // 
            this.qLHSDataSet2.DataSetName = "QLHSDataSet2";
            this.qLHSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(725, 22);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(179, 27);
            this.txtTimTen.TabIndex = 9;
            this.txtTimTen.TextChanged += new System.EventHandler(this.txtTimTen_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1252, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1252, 516);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 45);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1253, 430);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 45);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1253, 346);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 45);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1253, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 45);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(411, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÍ THÔNG TIN HỌC SINH";
            // 
            // tblLopTableAdapter
            // 
            this.tblLopTableAdapter.ClearBeforeFill = true;
            // 
            // tblLopTableAdapter1
            // 
            this.tblLopTableAdapter1.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblHocSinhTableAdapter
            // 
            this.tblHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // Form_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_HS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_HS_FormClosing);
            this.Load += new System.EventHandler(this.Form_HS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHS)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.DateTimePicker txtNgaysinh;
        private System.Windows.Forms.MaskedTextBox mskNienkhoa;
        private System.Windows.Forms.ComboBox cboMalop;
        private System.Windows.Forms.RadioButton rdoGTnu;
        private System.Windows.Forms.RadioButton rdoGTnam;
        private System.Windows.Forms.DataGridView dgrHS;
        private QLHSDataSet qLHSDataSet;
        private System.Windows.Forms.BindingSource tblLopBindingSource;
        private QLHSDataSetTableAdapters.tblLopTableAdapter tblLopTableAdapter;
        private System.Windows.Forms.CheckBox cbMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTimMa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimTen;
        private QLHSDataSet1 qLHSDataSet1;
        private System.Windows.Forms.BindingSource tblLopBindingSource1;
        private QLHSDataSet1TableAdapters.tblLopTableAdapter tblLopTableAdapter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private QLHSDataSet2 qLHSDataSet2;
        private System.Windows.Forms.BindingSource tblHocSinhBindingSource;
        private QLHSDataSet2TableAdapters.tblHocSinhTableAdapter tblHocSinhTableAdapter;
    }
}