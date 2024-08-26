using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    public partial class CaroTable_Form : Form
    {
        public CaroTable_Form()
        {
            InitializeComponent();
            this.Text = "Caro Table";
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Panel panel = new Panel();
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.AutoScroll = true;
            handle(panel);
            this.Controls.Add(panel);
        }
        public void handle(Panel panel)
        {
            Handle_CaroTable handle_CaroTable = new Handle_CaroTable();
            handle_CaroTable.addComponents(panel);
        }
    }
}
