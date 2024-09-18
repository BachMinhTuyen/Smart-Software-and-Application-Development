namespace Tuan5_XayDungModule_UngDungDaTang
{
    partial class frmConfigDB
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
            this.module_ConfigServer = new Module_ConfigServer.Module_ConfigServer();
            this.SuspendLayout();
            // 
            // module_ConfigServer
            // 
            this.module_ConfigServer.ConfigurationDatabase = "";
            this.module_ConfigServer.Location = new System.Drawing.Point(13, 13);
            this.module_ConfigServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.module_ConfigServer.Name = "module_ConfigServer";
            this.module_ConfigServer.Size = new System.Drawing.Size(397, 225);
            this.module_ConfigServer.TabIndex = 0;
            // 
            // frmConfigDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 252);
            this.Controls.Add(this.module_ConfigServer);
            this.Name = "frmConfigDB";
            this.Text = "frmConfigDB";
            this.ResumeLayout(false);

        }

        #endregion

        private Module_ConfigServer.Module_ConfigServer module_ConfigServer;
    }
}