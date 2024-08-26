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
    public partial class CheckBox_Foods : Form
    {
        public CheckBox_Foods()
        {
            InitializeComponent();
            this.Text = "Food Selection";

            Panel panel = new Panel();
            handle(panel);
            this.Controls.Add(panel);
        }

        public void handle(Panel panel)
        {
            Handle_Foods handle_Foods = new Handle_Foods();

            string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            handle_Foods.addCheckBox(panel, foods);
        }
    }
}
