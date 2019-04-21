using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLHS_Form_Lop
{
    public partial class Form_HS : Form
    {
        public Form_HS()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
        private void Form_HS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSDataSet2.tblHocSinh' table. You can move, or remove it, as needed.
            this.tblHocSinhTableAdapter.Fill(this.qLHSDataSet2.tblHocSinh);
            // TODO: This line of code loads data into the 'qLHSDataSet1.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter1.Fill(this.qLHSDataSet1.tblLop);
            // TODO: This line of code loads data into the 'qLHSDataSet.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.qLHSDataSet.tblLop);
            cbMa.Checked = false;
            cboTimMa.Enabled = false;
            txtMaHS.Enabled = false;
            txtHoten.Enabled = false;
            rdoGTnam.Enabled = false;
            rdoGTnu.Enabled = false;
            txtNgaysinh.Enabled = false;
            txtDiachi.Enabled = false;
            mskNienkhoa.Enabled = false;
            cboMalop.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtNgaysinh.Value = DateTime.Today;
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM view_hocsinh", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrHS.DataSource = dt;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select * from tblHocSinh where sMaHS = '" + txtMaHS.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();


            errorProvider1.Clear();
            if(txtMaHS.Text == "")
            {
                errorProvider1.SetError(txtMaHS,"Mã học sinh không được để trống!");
            }
            else if (txtHoten.Text == "")
            {
                errorProvider1.SetError(txtHoten,"Họ tên không được để trống!");
            }
            else if(rdoGTnam.Checked == false && rdoGTnu.Checked == false)
            {
                errorProvider1.SetError(rdoGTnu,"Vui lòng chọn giới tính!");
            }
            else if (txtNgaysinh.Value > DateTime.Today)
            {
                errorProvider1.SetError(txtNgaysinh, "Ngày sinh không được lớn hơn ngày hiện tại!");
            }
            else if(txtDiachi.Text == "")
            {
                errorProvider1.SetError(txtDiachi,"Địa chỉ không được để trống!");
            }
            else if(mskNienkhoa.MaskCompleted == false)
            {
                errorProvider1.SetError(mskNienkhoa,"Niên khóa không được để trống!");
            }
            else if(reader2.Read())
            {
                MessageBox.Show("Đã tồn tại học sinh này","Thông báo");
            }
            else
            {
                //txtNgaysinh.MaxDate = DateTime.Today;
                //cnn = new SqlConnection(constr);
                try
                {
                    cmd2.Dispose();
                    reader2.Dispose();
                    SqlCommand cmd = new SqlCommand("sp_themhocsinh", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cnn.Open();
                    String gt = "";
                    if (rdoGTnam.Checked == true)
                    {
                        gt = "1";
                    }
                    if (rdoGTnu.Checked == true)
                    {
                        gt = "0";
                    }
                    cmd.Parameters.AddWithValue("@mahs", txtMaHS.Text.Trim());
                    cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", gt);
                    cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Value);
                    cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
                    cmd.Parameters.AddWithValue("@nienkhoa", mskNienkhoa.Text);
                    cmd.Parameters.AddWithValue("@malop", cboMalop.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    cmd.Dispose();
                    Form_HS_Load(sender, e);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            cmd2.Dispose();
            reader2.Dispose();
        }

        private void dgrHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtMaHS.Enabled = true;
            txtMaHS.ReadOnly = true;
            txtHoten.Enabled = true;
            txtNgaysinh.Enabled = true;
            txtDiachi.Enabled = true;
            rdoGTnam.Enabled = true;
            rdoGTnu.Enabled = true;
            mskNienkhoa.Enabled = true;
            cboMalop.Enabled = true;
            btnLuu.Enabled = false;
            if (dgrHS.RowCount < 0) return;
            txtMaHS.Text = dgrHS.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgrHS.CurrentRow.Cells[1].Value.ToString();
            if (dgrHS.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                rdoGTnam.Checked = true;
            }
            if (dgrHS.CurrentRow.Cells[2].Value.ToString() == "Nữ")
            {
                rdoGTnu.Checked = true;
            }
            txtNgaysinh.Text = dgrHS.CurrentRow.Cells[3].Value.ToString();
            txtDiachi.Text = dgrHS.CurrentRow.Cells[4].Value.ToString();
            mskNienkhoa.Text = dgrHS.CurrentRow.Cells[5].Value.ToString();
            cboMalop.Text = dgrHS.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Form_HS_Load(sender, e);
            txtMaHS.Enabled = true;
            txtMaHS.ReadOnly = false;
            txtHoten.Enabled = true;
            txtNgaysinh.Enabled = true;
            txtDiachi.Enabled = true;
            rdoGTnam.Enabled = true;
            rdoGTnu.Enabled = true;
            mskNienkhoa.Enabled = true;
            cboMalop.Enabled = true;
            btnLuu.Enabled = true;
            txtMaHS.Clear();
            txtHoten.Clear();
            txtNgaysinh.Value = DateTime.Today;
            txtDiachi.Clear();
            mskNienkhoa.Clear();
            cboMalop.SelectedIndex = 0;
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //string lop = cboTimLop.Text;
            //string ten = txtTimTen.Text;
            cnn = new SqlConnection(constr);
            string timten = "";
            if(cbMa.Checked == true)
            {
                timten = cboTimMa.Text;
                SqlCommand cmd = new SqlCommand("sp_timkiemhs", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@mahs", timten);
                cmd.Parameters.AddWithValue("@tenhs", txtTimTen.Text);
                //cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    dgrHS.DataSource = dt;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK);
                }
                dr.Dispose();
                cmd.Dispose();
            }
            else
            {
                //timten = cboTimLop.Text;
                SqlCommand cmd = new SqlCommand("sp_timkiemhs", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@mahs", timten);
                cmd.Parameters.AddWithValue("@tenhs", txtTimTen.Text);
                //cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {   
                    dgrHS.DataSource = dt;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK);
                }
                dr.Dispose();
                cmd.Dispose();
            }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTen.Text == "")
            {
                Form_HS_Load(sender, e);
                
            }
        }

        private void cbLop_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMa.Checked == true)
            {
                cboTimMa.Enabled = true;
            }
            else
            {
                cboTimMa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("sp_suahs", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@mahs", txtMaHS.Text);
            cmd.Parameters.AddWithValue("@hoten", txtHoten.Text);
            if(rdoGTnam.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gt",1);
            }
            if(rdoGTnu.Checked == true)
            {
                cmd.Parameters.AddWithValue("@gt",0);
            }
            cmd.Parameters.AddWithValue("@ngaysinh", txtNgaysinh.Value);
            cmd.Parameters.AddWithValue("@diachi", txtDiachi.Text);
            cmd.Parameters.AddWithValue("@nienkhoa", mskNienkhoa.Text);
            cmd.Parameters.AddWithValue("@malop", cboMalop.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
            cmd.Dispose();
            Form_HS_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select sMaHS from tblDiem where sMaHS = '"+txtMaHS.Text+"'";
            SqlCommand cmd1 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa dữ liệu có Mã học sinh là " + txtMaHS.Text + " từ bảng Kết quả học tập trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader1.Dispose();
                cmd1.Dispose();


                SqlCommand cmd = new SqlCommand("sp_xoahs", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahs", txtMaHS.Text);
                cmd.ExecuteNonQuery(); //Tra ve kieu int, so dong afected
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");
                cmd.Dispose(); //Tra lai tai nguyen
                Form_HS_Load(sender, e);
            }
            reader1.Dispose();
            cmd1.Dispose();
        }

        private void Form_HS_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }


    }
}
