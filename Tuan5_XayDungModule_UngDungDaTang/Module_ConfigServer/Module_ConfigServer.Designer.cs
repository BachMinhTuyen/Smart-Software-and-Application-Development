namespace Module_ConfigServer
{
    partial class Module_ConfigServer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_ServerName = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Database = new System.Windows.Forms.Label();
            this.comboBox_ServerName = new System.Windows.Forms.ComboBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.comboBox_Database = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_ServerName
            // 
            this.lb_ServerName.AutoSize = true;
            this.lb_ServerName.Location = new System.Drawing.Point(22, 21);
            this.lb_ServerName.Name = "lb_ServerName";
            this.lb_ServerName.Size = new System.Drawing.Size(72, 13);
            this.lb_ServerName.TabIndex = 0;
            this.lb_ServerName.Text = "Server Name:";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(22, 51);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(58, 13);
            this.lb_Username.TabIndex = 1;
            this.lb_Username.Text = "Username:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(22, 83);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(56, 13);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password:";
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(22, 111);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(56, 13);
            this.lb_Database.TabIndex = 3;
            this.lb_Database.Text = "Database:";
            // 
            // comboBox_ServerName
            // 
            this.comboBox_ServerName.FormattingEnabled = true;
            this.comboBox_ServerName.Location = new System.Drawing.Point(104, 18);
            this.comboBox_ServerName.Name = "comboBox_ServerName";
            this.comboBox_ServerName.Size = new System.Drawing.Size(164, 21);
            this.comboBox_ServerName.TabIndex = 4;
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Location = new System.Drawing.Point(104, 48);
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(164, 20);
            this.txtBox_Username.TabIndex = 5;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(104, 80);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(164, 20);
            this.txtBox_Password.TabIndex = 6;
            // 
            // comboBox_Database
            // 
            this.comboBox_Database.FormattingEnabled = true;
            this.comboBox_Database.Location = new System.Drawing.Point(104, 108);
            this.comboBox_Database.Name = "comboBox_Database";
            this.comboBox_Database.Size = new System.Drawing.Size(164, 21);
            this.comboBox_Database.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(104, 144);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Lưu lại";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(193, 144);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Module_ConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.comboBox_Database);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Username);
            this.Controls.Add(this.comboBox_ServerName);
            this.Controls.Add(this.lb_Database);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_ServerName);
            this.Name = "Module_ConfigServer";
            this.Size = new System.Drawing.Size(298, 183);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ServerName;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Database;
        private System.Windows.Forms.ComboBox comboBox_ServerName;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.ComboBox comboBox_Database;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}
