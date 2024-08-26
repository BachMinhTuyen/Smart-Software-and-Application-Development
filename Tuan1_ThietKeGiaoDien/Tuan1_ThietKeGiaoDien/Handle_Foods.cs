using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    internal class Handle_Foods
    {
        public void addCheckBox(Panel panel, string[] lst)
        {
            int topPosition = 10;
            int checkBoxHeight = 30;
            panel.Height = (checkBoxHeight + 10) * lst.Length + 10;
            panel.Width = 200;

            foreach (string item in lst)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Left = 10;
                checkBox.Top = topPosition;
                topPosition += checkBoxHeight;
                checkBox.Text = item;
                panel.Controls.Add(checkBox);
            }
        }
    }
}
