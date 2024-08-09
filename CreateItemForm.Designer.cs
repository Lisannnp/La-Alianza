namespace La_Alianza
{
    partial class CreateItemForm
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
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMB_Category = new System.Windows.Forms.ComboBox();
            this.LBL_Category = new System.Windows.Forms.Label();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(130, 163);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(89, 30);
            this.LBL_Name.TabIndex = 38;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(135, 202);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(235, 26);
            this.TXB_Name.TabIndex = 37;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(165, 351);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(165, 38);
            this.BTN_Add.TabIndex = 35;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // CMB_Category
            // 
            this.CMB_Category.FormattingEnabled = true;
            this.CMB_Category.Location = new System.Drawing.Point(135, 298);
            this.CMB_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Category.Name = "CMB_Category";
            this.CMB_Category.Size = new System.Drawing.Size(235, 28);
            this.CMB_Category.TabIndex = 34;
            // 
            // LBL_Category
            // 
            this.LBL_Category.AutoSize = true;
            this.LBL_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Category.Location = new System.Drawing.Point(129, 260);
            this.LBL_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Category.Name = "LBL_Category";
            this.LBL_Category.Size = new System.Drawing.Size(124, 30);
            this.LBL_Category.TabIndex = 33;
            this.LBL_Category.Text = "Category:";
            this.LBL_Category.UseWaitCursor = true;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.Location = new System.Drawing.Point(133, 425);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(237, 54);
            this.BTN_Exit.TabIndex = 39;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(67, 31);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(359, 73);
            this.LBL_Title.TabIndex = 41;
            this.LBL_Title.Text = "Make items";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(501, 493);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.CMB_Category);
            this.Controls.Add(this.LBL_Category);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMB_Category;
        private System.Windows.Forms.Label LBL_Category;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_Title;
    }
}