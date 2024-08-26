using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    internal class Handle_TextBox
    {
        List<Control> controls = new List<Control>();
        public void addComponents(Panel panel)
        {
            int topPosition = 10;
            int textBoxHeight = 30;
            panel.Height = (textBoxHeight + 10) * 5 + 10;
            panel.Width = 300;

            TextBox textBox1 = new TextBox();
            textBox1.Text = "textBox1";
            textBox1.Top = topPosition;
            textBox1.Left = 10;
            topPosition += textBoxHeight + 10;

            TextBox textBox2 = new TextBox();
            textBox2.Text = "textBox2";
            textBox2.Top = topPosition;
            textBox2.Left = 10;
            topPosition += textBoxHeight + 10;

            TextBox textBox3 = new TextBox();
            textBox3.Text = "textBox3";
            textBox3.Top = topPosition;
            textBox3.Left = 10;
            topPosition += textBoxHeight + 10;

            TextBox textBox4 = new TextBox();
            textBox4.Text = "textBox4";
            textBox4.Top = topPosition;
            textBox4.Left = 10;
            topPosition += textBoxHeight + 10;

            Button button = new Button();
            button.Text = "Process Text Box";
            button.Top = topPosition;
            button.Left = 10;
            button.Width = 200;
            button.Click += new EventHandler(button_Click); ;

            controls.Add(textBox1);
            controls.Add(textBox2);
            controls.Add(textBox3);
            controls.Add(textBox4);
            controls.Add(button);

            panel.Controls.Add(textBox1);
            panel.Controls.Add(textBox2);
            panel.Controls.Add(textBox3);
            panel.Controls.Add(textBox4);
            panel.Controls.Add(button);
        }
        
        public void clearAllTextBoxes(List<Control> ctr)
        {
            foreach (Control item in ctr)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;
                }
            }
        }
        public void button_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes(controls);
        }
    }
}
