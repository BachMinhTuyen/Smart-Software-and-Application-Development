using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CheckBox_Foods());
            //Application.Run(new TextBoxes_Form());
            //Application.Run(new CaroTable_Form());
            Application.Run(new TextBoxes_DeQuy());
        }
    }
}
