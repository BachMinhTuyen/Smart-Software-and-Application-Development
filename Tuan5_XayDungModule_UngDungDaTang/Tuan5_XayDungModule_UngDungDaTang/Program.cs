using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_XayDungModule_UngDungDaTang
{
    static class Program
    {
        public static frmConfigDB frmConfigDB = null;
        public static frmLogin frmLogin = null;
        public static frmMain frmMain = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new frmLogin();
            Application.Run(frmLogin);
        }
    }
}
