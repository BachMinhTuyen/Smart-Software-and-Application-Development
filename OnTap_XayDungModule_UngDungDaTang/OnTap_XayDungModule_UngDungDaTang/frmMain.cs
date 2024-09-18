using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;

namespace OnTap_XayDungModule_UngDungDaTang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btn_KiemTraChuoiHoaThuongXenKe.Click += Btn_KiemTraChuoiHoaThuongXenKe_Click;
            btn_KiemTraChuoiSo.Click += Btn_KiemTraChuoiSo_Click;
            btn_KiemTraCCCD.Click += Btn_KiemTraCCCD_Click;
        }

        private void Btn_KiemTraChuoiSo_Click(object sender, EventArgs e)
        {
            string input = txtBox_StringInput.Text;
            bool result = XuLyChuoi.kiemTraChuoiSo(input);
            if (result == true)
            {
                MessageBox.Show("Chuỗi số!");
            }
            else
            {
                MessageBox.Show("Không phải chuỗi số");
            }
        }

        private void Btn_KiemTraChuoiHoaThuongXenKe_Click(object sender, EventArgs e)
        {
            string input = txtBox_StringInput.Text;
            bool result = XuLyChuoi.kiemTraChuoiHoaThuongXenKe(input);
            if (result == true)
            {
                MessageBox.Show("Chuỗi hoa thường xen kẽ!");
            }
            else
            {
                MessageBox.Show("Không phải chuỗi hoa thường xen kẽ");
            }
        }

        private void Btn_KiemTraCCCD_Click(object sender, EventArgs e)
        {
            string input = txtBox_StringInput.Text;
            bool result = XuLyChuoi.KiemTraCCCD(input);
            if (result == true)
            {
                MessageBox.Show("Là căn cước công dân!");
            }
            else
            {
                MessageBox.Show("Không phải căn cước công dân");
            }
        }
    }
}
