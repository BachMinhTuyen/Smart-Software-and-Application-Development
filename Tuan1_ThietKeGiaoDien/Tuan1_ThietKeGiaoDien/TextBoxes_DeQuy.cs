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
    public partial class TextBoxes_DeQuy : Form
    {
        public TextBoxes_DeQuy()
        {
            InitializeComponent();
            this.AutoSize = true;

            Panel panel = new Panel();
            handle(panel);
            this.Controls.Add(panel);
        }
        public void handle(Panel panel)
        {
            Handle_TextBox_DeQuy handle = new Handle_TextBox_DeQuy();
            handle.addComponents(panel);
        }
    }
}
