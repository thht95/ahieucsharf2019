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
    public partial class Form_ChiTietDiem : Form
    {
        public Form_ChiTietDiem()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();

        private void Form_ChiTietDiem_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("sp_bangdiem_ct", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            cmd.Parameters.AddWithValue("@malop",Form_BangDiem.malop);
            cmd.Parameters.AddWithValue("@mahs", Form_BangDiem.mahs);
            cmd.Parameters.AddWithValue("@namhoc", Form_BangDiem.namhoc);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgrCTDiem.DataSource = dt;
            }
            cmd.Dispose();
            cnn.Close();
        }

        private void Form_ChiTietDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Form_BangDiem.namhoc = "";
            //Form_BangDiem.mahs = "";
            //Form_BangDiem.malop = "";
            cnn.Close();
        }

    }
}
