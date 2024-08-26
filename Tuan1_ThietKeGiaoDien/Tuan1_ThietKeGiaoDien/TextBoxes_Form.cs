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
    public partial class TextBoxes_Form : Form
    {
        public TextBoxes_Form()
        {
            InitializeComponent();
            this.Text = "Clear Text In TextBoxes";

            Panel panel = new Panel();
            handle(panel);

            this.Controls.Add(panel);
        }
        public void handle(Panel panel)
        {
            Handle_TextBox handle = new Handle_TextBox();
            handle.addComponents(panel);
        }

    }
}
