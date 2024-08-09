
namespace La_Alianza
{
    partial class StartForm
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
            this.PCB_Start = new System.Windows.Forms.PictureBox();
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // PCB_Start
            // 
            this.PCB_Start.Location = new System.Drawing.Point(138, 171);
            this.PCB_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PCB_Start.Name = "PCB_Start";
            this.PCB_Start.Size = new System.Drawing.Size(366, 335);
            this.PCB_Start.TabIndex = 3;
            this.PCB_Start.TabStop = false;
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogIn.Location = new System.Drawing.Point(207, 646);
            this.BTN_LogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(237, 54);
            this.BTN_LogIn.TabIndex = 7;
            this.BTN_LogIn.Text = "Log In";
            this.BTN_LogIn.UseVisualStyleBackColor = true;
            this.BTN_LogIn.Click += new System.EventHandler(this.BTN_LogIn_Click);
            // 
            // BTN_Register
            // 
            this.BTN_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Register.Location = new System.Drawing.Point(207, 585);
            this.BTN_Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(237, 54);
            this.BTN_Register.TabIndex = 6;
            this.BTN_Register.Text = "Register";
            this.BTN_Register.UseVisualStyleBackColor = true;
            this.BTN_Register.Click += new System.EventHandler(this.BTN_Register_Click_1);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(207, 708);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(237, 54);
            this.BTN_Exit.TabIndex = 19;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(126, 54);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(396, 73);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "LA ALIANZA";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 786);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_LogIn);
            this.Controls.Add(this.BTN_Register);
            this.Controls.Add(this.PCB_Start);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PCB_Start;
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.Button BTN_Register;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_Title;
    }
}

