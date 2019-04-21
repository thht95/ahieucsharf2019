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
using System.Text.RegularExpressions;
using System.Globalization;

namespace QLHS_Form_Lop
{
    public partial class Form_QLDiem : Form
    {
        public Form_QLDiem()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();

        private void Form_QLDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSDataSet6.tblHocSinh' table. You can move, or remove it, as needed.
            this.tblHocSinhTableAdapter.Fill(this.qLHSDataSet6.tblHocSinh);
            // TODO: This line of code loads data into the 'qLHSDataSet5.tblMonHoc' table. You can move, or remove it, as needed.
            this.tblMonHocTableAdapter.Fill(this.qLHSDataSet5.tblMonHoc);


            cbHocKi.SelectedIndex = 0;
            cbMaMon.Enabled = false;
            cbMaHS.Enabled = false;
            cbHocKi.Enabled = false;
            mskNamHoc.Enabled = false;
            txtDiemMieng.Enabled = false;
            txtDiem15p.Enabled = false;
            txtDiem45p.Enabled = false;
            txtDiemHK.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;


            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from view_diemtbmhk", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrQLDiem.DataSource = dt;
                
            }
            cmd.Dispose();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbMaMon.Enabled = true;
            cbMaHS.Enabled = true;
            cbHocKi.Enabled = true;
            mskNamHoc.Enabled = true;
            txtDiemMieng.Enabled = true;
            txtDiem15p.Enabled = true;
            txtDiem45p.Enabled = true;
            txtDiemHK.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            mskNamHoc.Clear();
            cbMaMon.SelectedIndex = 0;
            cbMaHS.SelectedIndex = 0;
            cbHocKi.SelectedIndex = 0;
            txtDiemMieng.Text = "";
            txtDiem15p.Text = "";
            txtDiem45p.Text = "";
            txtDiemHK.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            string select = "select sMaMon, sMaHS, iHocKi, sNamHoc from tblDiem where sMaMon = '" + cbMaMon.Text + "' and sMaHS = '" + cbMaHS.Text + "' and iHocKi = '" + cbHocKi.Text + "' and sNamHoc = '" + mskNamHoc.Text + "'";
            SqlCommand cmd2 = new SqlCommand(select, cnn);
            cnn.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();


            errorProvider1.Clear();
            if (mskNamHoc.MaskCompleted == false)
            {
                errorProvider1.SetError(mskNamHoc, "Năm học không được để trống!");
            }
            //Ktra diem mieng
            else if (txtDiemMieng.Text.Length == 0)
            {
                errorProvider1.SetError(txtDiemMieng, "Không được để trống mục này!");
            }
            else if (!Regex.IsMatch(txtDiemMieng.Text, @"^[0-9]*\.?[0-9]+$")) //1. "*" - So sanh chuoi con sau *(VD: A*B = AB, B, AAAB) 2."\." - Tim kiem ky tu "." 3. "?" - Xuat hien 0 hoac 1 lan <=> {0,1}
            {
                errorProvider1.SetError(txtDiemMieng, "Điểm không đúng định dạng!");
            }
            else if (double.Parse(txtDiemMieng.Text, CultureInfo.InvariantCulture) > 10.0)
            {
                errorProvider1.SetError(txtDiemMieng, "Điểm không được lớn hơn 10");
            }
            //Ktra diem 15p
            else if (txtDiem15p.Text.Length == 0)
            {
                errorProvider1.SetError(txtDiem15p, "Không được để trống mục này!");
            }
            else if (!Regex.IsMatch(txtDiem15p.Text, @"^[0-9]*\.?[0-9]+$"))
            {
                errorProvider1.SetError(txtDiemMieng, "Điểm không đúng định dạng!");
            }
            else if (double.Parse(txtDiem15p.Text, CultureInfo.InvariantCulture) > 10.0)
            {
                errorProvider1.SetError(txtDiem15p, "Điểm không được lớn hơn 10");
            }
            //Ktra diem 45p
            else if (txtDiem45p.Text.Length == 0)
            {
                errorProvider1.SetError(txtDiem45p, "Không được để trống mục này!");
            }
            else if (!Regex.IsMatch(txtDiem45p.Text, @"^[0-9]*\.?[0-9]+$"))
            {
                errorProvider1.SetError(txtDiem45p, "Điểm không đúng định dạng!");
            }
            else if (double.Parse(txtDiem45p.Text, CultureInfo.InvariantCulture) > 10.0)
            {
                errorProvider1.SetError(txtDiem45p, "Điểm không được lớn hơn 10");
            }
            //Ktra diem hoc ki
            else if (txtDiemHK.Text.Length == 0)
            {
                errorProvider1.SetError(txtDiemHK, "Không được để trống mục này!");
            }
            else if (!Regex.IsMatch(txtDiemHK.Text, @"^[0-9]*\.?[0-9]+$"))
            {
                errorProvider1.SetError(txtDiemHK, "Điểm không đúng định dạng!");
            }
            else if (double.Parse(txtDiemHK.Text, CultureInfo.InvariantCulture) > 10.0)
            {
                errorProvider1.SetError(txtDiemHK, "Điểm không được lớn hơn 10");
            }

            //Ktra du lieu trung lap
            else if (reader2.Read())
            {
                MessageBox.Show("Dữ liệu đã tồn tại!", "Thông báo");
            }
            else
            {
                //if (cbHocKi.SelectedIndex == 1)
                //{
                //    cmd2.Dispose();
                //    reader2.Dispose();
                //    string select1 = "select sMaMon, sMaHS, sNamHoc from tblDiem where sMaMon = '" + cbMaMon.Text + "' and sMaHS = '" + cbMaHS.Text + "' and iHocKi = 1 and sNamHoc = '" + mskNamHoc.Text + "'"; ;
                //    SqlCommand cmd1 = new SqlCommand(select1, cnn);
                //    SqlDataReader reader1 = cmd1.ExecuteReader();
                //    if(!reader1.Read())
                //    {
                //        MessageBox.Show("Bạn phải thêm điểm học kì 1 trước!", "Thông báo");
                //    }
                //    else
                //    {
                //        cmd1.Dispose();
                //        reader1.Dispose();
                //        SqlCommand cmd = new SqlCommand("sp_themdiem", cnn);
                //        cmd.CommandType = CommandType.StoredProcedure;
                //        cmd.Parameters.AddWithValue("@mamon", cbMaMon.Text);
                //        cmd.Parameters.AddWithValue("@mahs", cbMaHS.Text);
                //        cmd.Parameters.AddWithValue("@hk", cbHocKi.Text);
                //        cmd.Parameters.AddWithValue("@diemm", txtDiemMieng.Text);
                //        cmd.Parameters.AddWithValue("@diem15p", txtDiem15p.Text);
                //        cmd.Parameters.AddWithValue("@diem45p", txtDiem45p.Text);
                //        cmd.Parameters.AddWithValue("@diemthi", txtDiemHK.Text);
                //        cmd.Parameters.AddWithValue("@namhoc", mskNamHoc.Text);
                //        cmd.ExecuteNonQuery();
                //        MessageBox.Show("Thêm mới thành công!", "Thông báo!");
                //        cmd.Dispose();
                //        Form_QLDiem_Load(sender, e);
                //    }

                //}
                //else
                //{
                    try
                    {
                        cmd2.Dispose();
                        reader2.Dispose();
                        SqlCommand cmd = new SqlCommand("sp_themdiem", cnn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mamon", cbMaMon.Text);
                        cmd.Parameters.AddWithValue("@mahs", cbMaHS.Text);
                        cmd.Parameters.AddWithValue("@hk", cbHocKi.Text);
                        cmd.Parameters.AddWithValue("@diemm", txtDiemMieng.Text);
                        cmd.Parameters.AddWithValue("@diem15p", txtDiem15p.Text);
                        cmd.Parameters.AddWithValue("@diem45p", txtDiem45p.Text);
                        cmd.Parameters.AddWithValue("@diemthi", txtDiemHK.Text);
                        cmd.Parameters.AddWithValue("@namhoc", mskNamHoc.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công!", "Thông báo!");
                        cmd.Dispose();
                        Form_QLDiem_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                //}
            }
        }

        private void dgrQLDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = false;
            cbMaMon.Enabled = false;
            cbMaHS.Enabled = false;
            cbHocKi.Enabled = false;
            mskNamHoc.Enabled = false;
            txtDiemMieng.Enabled = true;
            txtDiem15p.Enabled = true;
            txtDiem45p.Enabled = true;
            txtDiemHK.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            if (dgrQLDiem.RowCount < 0) return;
            cbMaMon.Text = dgrQLDiem.CurrentRow.Cells[0].Value.ToString();
            cbMaHS.Text = dgrQLDiem.CurrentRow.Cells[1].Value.ToString();
            cbHocKi.Text = dgrQLDiem.CurrentRow.Cells[3].Value.ToString();
            mskNamHoc.Text = dgrQLDiem.CurrentRow.Cells[2].Value.ToString();
            txtDiemMieng.Text = dgrQLDiem.CurrentRow.Cells[4].Value.ToString();
            txtDiem15p.Text = dgrQLDiem.CurrentRow.Cells[5].Value.ToString();
            txtDiem45p.Text = dgrQLDiem.CurrentRow.Cells[6].Value.ToString();
            txtDiemHK.Text = dgrQLDiem.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_suadiem", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@mamon", cbMaMon.Text);
                cmd.Parameters.AddWithValue("@mahs", cbMaHS.Text);
                cmd.Parameters.AddWithValue("@hk", cbHocKi.Text);
                cmd.Parameters.AddWithValue("@diemm", txtDiemMieng.Text);
                cmd.Parameters.AddWithValue("@diem15p", txtDiem15p.Text);
                cmd.Parameters.AddWithValue("@diem45p", txtDiem45p.Text);
                cmd.Parameters.AddWithValue("@diemthi", txtDiemHK.Text);
                cmd.Parameters.AddWithValue("@namhoc", mskNamHoc.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo!");
                cmd.Dispose();
                Form_QLDiem_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " +ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cnn = new SqlConnection(constr);
                    SqlCommand cmd = new SqlCommand("sp_xoadiem", cnn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@mamon", cbMaMon.Text);
                    cmd.Parameters.AddWithValue("@mahs", cbMaHS.Text);
                    cmd.Parameters.AddWithValue("@hk", cbHocKi.Text);
                    cmd.Parameters.AddWithValue("@namhoc", mskNamHoc.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                    cmd.Dispose();
                    Form_QLDiem_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void Form_QLDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }


    }
}
