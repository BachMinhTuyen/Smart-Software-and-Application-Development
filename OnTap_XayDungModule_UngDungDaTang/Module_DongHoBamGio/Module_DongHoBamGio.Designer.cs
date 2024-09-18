namespace Module_DongHoBamGio
{
    partial class Module_DongHoBamGio
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
            this.lb_DongHoBamGio = new System.Windows.Forms.Label();
            this.btn_Start_End = new System.Windows.Forms.Button();
            this.btn_Lap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_DongHoBamGio
            // 
            this.lb_DongHoBamGio.AutoSize = true;
            this.lb_DongHoBamGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DongHoBamGio.Location = new System.Drawing.Point(21, 32);
            this.lb_DongHoBamGio.Name = "lb_DongHoBamGio";
            this.lb_DongHoBamGio.Size = new System.Drawing.Size(513, 91);
            this.lb_DongHoBamGio.TabIndex = 0;
            this.lb_DongHoBamGio.Text = "00:00:00.000";
            // 
            // btn_Start_End
            // 
            this.btn_Start_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start_End.Location = new System.Drawing.Point(110, 146);
            this.btn_Start_End.Name = "btn_Start_End";
            this.btn_Start_End.Size = new System.Drawing.Size(89, 35);
            this.btn_Start_End.TabIndex = 1;
            this.btn_Start_End.Text = "Start";
            this.btn_Start_End.UseVisualStyleBackColor = true;
            // 
            // btn_Lap
            // 
            this.btn_Lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lap.Location = new System.Drawing.Point(319, 146);
            this.btn_Lap.Name = "btn_Lap";
            this.btn_Lap.Size = new System.Drawing.Size(89, 35);
            this.btn_Lap.TabIndex = 2;
            this.btn_Lap.Text = "Lap";
            this.btn_Lap.UseVisualStyleBackColor = true;
            // 
            // Module_DongHoBamGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Lap);
            this.Controls.Add(this.btn_Start_End);
            this.Controls.Add(this.lb_DongHoBamGio);
            this.Name = "Module_DongHoBamGio";
            this.Size = new System.Drawing.Size(555, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_DongHoBamGio;
        private System.Windows.Forms.Button btn_Start_End;
        private System.Windows.Forms.Button btn_Lap;
    }
}
