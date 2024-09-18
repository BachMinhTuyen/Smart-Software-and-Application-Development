using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_DongHoDemNguoc
{
    public partial class Module_DongHoDemNguoc : UserControl
    {
        private Timer henGio;
        private TimeSpan thoiGianConLai;
        private bool running;
        public Module_DongHoDemNguoc()
        {
            InitializeComponent();
            khoiTao();
            btn_Run.Click += Btn_Run_Click;
        }

        private void Btn_Run_Click(object sender, EventArgs e)
        {
            if (running)
            {
                henGio.Stop();
                btn_Run.Text = "Run";
            }
            else
            {
                if (kiemTraDinhDangThoiGianDauVao(out TimeSpan inputTime))
                {
                    thoiGianConLai = inputTime;
                    henGio.Start();
                    btn_Run.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng hh:mm:ss");
                }
            }
            running = !running;
        }

        private bool kiemTraDinhDangThoiGianDauVao(out TimeSpan time)
        {
            time = TimeSpan.Zero;
            if (TimeSpan.TryParse(txtBox_DongHoDemNguoc.Text, out time))
                return true;
            return false;
        }
        private void khoiTao()
        {
            henGio = new Timer();
            henGio.Interval = 1000;
            henGio.Tick += HenGio_Tick;

            thoiGianConLai = TimeSpan.Zero;
            running = false;

            txtBox_DongHoDemNguoc.Text = "00:00:00";
            btn_Run.Text = "Run";
        }

        private void HenGio_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                if (thoiGianConLai.TotalSeconds > 0)
                {
                    thoiGianConLai = thoiGianConLai.Subtract(TimeSpan.FromSeconds(1));
                    txtBox_DongHoDemNguoc.Text = thoiGianConLai.ToString(@"hh\:mm\:ss");
                }
                else
                {
                    henGio.Stop();
                    MessageBox.Show("Hết thời gian!");
                    running = false;
                    btn_Run.Text = "Run";
                }    
            }
        }
    }
}
