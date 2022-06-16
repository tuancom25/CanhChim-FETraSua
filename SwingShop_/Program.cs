using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwingShop_
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
               Application.Run(new FrmSaleProduct());
            // Application.Run(new FrmSelectZoneAndTable());
            //Application.Run(new FrmLogin());
            //Application.Run(new FrmPrintOrder_Test());
            //  Application.Run(new FrmOrderBillDisplayTest_());
          //  Application.Run(new FrmBaiTapHienThi());

        }
    }
}
