using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class MailTextBox:TextBox
    {
        private ErrorProvider errorProvider;
        public MailTextBox()
        {
            errorProvider = new ErrorProvider();
            this.Validating += MailTextBox_Validating;
        }

        private void MailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Kiểm tra điều kiện chuỗi có chứa @ và .com
            if (!this.Text.Contains("@") || !this.Text.EndsWith(".com"))
            {
                errorProvider.SetError(this, "Email không hợp lệ. Vui lòng nhập email chứa '@' và kết thúc bằng '.com'.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(this, "");
            }
        }
    }
}
