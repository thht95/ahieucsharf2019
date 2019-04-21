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
    public partial class Form_Lop : Form
    {
        public Form_Lop()
        {
            InitializeComponent();
        }
            SqlConnection cnn;
            String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();
        private void Form_Lop_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMalop.Enabled = false;
            txtTenlop.Enabled = false;
            txtMalop.Text = "";
            txtTenlop.Text = "";
            btnThem.Focus();
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM view_sisolop", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrLop.DataSource = dt;
            }
            cmd.Dispose();
        }

        private void Form_Lop_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void dgrLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrLop.RowCount < 0) return;
            txtMalop.Enabled = true;
            txtMalop.ReadOnly = true;
            txtTenlop.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMalop.Text = dgrLop.CurrentRow.Cells[0].Value.ToString();
            txtTenlop.Text = dgrLop.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMalop.Enabled = true;
            txtMalop.ReadOnly = false;
            txtTenlop.Enabled = true;
            txtMalop.Text = "";
            txtTenlop.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select * from tblLop where sMaLop = '" + txtMalop.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtMalop.Text == "")
            {
                errorProvider1.SetError(txtMalop, "Mã lớp không được để trống!");
            }
            else if(txtTenlop.Text == "")
            {
                errorProvider1.SetError(txtTenlop, "Tên lớp không được để trống!");
            }
            else if(reader2.Read())
            {
                MessageBox.Show("Đã tồn tại lớp có mã lớp này!", "Thông báo");
            }
            else
            {
                try
                {
                    cmd2.Dispose();
                    reader2.Dispose();
                    //cnn = new SqlConnection(constr);
                    SqlCommand cmd = new SqlCommand("sp_themlop", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cnn.Open();
                    cmd.Parameters.AddWithValue("@malop", txtMalop.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenlop", txtTenlop.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    Form_Lop_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            cmd2.Dispose();
            reader2.Dispose();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenlop.Text == "")
            {
                errorProvider1.SetError(txtTenlop,"Tên lớp không được để trống!");
            }

            else
            {
                try
                {
                    cnn = new SqlConnection(constr);
                    SqlCommand cmd = new SqlCommand("sp_sualop", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@malop", txtMalop.Text);
                    cmd.Parameters.AddWithValue("@tenlop", txtTenlop.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                    cmd.Dispose();
                    Form_Lop_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select sMaLop from tblHocSinh where sMaLop = '"+txtMalop.Text+"'";
            SqlCommand cmd1 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Học sinh có mã lớp là " + txtMalop.Text + " từ bảng Thông tin học sinh trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader1.Dispose();
                cmd1.Dispose();

                SqlCommand cmd = new SqlCommand("sp_xoalop", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@malop", txtMalop.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");

                //txtMalop.Text = "";
                //txtTenlop.Text = "";

                Form_Lop_Load(sender, e);
            }
            reader1.Dispose();
            cmd1.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

    }
}
