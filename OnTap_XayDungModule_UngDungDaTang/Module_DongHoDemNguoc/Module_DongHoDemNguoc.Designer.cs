namespace Module_DongHoDemNguoc
{
    partial class Module_DongHoDemNguoc
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
            this.txtBox_DongHoDemNguoc = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_DongHoDemNguoc
            // 
            this.txtBox_DongHoDemNguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_DongHoDemNguoc.Location = new System.Drawing.Point(15, 12);
            this.txtBox_DongHoDemNguoc.Name = "txtBox_DongHoDemNguoc";
            this.txtBox_DongHoDemNguoc.Size = new System.Drawing.Size(360, 98);
            this.txtBox_DongHoDemNguoc.TabIndex = 0;
            this.txtBox_DongHoDemNguoc.Text = "00:00:00";
            this.txtBox_DongHoDemNguoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Run.Location = new System.Drawing.Point(135, 131);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(96, 35);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            // 
            // Module_DongHoDemNguoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.txtBox_DongHoDemNguoc);
            this.Name = "Module_DongHoDemNguoc";
            this.Size = new System.Drawing.Size(393, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_DongHoDemNguoc;
        private System.Windows.Forms.Button btn_Run;
    }
}
