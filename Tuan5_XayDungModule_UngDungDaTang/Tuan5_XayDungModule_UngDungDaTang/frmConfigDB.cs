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
    public partial class frmConfigDB : Form
    {
        public frmConfigDB()
        {
            InitializeComponent();
            this.Load += FrmConfigDB_Load;
            this.FormClosed += FrmConfigDB_FormClosed;
        }

        private void FrmConfigDB_FormClosed(object sender, FormClosedEventArgs e)
        {
           Program.frmLogin.Show();
        }

        private void FrmConfigDB_Load(object sender, EventArgs e)
        {
            module_ConfigServer.Saving += Module_ConfigServer_Saving;
            module_ConfigServer.Cancel += Module_ConfigServer_Cancel;
        }

        private void Module_ConfigServer_Cancel(object sender, EventArgs e)
        {
            Program.frmLogin.Show();
        }

        private void Module_ConfigServer_Saving(object sender, EventArgs e)
        {
            string connectionString = module_ConfigServer.ConfigurationDatabase;
            if (connectionString != null)
            {
                Properties.Settings.Default.ConnectionString = connectionString;
                // Save to user.config file (not App.config)
                Properties.Settings.Default.Save();
                MessageBox.Show("Cấu hình thành công!");
            }
            else
            {
                MessageBox.Show("Cấu hình thất bại!");
            }    
        }
    }
}
