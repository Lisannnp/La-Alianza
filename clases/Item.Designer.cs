namespace La_Alianza
{
    partial class Item
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMB_Category = new System.Windows.Forms.ComboBox();
            this.LBL_Category = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(87, 106);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(62, 22);
            this.LBL_Name.TabIndex = 38;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(90, 131);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(158, 20);
            this.TXB_Name.TabIndex = 37;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(48, 39);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(239, 51);
            this.LBL_Title.TabIndex = 36;
            this.LBL_Title.Text = "Make / Add";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(112, 246);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(110, 25);
            this.BTN_Add.TabIndex = 35;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // CMB_Category
            // 
            this.CMB_Category.FormattingEnabled = true;
            this.CMB_Category.Location = new System.Drawing.Point(90, 194);
            this.CMB_Category.Name = "CMB_Category";
            this.CMB_Category.Size = new System.Drawing.Size(158, 21);
            this.CMB_Category.TabIndex = 34;
            // 
            // LBL_Category
            // 
            this.LBL_Category.AutoSize = true;
            this.LBL_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Category.Location = new System.Drawing.Point(86, 169);
            this.LBL_Category.Name = "LBL_Category";
            this.LBL_Category.Size = new System.Drawing.Size(88, 22);
            this.LBL_Category.TabIndex = 33;
            this.LBL_Category.Text = "Category:";
            this.LBL_Category.UseWaitCursor = true;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.CMB_Category);
            this.Controls.Add(this.LBL_Category);
            this.Name = "Item";
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMB_Category;
        private System.Windows.Forms.Label LBL_Category;
    }
}