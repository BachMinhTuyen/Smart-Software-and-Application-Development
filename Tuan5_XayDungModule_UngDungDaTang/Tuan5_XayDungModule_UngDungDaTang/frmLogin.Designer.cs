namespace Tuan5_XayDungModule_UngDungDaTang
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.module_Login = new Module_Login.Module_Login();
            this.SuspendLayout();
            // 
            // module_Login
            // 
            this.module_Login.ConnectionString = null;
            this.module_Login.Location = new System.Drawing.Point(29, 36);
            this.module_Login.Name = "module_Login";
            this.module_Login.Size = new System.Drawing.Size(321, 130);
            this.module_Login.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 214);
            this.Controls.Add(this.module_Login);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private Module_Login.Module_Login module_Login;
    }
}