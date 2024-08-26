using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    public class Handle_TextBox_DeQuy
    {
        public void addComponents(Panel panel)
        {
            int topPosition = 10;
            int leftPosition = 20;
            int textBoxHeight = 30;
            //panel.Height = (textBoxHeight + 10) + topPosition;
            panel.Width = 300;
            panel.AutoSize = true;

            TextBox textBox1 = new TextBox();
            textBox1.Text = "textBox1";
            textBox1.Top = topPosition;
            textBox1.Left = leftPosition;
            topPosition += textBoxHeight + 10;

            TextBox textBox2 = new TextBox();
            textBox2.Text = "textBox2";
            textBox2.Top = topPosition;
            textBox2.Left = leftPosition;
            topPosition += textBoxHeight + 10;

            TextBox textBox3 = new TextBox();
            textBox3.Text = "textBox3";
            textBox3.Top = topPosition;
            textBox3.Left = leftPosition;
            topPosition += textBoxHeight + 10;

            TextBox textBox4 = new TextBox();
            textBox4.Text = "textBox4";
            textBox4.Top = topPosition;
            textBox4.Left = leftPosition;
            topPosition += textBoxHeight + 10;

            Button button = new Button();
            button.Text = "Process Text Boxes";
            button.Top = topPosition;
            button.Left = leftPosition;
            button.Width = 200;
            button.Click += new EventHandler(button_Click);

            Panel panel1 = new Panel();
            panel1.Height = (textBoxHeight + 10);
            panel1.AutoSize = true;

            Panel panel2 = new Panel();
            panel2.Height = (textBoxHeight + 10);
            panel2.AutoSize = true;

            Panel panel3 = new Panel();
            panel3.Height = (textBoxHeight + 10);
            panel3.AutoSize = true;

            panel.Controls.Add(textBox1);
            panel.Controls.Add(panel1);
            panel.Controls.Add(button);

            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(panel2);

            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(panel3);

            panel3.Controls.Add(textBox4);
            
        }
        public void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Panel parentPanel = button.Parent as Panel;
            if (parentPanel != null)
            {
                ClearTextBoxes(parentPanel);
            }
        }
        public void ClearTextBoxes(Panel parentPanel) 
        {
            if (parentPanel == null) 
                return;

            // Sử dụng đệ quy để xóa nội dung tất cả các TextBox trong các Panel lồng nhau
            foreach (Control control in parentPanel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Clear();
                }
                else if (control is Panel)
                {
                    Panel panel = control as Panel;
                    ClearTextBoxes(panel);
                }
            }

        }
    }
}
