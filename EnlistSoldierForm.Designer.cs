namespace La_Alianza
{
    partial class EnlistSoldierForm
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
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_BackToGeneral = new System.Windows.Forms.Button();
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.Layout3 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Logo = new System.Windows.Forms.PictureBox();
            this.Layout1.SuspendLayout();
            this.Layout3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Name.Location = new System.Drawing.Point(134, 138);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(134, 0, 0, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(62, 20);
            this.LBL_Name.TabIndex = 44;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Add.FlatAppearance.BorderSize = 0;
            this.BTN_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Add.Location = new System.Drawing.Point(162, 209);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(110, 26);
            this.BTN_Add.TabIndex = 41;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = false;
            // 
            // BTN_BackToGeneral
            // 
            this.BTN_BackToGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_BackToGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_BackToGeneral.FlatAppearance.BorderSize = 0;
            this.BTN_BackToGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BackToGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BackToGeneral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_BackToGeneral.Location = new System.Drawing.Point(138, 347);
            this.BTN_BackToGeneral.Name = "BTN_BackToGeneral";
            this.BTN_BackToGeneral.Size = new System.Drawing.Size(158, 35);
            this.BTN_BackToGeneral.TabIndex = 50;
            this.BTN_BackToGeneral.Text = "Back to General";
            this.BTN_BackToGeneral.UseVisualStyleBackColor = false;
            this.BTN_BackToGeneral.Click += new System.EventHandler(this.BTN_BackToGeneral_Click);
            // 
            // Layout1
            // 
            this.Layout1.BackColor = System.Drawing.Color.Transparent;
            this.Layout1.ColumnCount = 1;
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.Controls.Add(this.TXB_Name, 0, 4);
            this.Layout1.Controls.Add(this.Layout3, 0, 1);
            this.Layout1.Controls.Add(this.BTN_BackToGeneral, 0, 8);
            this.Layout1.Controls.Add(this.LBL_Name, 0, 3);
            this.Layout1.Controls.Add(this.BTN_Add, 0, 6);
            this.Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1.Location = new System.Drawing.Point(0, 0);
            this.Layout1.Margin = new System.Windows.Forms.Padding(0);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 10;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.Size = new System.Drawing.Size(434, 411);
            this.Layout1.TabIndex = 51;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXB_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.TXB_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXB_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TXB_Name.Location = new System.Drawing.Point(138, 165);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(0);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(158, 13);
            this.TXB_Name.TabIndex = 40;
            // 
            // Layout3
            // 
            this.Layout3.BackColor = System.Drawing.Color.Transparent;
            this.Layout3.ColumnCount = 2;
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.28111F));
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.71889F));
            this.Layout3.Controls.Add(this.LBL_Title, 0, 0);
            this.Layout3.Controls.Add(this.PCB_Logo, 0, 0);
            this.Layout3.Location = new System.Drawing.Point(0, 20);
            this.Layout3.Margin = new System.Windows.Forms.Padding(0);
            this.Layout3.Name = "Layout3";
            this.Layout3.RowCount = 1;
            this.Layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.Layout3.Size = new System.Drawing.Size(434, 91);
            this.Layout3.TabIndex = 51;
            // 
            // LBL_Title
            // 
            this.LBL_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.LBL_Title.Location = new System.Drawing.Point(75, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(240, 91);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "ENLIST SOLDIERS";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCB_Logo
            // 
            this.PCB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PCB_Logo.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Logo.Location = new System.Drawing.Point(27, 26);
            this.PCB_Logo.Margin = new System.Windows.Forms.Padding(20, 26, 0, 25);
            this.PCB_Logo.Name = "PCB_Logo";
            this.PCB_Logo.Size = new System.Drawing.Size(40, 40);
            this.PCB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Logo.TabIndex = 38;
            this.PCB_Logo.TabStop = false;
            // 
            // EnlistSoldierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Layout1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnlistSoldierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnlistSoldierForm";
            this.Layout1.ResumeLayout(false);
            this.Layout1.PerformLayout();
            this.Layout3.ResumeLayout(false);
            this.Layout3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_BackToGeneral;
        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.TableLayoutPanel Layout3;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Logo;
        private System.Windows.Forms.TextBox TXB_Name;
    }
}