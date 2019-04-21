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
    public partial class Form_BangDiem : Form
    {
        public Form_BangDiem()
        {
            InitializeComponent();
        }
        public static string malop = "";
        public static string mahs = "";
        public static string namhoc = "";

        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();

        private void Form_BangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSDataSet9.tblHocSinh' table. You can move, or remove it, as needed.
            this.tblHocSinhTableAdapter.Fill(this.qLHSDataSet9.tblHocSinh);
            // TODO: This line of code loads data into the 'qLHSDataSet8.view_namhoc' table. You can move, or remove it, as needed.
            this.view_namhocTableAdapter.Fill(this.qLHSDataSet8.view_namhoc);
            // TODO: This line of code loads data into the 'qLHSDataSet7.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.qLHSDataSet7.tblLop);

            malop = "";
            mahs = "";
            namhoc = "";
            
            cboMaLop.Checked = false;
            cboNamHoc.Checked = false;
            btnChiTiet.Enabled = false;
            cbMaLop.Enabled = false;
            cbNamHoc.Enabled = false;


            cnn = new SqlConnection(constr);
            SqlCommand sqlCommand = new SqlCommand("Select * from view_tbcanam", cnn);
            SqlCommand cmd = sqlCommand;
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrDiemCT.DataSource = dt;
            }
            cmd.Dispose();
            cnn.Close();
        }

        private void CboMaLop_CheckedChanged(object sender, EventArgs e)
        {
            if(cboMaLop.Checked == true)
            {
                cbMaLop.Enabled = true;
                //malop = cbMaLop.Text;
            }
            else
            {
                cbMaLop.Enabled = false;
                malop = "";
            }
        }

        private void CboNamHoc_CheckedChanged(object sender, EventArgs e)
        {
            if(cboNamHoc.Checked == true)
            {
                cbNamHoc.Enabled = true;
                //namhoc = cbNamHoc.Text;
            }
            else
            {
                cbNamHoc.Enabled = false;
                namhoc = "";
            }
        }

        private void BtnXemDS_Click(object sender, EventArgs e)
        {

            string malop = "";
            string namhoc = "";

           if(cboMaLop.Checked == true)
           {
               malop = cbMaLop.Text;
               if(cboNamHoc.Checked == true)
               {
                   namhoc = cbNamHoc.Text;
                    SqlCommand sqlCommand = new SqlCommand("sp_bangdiem_search1", cnn);
                    SqlCommand cmd = sqlCommand;
                   cmd.CommandType = CommandType.StoredProcedure;
                   cnn.Open();
                   cmd.Parameters.AddWithValue("@malop", malop);
                   cmd.Parameters.AddWithValue("@namhoc", namhoc);
                   DataTable dt = new DataTable();
                   SqlDataReader dr = cmd.ExecuteReader();
                   dt.Load(dr);
                   if (dt.Rows.Count > 0)
                   {
                       dgrDiemCT.DataSource = dt;

                   }
                   else
                   {
                       MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK);
                   }
                   dr.Dispose();
                   cmd.Dispose();
                   cnn.Close();
               }
               else
               {
                    SqlCommand cmd = new SqlCommand("sp_bangdiem_search1", cnn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cnn.Open();
                   cmd.Parameters.AddWithValue("@malop", malop);
                   cmd.Parameters.AddWithValue("@namhoc", namhoc);
                   DataTable dt = new DataTable();
                   SqlDataReader dr = cmd.ExecuteReader();
                   dt.Load(dr);
                   if (dt.Rows.Count > 0)
                   {
                       dgrDiemCT.DataSource = dt;

                   }
                   else
                   {
                       MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK);
                   }
                   dr.Dispose();
                   cmd.Dispose();
                   cnn.Close();
               }
               
           }
           else
           {
               if(cboNamHoc.Checked == true)
               {
                   namhoc = cbNamHoc.Text;
                    SqlCommand cmd = new SqlCommand("sp_bangdiem_search1", cnn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cnn.Open();
                   cmd.Parameters.AddWithValue("@malop", malop);
                   cmd.Parameters.AddWithValue("@namhoc", namhoc);
                   DataTable dt = new DataTable();
                   SqlDataReader dr = cmd.ExecuteReader();
                   dt.Load(dr);
                   if (dt.Rows.Count > 0)
                   {
                       dgrDiemCT.DataSource = dt;

                   }
                   else
                   {
                       MessageBox.Show("Không tìm thấy dữ liệu phù hợp!", "Thông báo", MessageBoxButtons.OK);
                   }
                   dr.Dispose();
                   cmd.Dispose();
                   cnn.Close();
               }

               else
               {
                    //cnn.Close();
                    Form_BangDiem_Load(sender, e);
               }
           }
        }

        private void Form_BangDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void DgrDiemCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChiTiet.Enabled = true;
            if (dgrDiemCT.RowCount < 0) return;
            cbMaLop.Text = dgrDiemCT.CurrentRow.Cells[0].Value.ToString();
            cbNamHoc.Text = dgrDiemCT.CurrentRow.Cells[4].Value.ToString();
            malop = cbMaLop.Text;
            mahs = dgrDiemCT.CurrentRow.Cells[2].Value.ToString();
            namhoc = cbNamHoc.Text;
        }

        private void BtnChiTiet_Click(object sender, EventArgs e)
        {
            cnn.Close();
            Form_ChiTietDiem frm_ctdiem = new Form_ChiTietDiem();
            frm_ctdiem.ShowDialog();
            
        }

        private void BtnInDS_Click(object sender, EventArgs e)
        {
            cnn.Close();
            Form_RpDiem frm_bdrp = new Form_RpDiem();
            frm_bdrp.ShowDialog();
        }


    }
}
