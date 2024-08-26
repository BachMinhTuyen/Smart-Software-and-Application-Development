using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan2_ThietKeGiaoDien
{
    public partial class frmMain : Form
    {
        private string username;
        private string password;
        private frmLogin frmLogin;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();

            this.username = frmLogin.Username;
            this.password = frmLogin.Password;
            showUsername();
            this.frmLogin = frmLogin;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            frmLogin.Show();
        }

        public void showUsername()
        {
            statusBar.Text = "Xin chào người dùng: " + username;
        }
    }
}
