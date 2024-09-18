using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan5_XayDungModule_UngDungDaTang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Load += frmLogin_Load;
        }

        void frmLogin_Load(object sender, EventArgs e)
        {
            // Get connection string from App.config (Read-Only)
            //Properties.Settings.Default.Reset(); 

            // Reload user.config file
            Properties.Settings.Default.Reload();

            // Get connection string from user.config file
            string conn = Properties.Settings.Default.ConnectionString;

            module_Login.ConnectionString = Properties.Settings.Default.ConnectionString;
            module_Login.GetChangeKQ += module_Login_GetChangeKQ;
        }

        void module_Login_GetChangeKQ(object sender, EventArgs e)
        {
            if (module_Login.TT == true)
            {
                if (Program.frmMain == null || Program.frmMain.IsDisposed)
                {
                    Program.frmMain = new frmMain();
                }
                this.Visible = false;
                Program.frmMain.Show();
            }
            else
            {
                if (Program.frmConfigDB == null || Program.frmConfigDB.IsDisposed)
                {
                    Program.frmConfigDB = new frmConfigDB();
                }
                this.Visible = false;
                Program.frmConfigDB.Show();
            }
        }
    }
}
