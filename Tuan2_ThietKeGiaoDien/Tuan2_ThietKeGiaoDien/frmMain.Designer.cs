namespace Tuan2_ThietKeGiaoDien
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.lb_numericTextBox = new System.Windows.Forms.Label();
            this.lb_UpperTextBox = new System.Windows.Forms.Label();
            this.lb_MailTextBox = new System.Windows.Forms.Label();
            this.lb_UserTextBox = new System.Windows.Forms.Label();
            this.lb_PassTextBox = new System.Windows.Forms.Label();
            this.passTextBox1 = new ThietKeControls.PassTextBox();
            this.userTextBox1 = new ThietKeControls.UserTextBox();
            this.mailTextBox1 = new ThietKeControls.MailTextBox();
            this.upperTextBox1 = new ThietKeControls.UpperTextBox();
            this.numericTextBox = new ThietKeControls.NumericTextBox();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Edit";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "View";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 221);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(530, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "Xin chào người dùng ...";
            // 
            // lb_numericTextBox
            // 
            this.lb_numericTextBox.AutoSize = true;
            this.lb_numericTextBox.Location = new System.Drawing.Point(40, 27);
            this.lb_numericTextBox.Name = "lb_numericTextBox";
            this.lb_numericTextBox.Size = new System.Drawing.Size(58, 16);
            this.lb_numericTextBox.TabIndex = 1;
            this.lb_numericTextBox.Text = "Nhập số";
            // 
            // lb_UpperTextBox
            // 
            this.lb_UpperTextBox.AutoSize = true;
            this.lb_UpperTextBox.Location = new System.Drawing.Point(40, 62);
            this.lb_UpperTextBox.Name = "lb_UpperTextBox";
            this.lb_UpperTextBox.Size = new System.Drawing.Size(90, 16);
            this.lb_UpperTextBox.TabIndex = 3;
            this.lb_UpperTextBox.Text = "Nhập chữ hoa";
            // 
            // lb_MailTextBox
            // 
            this.lb_MailTextBox.AutoSize = true;
            this.lb_MailTextBox.Location = new System.Drawing.Point(40, 99);
            this.lb_MailTextBox.Name = "lb_MailTextBox";
            this.lb_MailTextBox.Size = new System.Drawing.Size(76, 16);
            this.lb_MailTextBox.TabIndex = 5;
            this.lb_MailTextBox.Text = "Nhập email";
            // 
            // lb_UserTextBox
            // 
            this.lb_UserTextBox.AutoSize = true;
            this.lb_UserTextBox.Location = new System.Drawing.Point(40, 137);
            this.lb_UserTextBox.Name = "lb_UserTextBox";
            this.lb_UserTextBox.Size = new System.Drawing.Size(103, 16);
            this.lb_UserTextBox.TabIndex = 6;
            this.lb_UserTextBox.Text = "Nhập username";
            // 
            // lb_PassTextBox
            // 
            this.lb_PassTextBox.AutoSize = true;
            this.lb_PassTextBox.Location = new System.Drawing.Point(40, 175);
            this.lb_PassTextBox.Name = "lb_PassTextBox";
            this.lb_PassTextBox.Size = new System.Drawing.Size(102, 16);
            this.lb_PassTextBox.TabIndex = 7;
            this.lb_PassTextBox.Text = "Nhập password";
            // 
            // passTextBox1
            // 
            this.passTextBox1.Location = new System.Drawing.Point(157, 172);
            this.passTextBox1.Name = "passTextBox1";
            this.passTextBox1.Size = new System.Drawing.Size(266, 22);
            this.passTextBox1.TabIndex = 10;
            // 
            // userTextBox1
            // 
            this.userTextBox1.Location = new System.Drawing.Point(157, 134);
            this.userTextBox1.Name = "userTextBox1";
            this.userTextBox1.Size = new System.Drawing.Size(266, 22);
            this.userTextBox1.TabIndex = 9;
            // 
            // mailTextBox1
            // 
            this.mailTextBox1.Location = new System.Drawing.Point(157, 96);
            this.mailTextBox1.Name = "mailTextBox1";
            this.mailTextBox1.Size = new System.Drawing.Size(266, 22);
            this.mailTextBox1.TabIndex = 8;
            // 
            // upperTextBox1
            // 
            this.upperTextBox1.Location = new System.Drawing.Point(157, 59);
            this.upperTextBox1.Name = "upperTextBox1";
            this.upperTextBox1.Size = new System.Drawing.Size(266, 22);
            this.upperTextBox1.TabIndex = 4;
            // 
            // numericTextBox
            // 
            this.numericTextBox.Location = new System.Drawing.Point(157, 24);
            this.numericTextBox.Name = "numericTextBox";
            this.numericTextBox.Size = new System.Drawing.Size(266, 22);
            this.numericTextBox.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 243);
            this.Controls.Add(this.passTextBox1);
            this.Controls.Add(this.userTextBox1);
            this.Controls.Add(this.mailTextBox1);
            this.Controls.Add(this.lb_PassTextBox);
            this.Controls.Add(this.lb_UserTextBox);
            this.Controls.Add(this.lb_MailTextBox);
            this.Controls.Add(this.upperTextBox1);
            this.Controls.Add(this.lb_UpperTextBox);
            this.Controls.Add(this.numericTextBox);
            this.Controls.Add(this.lb_numericTextBox);
            this.Controls.Add(this.statusBar);
            this.Menu = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "Thành Phần Xây Dựng Sẵn Của .NET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.Label lb_numericTextBox;
        private ThietKeControls.NumericTextBox numericTextBox;
        private System.Windows.Forms.Label lb_UpperTextBox;
        private ThietKeControls.UpperTextBox upperTextBox1;
        private System.Windows.Forms.Label lb_MailTextBox;
        private System.Windows.Forms.Label lb_UserTextBox;
        private System.Windows.Forms.Label lb_PassTextBox;
        private ThietKeControls.MailTextBox mailTextBox1;
        private ThietKeControls.UserTextBox userTextBox1;
        private ThietKeControls.PassTextBox passTextBox1;
    }
}

