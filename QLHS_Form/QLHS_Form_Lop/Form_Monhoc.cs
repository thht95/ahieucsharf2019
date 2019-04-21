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
    public partial class Form_Monhoc : Form
    {
        public Form_Monhoc()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();

        private void Form_Monhoc_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            txtMamon.Enabled = false;
            txtTenmon.Enabled = false;
            txtMamon.Text = "";
            txtTenmon.Text = "";
            btnThem.Focus();
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM view_monhoc", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrMon.DataSource = dt;
            }
        }

        private void Form_Monhoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void dgrMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrMon.RowCount < 0) return;
            txtMamon.Enabled = true;
            txtMamon.ReadOnly = true;
            txtTenmon.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtMamon.Text = dgrMon.CurrentRow.Cells[0].Value.ToString();
            txtTenmon.Text = dgrMon.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMamon.Enabled = true;
            txtMamon.ReadOnly = false;
            txtTenmon.Enabled = true;
            txtMamon.Text = "";
            txtTenmon.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select * from tblMonHoc where sMaMon = '" + txtMamon.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();

            errorProvider1.Clear();
            if (txtMamon.Text == "")
            {
                errorProvider1.SetError(txtMamon, "Mã môn học không được để trống!");
            }
            else if(txtTenmon.Text == "")
            {
                errorProvider1.SetError(txtTenmon, "Tên môn học không được để trống!");
            }
            else if(reader2.Read())
            {
                MessageBox.Show("Đã tồn tại môn học này!", "Thông báo");
            }
            else
            {
                try
                {
                    cmd2.Dispose();
                    reader2.Dispose();
                    //cnn = new SqlConnection(constr);
                    SqlCommand cmd = new SqlCommand("sp_themmon", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cnn.Open();
                    cmd.Parameters.AddWithValue("@mamon", txtMamon.Text.Trim());
                    cmd.Parameters.AddWithValue("@tenmon", txtTenmon.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công", "Thông báo!");
                    Form_Monhoc_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenmon.Text == "")
            {
                errorProvider1.SetError(txtTenmon, "Tên môn học không được để trống!");
            }

            else
            {
                try
                {
                    cnn = new SqlConnection(constr);
                    SqlCommand cmd = new SqlCommand("sp_suamon", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@mamon", txtMamon.Text);
                    cmd.Parameters.AddWithValue("@tenmon", txtTenmon.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");
                    Form_Monhoc_Load(sender, e);
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
            string select = "select sMaMon from tblDiem where sMaMon = '" + txtMamon.Text + "'";
            SqlCommand cmd1 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                {
                    MessageBox.Show("Bạn phải xóa Điểm có mã là " + txtMamon.Text + " từ bảng Điểm thi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader1.Dispose();
                cmd1.Dispose();

                SqlCommand cmd = new SqlCommand("sp_xoamon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mamon", txtMamon.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo!");


                Form_Monhoc_Load(sender, e);
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
