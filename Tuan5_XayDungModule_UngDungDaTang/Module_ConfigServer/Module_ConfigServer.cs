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

namespace Module_ConfigServer
{
    public partial class Module_ConfigServer : UserControl
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        string _configurationDatabase = "";
        public event EventHandler Saving, Cancel;

        public string ConfigurationDatabase
        {
            get { return _configurationDatabase; }
            set { _configurationDatabase = value; }
        }
        public Module_ConfigServer()
        {
            InitializeComponent();
            this.btn_Save.Click += btn_Save_Click;
            btn_Cancel.Click += Btn_Cancel_Click;
            this.comboBox_ServerName.DropDown += comboBox_ServerName_DropDown;
            this.comboBox_Database.DropDown += comboBox_Database_DropDown;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Cancel.Invoke(sender, EventArgs.Empty);
        }

        void comboBox_Database_DropDown(object sender, EventArgs e)
        {
            comboBox_Database.DataSource = CauHinh.GetDBName(comboBox_ServerName.Text, txtBox_Username.Text, txtBox_Password.Text);
            comboBox_Database.DisplayMember = "name";
        }

        void comboBox_ServerName_DropDown(object sender, EventArgs e)
        {
            comboBox_ServerName.DataSource = CauHinh.GetServerName();
            comboBox_ServerName.DisplayMember = "ServerName";
        }

        void btn_Save_Click(object sender, EventArgs e)
        {
            _configurationDatabase = "Data Source=" + comboBox_ServerName.Text + ";Initial Catalog=" + comboBox_Database.Text + ";User ID=" + txtBox_Username.Text + ";pwd=" + txtBox_Password.Text + "";
            Saving.Invoke(this, EventArgs.Empty);
        }
    }
}
