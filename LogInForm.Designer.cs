
namespace La_Alianza
{
    partial class LogInForm
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.LBL_Password = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXB_Password = new System.Windows.Forms.TextBox();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Start.Location = new System.Drawing.Point(208, 479);
            this.BTN_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(237, 54);
            this.BTN_Start.TabIndex = 11;
            this.BTN_Start.Text = "Back to Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // LBL_Password
            // 
            this.LBL_Password.AutoSize = true;
            this.LBL_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Password.Location = new System.Drawing.Point(202, 276);
            this.LBL_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Password.Name = "LBL_Password";
            this.LBL_Password.Size = new System.Drawing.Size(133, 30);
            this.LBL_Password.TabIndex = 15;
            this.LBL_Password.Text = "Password:";
            this.LBL_Password.UseWaitCursor = true;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(202, 148);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(89, 30);
            this.LBL_Name.TabIndex = 14;
            this.LBL_Name.Text = "Name:";
            // 
            // TXB_Password
            // 
            this.TXB_Password.Location = new System.Drawing.Point(208, 314);
            this.TXB_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Password.Name = "TXB_Password";
            this.TXB_Password.Size = new System.Drawing.Size(235, 26);
            this.TXB_Password.TabIndex = 13;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(207, 187);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(235, 26);
            this.TXB_Name.TabIndex = 12;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(208, 541);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(237, 54);
            this.BTN_Exit.TabIndex = 19;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogIn.Location = new System.Drawing.Point(243, 378);
            this.BTN_LogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(165, 38);
            this.BTN_LogIn.TabIndex = 36;
            this.BTN_LogIn.Text = "Log In";
            this.BTN_LogIn.UseVisualStyleBackColor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(221, 32);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(211, 73);
            this.LBL_Title.TabIndex = 38;
            this.LBL_Title.Text = "Log In";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 616);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_LogIn);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LBL_Password);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Password);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Start);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label LBL_Password;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Password;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.Label LBL_Title;
    }
}