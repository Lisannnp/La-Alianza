
namespace La_Alianza
{
    partial class LogIn
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
            this.BTN_Inicio = new System.Windows.Forms.Button();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXB_Password = new System.Windows.Forms.TextBox();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Inicio
            // 
            this.BTN_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Inicio.Location = new System.Drawing.Point(138, 420);
            this.BTN_Inicio.Name = "BTN_Inicio";
            this.BTN_Inicio.Size = new System.Drawing.Size(158, 35);
            this.BTN_Inicio.TabIndex = 11;
            this.BTN_Inicio.Text = "Back to Start";
            this.BTN_Inicio.UseVisualStyleBackColor = true;
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Password.Location = new System.Drawing.Point(135, 191);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(94, 22);
            this.LBL_Password.TabIndex = 15;
            this.LBL_Password.Text = "Password:";
            this.LBL_Password.UseWaitCursor = true;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(135, 108);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(62, 22);
            this.LBL_Name.TabIndex = 14;
            this.LBL_Name.Text = "Name:";
            // 
            // TXB_Password
            // 
            this.TXB_Password.Location = new System.Drawing.Point(139, 216);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(158, 20);
            this.TXB_Password.TabIndex = 13;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(138, 133);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(158, 20);
            this.TXB_Name.TabIndex = 12;
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Password);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Inicio);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Inicio;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Password;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Button BTN_Exit;
    }
}