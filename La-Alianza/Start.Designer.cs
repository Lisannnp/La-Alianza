
namespace La_Alianza
{
    partial class Start
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Start = new System.Windows.Forms.PictureBox();
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(83, 35);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(266, 51);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "LA ALIANZA";
            // 
            // PCB_Start
            // 
            this.PCB_Start.Location = new System.Drawing.Point(92, 111);
            this.PCB_Start.Name = "PCB_Start";
            this.PCB_Start.Size = new System.Drawing.Size(244, 218);
            this.PCB_Start.TabIndex = 3;
            this.PCB_Start.TabStop = false;
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogIn.Location = new System.Drawing.Point(138, 420);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(158, 35);
            this.BTN_LogIn.TabIndex = 7;
            this.BTN_LogIn.Text = "Log In";
            this.BTN_LogIn.UseVisualStyleBackColor = true;
            // 
            // BTN_Register
            // 
            this.BTN_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Register.Location = new System.Drawing.Point(138, 380);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(158, 35);
            this.BTN_Register.TabIndex = 6;
            this.BTN_Register.Text = "Register";
            this.BTN_Register.UseVisualStyleBackColor = true;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(138, 460);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(158, 35);
            this.BTN_Exit.TabIndex = 19;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_LogIn);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.PCB_Start);
            this.Controls.Add(this.LBL_Title);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LA ALIANZA";
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Start;
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.Button BTN_Register;
        private System.Windows.Forms.Button BTN_Exit;
    }
}

