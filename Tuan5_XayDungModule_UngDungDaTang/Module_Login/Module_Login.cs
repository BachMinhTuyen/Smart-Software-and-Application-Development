using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Module_Login
{
    public partial class Module_Login : UserControl
    {
        public event EventHandler GetChangeKQ;
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        string _connectionString;
        bool _TT;
        public bool TT
        {
            get { return _TT; }
            set { _TT = value; }
        }
        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public Module_Login()
        {
            InitializeComponent();
            this.btn_Login.Click += btn_Login_Click;
            this.btn_Close.Click += btn_Close_Click;
        }

        void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Username.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lb_Username.Text.ToLower());
                this.txtBox_Username.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtBox_Password.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lb_Password.Text.ToLower());
                this.txtBox_Password.Focus();
                return;
            }
            // Gán chuỗi kết nối database
            CauHinh.ConnectionString = _connectionString;

            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                ProcessConfig();
            }
        }
        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtBox_Username.Text, txtBox_Password.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lb_Username.Text + " Hoặc " + lb_Password.Text);
                _TT = false;
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                _TT = false;
                return;
            }
            // Login Successful!
            MessageBox.Show("Đăng nhập thành công!");

            _TT = true;

            GetChangeKQ.Invoke(this, EventArgs.Empty);
        }
        public void ProcessConfig()
        {
            _TT = false;
            GetChangeKQ.Invoke(this, EventArgs.Empty);
        }
    }
}
