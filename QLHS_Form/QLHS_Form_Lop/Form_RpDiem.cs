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
    public partial class Form_RpDiem : Form
    {
        public Form_RpDiem()
        {
            InitializeComponent();
        }

        SqlConnection cnn;
        String constr = ConfigurationManager.ConnectionStrings["QLHS"].ConnectionString.ToString();

        private void Form_RpDiem_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("Select * from view_tbcanamnew", cnn)
            {
                CommandType = CommandType.Text
            };
            cnn.Open();
            CrystalReport_BangDiem rp = new CrystalReport_BangDiem();

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                rp.SetDataSource(dt);
            }
            crystalReportViewer_BDiem.ReportSource = rp;
            cmd.Dispose();
            cnn.Close();
        }

        private void Form_RpDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            cnn.Close();
        }
    }
}
