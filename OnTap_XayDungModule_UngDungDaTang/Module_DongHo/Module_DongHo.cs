using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_DongHo
{
    public partial class Module_DongHo : UserControl
    {
        private Timer henGio;
        private TimeSpan thoiGianTroiQua;
        private bool running;
        public Module_DongHo()
        {
            InitializeComponent();
            khoiTao();
            btn_Start_End.Click += Btn_Start_End_Click;
        }

        private void Btn_Start_End_Click(object sender, EventArgs e)
        {
            if (running)
            {
                henGio.Stop();
                btn_Start_End.Text = "Start";
            }
            else
            {
                henGio.Start();
                btn_Start_End.Text = "Stop";
            }
            running = !running;
        }

        public void khoiTao()
        {
            thoiGianTroiQua = TimeSpan.Zero;
            running = false;

            henGio = new Timer();
            henGio.Interval = 1000; // 1000ms = 1s
            henGio.Tick += HenGio_Tick;

            lb_DongHo.Text = thoiGianTroiQua.ToString(@"hh\:mm\:ss");
            btn_Start_End.Text = "Start";
        }

        private void HenGio_Tick(object sender, EventArgs e)
        {
            thoiGianTroiQua = thoiGianTroiQua.Add(TimeSpan.FromSeconds(1));
            lb_DongHo.Text = thoiGianTroiQua.ToString(@"hh\:mm\:ss");

            if (thoiGianTroiQua.TotalHours >= 1)
            {
                henGio.Stop();
                MessageBox.Show("Đã chạy 1 tiếng đồng hồ!");
                reset_DongHo();
            }
        }
        private void reset_DongHo()
        {
            thoiGianTroiQua = TimeSpan.Zero;
            lb_DongHo.Text = thoiGianTroiQua.ToString(@"hh\:mm\:ss");
            btn_Start_End.Text = "Start";
            running = false;
        }
    }
}
