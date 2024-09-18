using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Module_DongHoBamGio
{
    public partial class Module_DongHoBamGio : UserControl
    {
        private Timer henGio;
        private TimeSpan thoiGianTroiQua;
        private bool running;
        private int lapCount;
        public Module_DongHoBamGio()
        {
            InitializeComponent();
            khoiTao();
            btn_Start_End.Click += Btn_Start_End_Click;
            btn_Lap.Click += Btn_Lap_Click;
        }

        private void Btn_Lap_Click(object sender, EventArgs e)
        {
            string lapTime = thoiGianTroiQua.ToString(@"hh\:mm\:ss\.fff");
            File.AppendAllText("lap_times.txt", $"Lần {lapCount + 1}: {lapTime}{Environment.NewLine}");
            lapCount++;
            MessageBox.Show($"Ghi giờ lần {lapCount}: {lapTime}");
        }

        private void Btn_Start_End_Click(object sender, EventArgs e)
        {
            if (running)
            {
                henGio.Stop();
                btn_Start_End.Text = "Start";
                btn_Lap.Enabled = false;
            }
            else
            {
                henGio.Start();
                btn_Start_End.Text = "Stop";
                btn_Lap.Enabled = true;
            }
            running = !running;
        }

        private void khoiTao()
        {
            henGio = new Timer();
            henGio.Interval = 50; 
            henGio.Tick += HenGio_Tick;

            thoiGianTroiQua = TimeSpan.Zero;
            lapCount = 0;

            lb_DongHoBamGio.Text = thoiGianTroiQua.ToString(@"hh\:mm\:ss\.fff");
            btn_Lap.Enabled = false;
        }

        private void HenGio_Tick(object sender, EventArgs e)
        {
            if (running)
            {
                thoiGianTroiQua = thoiGianTroiQua.Add(TimeSpan.FromMilliseconds(50));
                lb_DongHoBamGio.Text = thoiGianTroiQua.ToString(@"hh\:mm\:ss\.fff");
            }
        }
    }
}
