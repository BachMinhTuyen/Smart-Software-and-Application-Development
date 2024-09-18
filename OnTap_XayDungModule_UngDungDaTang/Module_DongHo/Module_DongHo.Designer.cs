namespace Module_DongHo
{
    partial class Module_DongHo
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
            this.lb_DongHo = new System.Windows.Forms.Label();
            this.btn_Start_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_DongHo
            // 
            this.lb_DongHo.AutoSize = true;
            this.lb_DongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DongHo.Location = new System.Drawing.Point(12, 27);
            this.lb_DongHo.Name = "lb_DongHo";
            this.lb_DongHo.Size = new System.Drawing.Size(355, 91);
            this.lb_DongHo.TabIndex = 0;
            this.lb_DongHo.Text = "00:00:00";
            // 
            // btn_Start_End
            // 
            this.btn_Start_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start_End.Location = new System.Drawing.Point(143, 145);
            this.btn_Start_End.Name = "btn_Start_End";
            this.btn_Start_End.Size = new System.Drawing.Size(85, 31);
            this.btn_Start_End.TabIndex = 1;
            this.btn_Start_End.Text = "Start";
            this.btn_Start_End.UseVisualStyleBackColor = true;
            // 
            // Module_DongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Start_End);
            this.Controls.Add(this.lb_DongHo);
            this.Name = "Module_DongHo";
            this.Size = new System.Drawing.Size(383, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DongHo;
        private System.Windows.Forms.Button btn_Start_End;
    }
}
