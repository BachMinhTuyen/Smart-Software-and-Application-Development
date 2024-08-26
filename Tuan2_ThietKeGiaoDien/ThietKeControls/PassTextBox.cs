using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class PassTextBox: TextBox
    {
        private ErrorProvider errorProvider;
        public PassTextBox()
        {
            errorProvider = new ErrorProvider();
            this.Validating += PassTextBox_Validating;
        }

        private void PassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!HasSpecialCharacters(this.Text) || this.Text.Length < 6)
            {
                errorProvider.SetError(this, "Phải chứa ký tự đặc biệt và có độ dài 6 ký tự");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(this, "");
            }
        }
        private bool HasSpecialCharacters(string text)
        {
            return Regex.IsMatch(text, @"[!@#$%^&*(),.?""{}|<>]");
        }
    }
}
