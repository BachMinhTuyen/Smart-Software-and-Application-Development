using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeForms
{
    public class txt_SDT : TextBox
    {
        private ErrorProvider errorProvider;
        public txt_SDT()
        {
            errorProvider = new ErrorProvider();
            this.Validating += Txt_SDT_Validating;
        }

        private void Txt_SDT_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValidPhoneNumber(this.Text))
            {
                errorProvider.SetError(this, "Số điện thoại không hợp lệ!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(this, string.Empty);
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }
    }
}
