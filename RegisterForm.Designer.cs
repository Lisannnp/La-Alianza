
namespace La_Alianza
{
    partial class RegisterForm
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
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.TXB_Password = new System.Windows.Forms.TextBox();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.LBL_Rol = new System.Windows.Forms.Label();
            this.CMB_Rol = new System.Windows.Forms.ComboBox();
            this.LBL_Base = new System.Windows.Forms.Label();
            this.TXB_Base = new System.Windows.Forms.TextBox();
            this.CMB_Base = new System.Windows.Forms.ComboBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogIn.Location = new System.Drawing.Point(207, 646);
            this.BTN_LogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(237, 54);
            this.BTN_LogIn.TabIndex = 5;
            this.BTN_LogIn.Text = "Log In";
            this.BTN_LogIn.UseVisualStyleBackColor = true;
            this.BTN_LogIn.Click += new System.EventHandler(this.BTN_LogIn_Click);
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(206, 184);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(235, 26);
            this.TXB_Name.TabIndex = 6;
            // 
            // TXB_Password
            // 
            this.TXB_Password.Location = new System.Drawing.Point(206, 292);
            this.TXB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(235, 26);
            this.TXB_Password.TabIndex = 7;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(202, 146);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(89, 30);
            this.LBL_Name.TabIndex = 8;
            this.LBL_Name.Text = "Name:";
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Password.Location = new System.Drawing.Point(201, 254);
            this.LBL_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(133, 30);
            this.LBL_Password.TabIndex = 9;
            this.LBL_Password.Text = "Password:";
            this.LBL_Password.UseWaitCursor = true;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Start.Location = new System.Drawing.Point(207, 585);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(237, 54);
            this.BTN_Start.TabIndex = 10;
            this.BTN_Start.Text = "Back to Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // LBL_Rol
            // 
            this.LBL_Rol.AutoSize = true;
            this.LBL_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Rol.Location = new System.Drawing.Point(202, 361);
            this.LBL_Rol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Rol.Name = "LBL_Rol";
            this.LBL_Rol.Size = new System.Drawing.Size(59, 30);
            this.LBL_Rol.TabIndex = 12;
            this.LBL_Rol.Text = "Rol:";
            this.LBL_Rol.UseWaitCursor = true;
            // 
            // CMB_Rol
            // 
            this.CMB_Rol.FormattingEnabled = true;
            this.CMB_Rol.Location = new System.Drawing.Point(206, 400);
            this.CMB_Rol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Rol.Name = "CMB_Rol";
            this.CMB_Rol.Size = new System.Drawing.Size(235, 28);
            this.CMB_Rol.TabIndex = 13;
            // 
            // LBL_Base
            // 
            this.LBL_Base.AutoSize = true;
            this.LBL_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Base.Location = new System.Drawing.Point(202, 469);
            this.LBL_Base.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Base.Name = "LBL_Base";
            this.LBL_Base.Size = new System.Drawing.Size(78, 30);
            this.LBL_Base.TabIndex = 15;
            this.LBL_Base.Text = "Base:";
            this.LBL_Base.UseWaitCursor = true;
            // 
            // TXB_Base
            // 
            this.TXB_Base.Location = new System.Drawing.Point(208, 508);
            this.TXB_Base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Base.Name = "TXB_Base";
            this.TXB_Base.Size = new System.Drawing.Size(235, 26);
            this.TXB_Base.TabIndex = 14;
            // 
            // CMB_Base
            // 
            this.CMB_Base.FormattingEnabled = true;
            this.CMB_Base.Location = new System.Drawing.Point(208, 508);
            this.CMB_Base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Base.Name = "CMB_Base";
            this.CMB_Base.Size = new System.Drawing.Size(235, 28);
            this.CMB_Base.TabIndex = 17;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(207, 708);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(237, 54);
            this.BTN_Exit.TabIndex = 18;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(193, 28);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(271, 73);
            this.LBL_Title.TabIndex = 37;
            this.LBL_Title.Text = "Register";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 786);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.CMB_Base);
            this.Controls.Add(this.LBL_Base);
            this.Controls.Add(this.TXB_Base);
            this.Controls.Add(this.CMB_Rol);
            this.Controls.Add(this.LBL_Rol);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Password);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_LogIn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.TextBox TXB_Password;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label LBL_Rol;
        private System.Windows.Forms.ComboBox CMB_Rol;
        private System.Windows.Forms.Label LBL_Base;
        private System.Windows.Forms.TextBox TXB_Base;
        private System.Windows.Forms.ComboBox CMB_Base;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_Title;
    }
}