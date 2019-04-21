using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_Form_Lop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Lop());
            //Application.Run(new Form_HS());
            //Application.Run(new Form_QLDiem());
            //Application.Run(new Form_Monhoc());
            //Application.Run(new Form_BangDiem());
            //Application.Run(new Form_RpDiem());
            Application.Run(new Form_Main());
        }
    }
}
