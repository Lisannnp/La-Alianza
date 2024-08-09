namespace La_Alianza
{
    partial class CreateOperationForm
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.CMB_Difficulty = new System.Windows.Forms.ComboBox();
            this.LBL_Difficulty = new System.Windows.Forms.Label();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(6, 9);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(525, 73);
            this.LBL_Title.TabIndex = 47;
            this.LBL_Title.Text = "Create Operation";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(148, 127);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(89, 30);
            this.LBL_Name.TabIndex = 52;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(153, 166);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(235, 26);
            this.TXB_Name.TabIndex = 51;
            // 
            // BTN_Create
            // 
            this.BTN_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Create.Location = new System.Drawing.Point(186, 314);
            this.BTN_Create.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(165, 38);
            this.BTN_Create.TabIndex = 50;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = true;
            // 
            // CMB_Difficulty
            // 
            this.CMB_Difficulty.FormattingEnabled = true;
            this.CMB_Difficulty.Location = new System.Drawing.Point(153, 262);
            this.CMB_Difficulty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Difficulty.Name = "CMB_Difficulty";
            this.CMB_Difficulty.Size = new System.Drawing.Size(235, 28);
            this.CMB_Difficulty.TabIndex = 49;
            // 
            // LBL_Difficulty
            // 
            this.LBL_Difficulty.AutoSize = true;
            this.LBL_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Difficulty.Location = new System.Drawing.Point(147, 224);
            this.LBL_Difficulty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Difficulty.Name = "LBL_Difficulty";
            this.LBL_Difficulty.Size = new System.Drawing.Size(118, 30);
            this.LBL_Difficulty.TabIndex = 48;
            this.LBL_Difficulty.Text = "Difficulty:";
            this.LBL_Difficulty.UseWaitCursor = true;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(152, 378);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(236, 54);
            this.BTN_Exit.TabIndex = 53;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // CreateOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(535, 446);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Create);
            this.Controls.Add(this.CMB_Difficulty);
            this.Controls.Add(this.LBL_Difficulty);
            this.Controls.Add(this.LBL_Title);
            this.Name = "CreateOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOpeationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.ComboBox CMB_Difficulty;
        private System.Windows.Forms.Label LBL_Difficulty;
        private System.Windows.Forms.Button BTN_Exit;
    }
}