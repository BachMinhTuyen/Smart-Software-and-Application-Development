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
    public partial class frmLogin : Form
    {
        private string username;
        private string password;
        public frmLogin()
        {
            InitializeComponent();

            txtBox_Password.PasswordChar = '*';
            btn_Login.Click += new EventHandler(btnLogin_Click);
            btn_Cancel.Click += Btn_Cancel_Click;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtBox_Username.Text.Trim();
            password = txtBox_Password.Text.Trim();
            if (username != null && username != "")
            {
                handleLogin();
            }
            else
            {
                MessageBox.Show("Phải nhập username và password");
            }
        }
        public void handleLogin()
        {
            frmMain frmMain = new frmMain(this);
            frmMain.Show();
            this.Hide();
        }
    }
}
