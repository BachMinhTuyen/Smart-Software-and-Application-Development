using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class UserTextBox:TextBox
    {
        private ErrorProvider errorProvider;
        public UserTextBox()
        {
            errorProvider = new ErrorProvider();
            this.Validating += UserTextBox_Validating;
        }

        private void UserTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (HasSpecialCharacters(this.Text)) 
            {
                errorProvider.SetError(this, "Không được chứa ký tự đặc biệt.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(this, "");
            }
        }
        public bool HasSpecialCharacters(string text)
        {
            return Regex.IsMatch(text, @"[!@#$%^&*(),.?""{}|<>]");
        }
    }
}
