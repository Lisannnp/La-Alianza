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
            this.CMB_Base = new System.Windows.Forms.ComboBox();
            this.LBL_Item = new System.Windows.Forms.Label();
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
            this.BTN_LogOut.Location = new System.Drawing.Point(207, 708);
            this.BTN_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(237, 54);
            this.BTN_LogOut.TabIndex = 19;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // CMB_Base
            // 
            this.CMB_Base.FormattingEnabled = true;
            this.CMB_Base.Location = new System.Drawing.Point(210, 212);
            this.CMB_Base.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Base.Name = "CMB_Base";
            this.CMB_Base.Size = new System.Drawing.Size(235, 28);
            this.CMB_Base.TabIndex = 23;
            // 
            // LBL_Item
            // 
            this.LBL_Item.AutoSize = true;
            this.LBL_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Item.Location = new System.Drawing.Point(204, 174);
            this.LBL_Item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Item.Name = "LBL_Item";
            this.LBL_Item.Size = new System.Drawing.Size(69, 30);
            this.LBL_Item.TabIndex = 22;
            this.LBL_Item.Text = "Item:";
            this.LBL_Item.UseWaitCursor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(243, 278);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(165, 38);
            this.BTN_Add.TabIndex = 25;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.Location = new System.Drawing.Point(474, 212);
            this.BTN_Plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(32, 32);
            this.BTN_Plus.TabIndex = 27;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // BTN_Cargament
            // 
            this.BTN_Cargament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Cargament.Location = new System.Drawing.Point(243, 605);
            this.BTN_Cargament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Cargament.Name = "BTN_Cargament";
            this.BTN_Cargament.Size = new System.Drawing.Size(165, 38);
            this.BTN_Cargament.TabIndex = 29;
            this.BTN_Cargament.Text = "Add Package";
            this.BTN_Cargament.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 343);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(345, 231);
            this.dataGridView1.TabIndex = 30;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(72, 39);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(486, 73);
            this.LBL_Title.TabIndex = 31;
            this.LBL_Title.Text = "Add to Package";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScientistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 786);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_Cargament);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.CMB_Base);
            this.Controls.Add(this.LBL_Item);
            this.Controls.Add(this.BTN_LogOut);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScientistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.ComboBox CMB_Base;
        private System.Windows.Forms.Label LBL_Item;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Button BTN_Cargament;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBL_Title;
    }
}