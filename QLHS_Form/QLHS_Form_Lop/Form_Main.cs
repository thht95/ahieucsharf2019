using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_Form_Lop
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            btnMon.Focus();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thoat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMon_Click(object sender, EventArgs e)
        {
            Form_Monhoc frm_monhoc = new Form_Monhoc();
            frm_monhoc.ShowDialog();
            
        }

        private void BtnLop_Click(object sender, EventArgs e)
        {
            Form_Lop frm_lop = new Form_Lop();
            frm_lop.ShowDialog();
        }

        private void BtnHS_Click(object sender, EventArgs e)
        {
            Form_HS frm_hs = new Form_HS();
            frm_hs.ShowDialog();
        }

        private void BtnDiem_Click(object sender, EventArgs e)
        {
            Form_QLDiem frm_diem = new Form_QLDiem();
            frm_diem.ShowDialog();
        }

        private void Btn_DiemCT_Click(object sender, EventArgs e)
        {
            Form_BangDiem frm_diemct = new Form_BangDiem();
            frm_diemct.ShowDialog();
        }



    }
}
