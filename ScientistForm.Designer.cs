namespace La_Alianza
{
    partial class ScientistForm
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
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.LBL_Item = new System.Windows.Forms.Label();
            this.CMB_Base = new System.Windows.Forms.ComboBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.BTN_Cargament = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBL_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.Location = new System.Drawing.Point(138, 460);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(158, 35);
            this.BTN_LogOut.TabIndex = 19;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // LBL_Item
            // 
            this.LBL_Item.AutoSize = true;
            this.LBL_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Item.Location = new System.Drawing.Point(136, 113);
            this.LBL_Item.Name = "LBL_Item";
            this.LBL_Item.Size = new System.Drawing.Size(48, 22);
            this.LBL_Item.TabIndex = 22;
            this.LBL_Item.Text = "Item:";
            this.LBL_Item.UseWaitCursor = true;
            // 
            // CMB_Base
            // 
            this.CMB_Base.FormattingEnabled = true;
            this.CMB_Base.Location = new System.Drawing.Point(140, 138);
            this.CMB_Base.Name = "CMB_Base";
            this.CMB_Base.Size = new System.Drawing.Size(158, 21);
            this.CMB_Base.TabIndex = 23;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(162, 181);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(110, 25);
            this.BTN_Add.TabIndex = 25;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.Location = new System.Drawing.Point(316, 138);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus.TabIndex = 27;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // BTN_Cargament
            // 
            this.BTN_Cargament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Cargament.Location = new System.Drawing.Point(162, 393);
            this.BTN_Cargament.Name = "BTN_Cargament";
            this.BTN_Cargament.Size = new System.Drawing.Size(110, 25);
            this.BTN_Cargament.TabIndex = 29;
            this.BTN_Cargament.Text = "Add Package";
            this.BTN_Cargament.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(230, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(48, 25);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(326, 51);
            this.LBL_Title.TabIndex = 31;
            this.LBL_Title.Text = "Add to Package";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScientistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Cargament);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.CMB_Base);
            this.Controls.Add(this.LBL_Item);
            this.Controls.Add(this.BTN_LogOut);
            this.Name = "ScientistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Label LBL_Item;
        private System.Windows.Forms.ComboBox CMB_Base;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Button BTN_Cargament;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_Title;
    }
}