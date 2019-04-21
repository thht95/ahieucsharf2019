namespace QLHS_Form_Lop
{
    partial class Form_QLDiem
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
            this.label5 = new System.Windows.Forms.Label();
            this.mskNamHoc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocKi = new System.Windows.Forms.ComboBox();
            this.cbMaHS = new System.Windows.Forms.ComboBox();
            this.tblHocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet6 = new QLHS_Form_Lop.QLHSDataSet6();
            this.cbMaMon = new System.Windows.Forms.ComboBox();
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSDataSet5 = new QLHS_Form_Lop.QLHSDataSet5();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiemHK = new System.Windows.Forms.TextBox();
            this.txtDiem45p = new System.Windows.Forms.TextBox();
            this.txtDiem15p = new System.Windows.Forms.TextBox();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrQLDiem = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tblMonHocTableAdapter = new QLHS_Form_Lop.QLHSDataSet5TableAdapters.tblMonHocTableAdapter();
            this.tblHocSinhTableAdapter = new QLHS_Form_Lop.QLHSDataSet6TableAdapters.tblHocSinhTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQLDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mskNamHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbHocKi);
            this.groupBox1.Controls.Add(this.cbMaHS);
            this.groupBox1.Controls.Add(this.cbMaMon);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cập nhật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(812, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Năm học";
            // 
            // mskNamHoc
            // 
            this.mskNamHoc.Location = new System.Drawing.Point(905, 54);
            this.mskNamHoc.Mask = "0000-0000";
            this.mskNamHoc.Name = "mskNamHoc";
            this.mskNamHoc.Size = new System.Drawing.Size(122, 27);
            this.mskNamHoc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(554, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Học kì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(296, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã HS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã môn";
            // 
            // cbHocKi
            // 
            this.cbHocKi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKi.FormattingEnabled = true;
            this.cbHocKi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKi.Location = new System.Drawing.Point(632, 51);
            this.cbHocKi.Name = "cbHocKi";
            this.cbHocKi.Size = new System.Drawing.Size(121, 30);
            this.cbHocKi.TabIndex = 13;
            // 
            // cbMaHS
            // 
            this.cbMaHS.DataSource = this.tblHocSinhBindingSource;
            this.cbMaHS.DisplayMember = "sMaHS";
            this.cbMaHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaHS.FormattingEnabled = true;
            this.cbMaHS.Location = new System.Drawing.Point(375, 51);
            this.cbMaHS.Name = "cbMaHS";
            this.cbMaHS.Size = new System.Drawing.Size(121, 30);
            this.cbMaHS.TabIndex = 12;
            this.cbMaHS.ValueMember = "sMaHS";
            // 
            // tblHocSinhBindingSource
            // 
            this.tblHocSinhBindingSource.DataMember = "tblHocSinh";
            this.tblHocSinhBindingSource.DataSource = this.qLHSDataSet6;
            // 
            // qLHSDataSet6
            // 
            this.qLHSDataSet6.DataSetName = "QLHSDataSet6";
            this.qLHSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMaMon
            // 
            this.cbMaMon.DataSource = this.tblMonHocBindingSource;
            this.cbMaMon.DisplayMember = "sMaMon";
            this.cbMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMon.FormattingEnabled = true;
            this.cbMaMon.Location = new System.Drawing.Point(107, 54);
            this.cbMaMon.Name = "cbMaMon";
            this.cbMaMon.Size = new System.Drawing.Size(121, 30);
            this.cbMaMon.TabIndex = 11;
            this.cbMaMon.ValueMember = "sMaMon";
            // 
            // tblMonHocBindingSource
            // 
            this.tblMonHocBindingSource.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource.DataSource = this.qLHSDataSet5;
            // 
            // qLHSDataSet5
            // 
            this.qLHSDataSet5.DataSetName = "QLHSDataSet5";
            this.qLHSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiemHK);
            this.groupBox2.Controls.Add(this.txtDiem45p);
            this.groupBox2.Controls.Add(this.txtDiem15p);
            this.groupBox2.Controls.Add(this.txtDiemMieng);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập điểm";
            // 
            // txtDiemHK
            // 
            this.txtDiemHK.Location = new System.Drawing.Point(955, 41);
            this.txtDiemHK.Name = "txtDiemHK";
            this.txtDiemHK.Size = new System.Drawing.Size(72, 27);
            this.txtDiemHK.TabIndex = 18;
            // 
            // txtDiem45p
            // 
            this.txtDiem45p.Location = new System.Drawing.Point(681, 40);
            this.txtDiem45p.Name = "txtDiem45p";
            this.txtDiem45p.Size = new System.Drawing.Size(72, 27);
            this.txtDiem45p.TabIndex = 17;
            // 
            // txtDiem15p
            // 
            this.txtDiem15p.Location = new System.Drawing.Point(424, 40);
            this.txtDiem15p.Name = "txtDiem15p";
            this.txtDiem15p.Size = new System.Drawing.Size(72, 27);
            this.txtDiem15p.TabIndex = 16;
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Location = new System.Drawing.Point(153, 41);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(72, 27);
            this.txtDiemMieng.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(812, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Điểm học kì";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(282, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Điểm 15 phút";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(540, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm 45 phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(17, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Điểm miệng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrQLDiem);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(12, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1056, 281);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgrQLDiem
            // 
            this.dgrQLDiem.AllowUserToAddRows = false;
            this.dgrQLDiem.AllowUserToDeleteRows = false;
            this.dgrQLDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQLDiem.Location = new System.Drawing.Point(6, 26);
            this.dgrQLDiem.Name = "dgrQLDiem";
            this.dgrQLDiem.ReadOnly = true;
            this.dgrQLDiem.RowTemplate.Height = 24;
            this.dgrQLDiem.Size = new System.Drawing.Size(1044, 249);
            this.dgrQLDiem.TabIndex = 3;
            this.dgrQLDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrQLDiem_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(146, 326);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 45);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(313, 326);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 45);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(484, 326);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 45);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(658, 327);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 45);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(828, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // tblHocSinhTableAdapter
            // 
            this.tblHocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(254, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "CẬP NHẬT ĐIỂM HỌC SINH";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_QLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_QLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_QLDiem_FormClosing);
            this.Load += new System.EventHandler(this.Form_QLDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSDataSet5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrQLDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrQLDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHocKi;
        private System.Windows.Forms.ComboBox cbMaHS;
        private System.Windows.Forms.ComboBox cbMaMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private QLHSDataSet5 qLHSDataSet5;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private QLHSDataSet5TableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
        private QLHSDataSet6 qLHSDataSet6;
        private System.Windows.Forms.BindingSource tblHocSinhBindingSource;
        private QLHSDataSet6TableAdapters.tblHocSinhTableAdapter tblHocSinhTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskNamHoc;
        private System.Windows.Forms.TextBox txtDiemHK;
        private System.Windows.Forms.TextBox txtDiem45p;
        private System.Windows.Forms.TextBox txtDiem15p;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}