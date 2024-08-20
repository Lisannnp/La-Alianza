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
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_Category = new System.Windows.Forms.Label();
            this.BTN_Create = new System.Windows.Forms.Button();
            this.TableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Logo = new System.Windows.Forms.PictureBox();
            this.CMB_Category = new System.Windows.Forms.ComboBox();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.Layout1.SuspendLayout();
            this.TableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Layout1
            // 
            this.Layout1.BackColor = System.Drawing.Color.Transparent;
            this.Layout1.ColumnCount = 1;
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.Controls.Add(this.BTN_Exit, 0, 11);
            this.Layout1.Controls.Add(this.LBL_Name, 0, 3);
            this.Layout1.Controls.Add(this.LBL_Category, 0, 6);
            this.Layout1.Controls.Add(this.BTN_Create, 0, 9);
            this.Layout1.Controls.Add(this.TableLayout2, 0, 1);
            this.Layout1.Controls.Add(this.CMB_Category, 0, 7);
            this.Layout1.Controls.Add(this.TXB_Name, 0, 4);
            this.Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1.Location = new System.Drawing.Point(0, 0);
            this.Layout1.Margin = new System.Windows.Forms.Padding(0);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 13;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.Layout1.Size = new System.Drawing.Size(434, 411);
            this.Layout1.TabIndex = 54;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Exit.FlatAppearance.BorderSize = 0;
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Exit.Location = new System.Drawing.Point(138, 349);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(158, 35);
            this.BTN_Exit.TabIndex = 49;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Name
            // 
            this.LBL_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Name.Location = new System.Drawing.Point(134, 135);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(62, 22);
            this.LBL_Name.TabIndex = 44;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // LBL_Category
            // 
            this.LBL_Category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Category.AutoSize = true;
            this.LBL_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Category.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Category.Location = new System.Drawing.Point(134, 211);
            this.LBL_Category.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Category.Name = "LBL_Category";
            this.LBL_Category.Size = new System.Drawing.Size(88, 22);
            this.LBL_Category.TabIndex = 46;
            this.LBL_Category.Text = "Category:";
            this.LBL_Category.UseWaitCursor = true;
            // 
            // BTN_Create
            // 
            this.BTN_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Create.FlatAppearance.BorderSize = 0;
            this.BTN_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Create.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Create.Location = new System.Drawing.Point(162, 289);
            this.BTN_Create.Name = "BTN_Create";
            this.BTN_Create.Size = new System.Drawing.Size(110, 25);
            this.BTN_Create.TabIndex = 48;
            this.BTN_Create.Text = "Create";
            this.BTN_Create.UseVisualStyleBackColor = false;
            // 
            // TableLayout2
            // 
            this.TableLayout2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout2.ColumnCount = 2;
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.97696F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.02304F));
            this.TableLayout2.Controls.Add(this.LBL_Title, 0, 0);
            this.TableLayout2.Controls.Add(this.PCB_Logo, 0, 0);
            this.TableLayout2.Location = new System.Drawing.Point(0, 24);
            this.TableLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout2.Name = "TableLayout2";
            this.TableLayout2.RowCount = 1;
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout2.Size = new System.Drawing.Size(434, 86);
            this.TableLayout2.TabIndex = 56;
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
            this.LBL_Title.Location = new System.Drawing.Point(65, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(311, 86);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "CREATE ITEM";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCB_Logo
            // 
            this.PCB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PCB_Logo.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Logo.Location = new System.Drawing.Point(19, 18);
            this.PCB_Logo.Margin = new System.Windows.Forms.Padding(18, 18, 1, 24);
            this.PCB_Logo.Name = "PCB_Logo";
            this.PCB_Logo.Size = new System.Drawing.Size(44, 44);
            this.PCB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Logo.TabIndex = 38;
            this.PCB_Logo.TabStop = false;
            // 
            // CMB_Category
            // 
            this.CMB_Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMB_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Category.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_Category.Location = new System.Drawing.Point(138, 237);
            this.CMB_Category.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_Category.Name = "CMB_Category";
            this.CMB_Category.Size = new System.Drawing.Size(158, 21);
            this.CMB_Category.TabIndex = 58;
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
            this.TXB_Name.TabIndex = 59;
            // 
            // CreateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Layout1);
            this.Name = "CreateItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Item";
            this.Layout1.ResumeLayout(false);
            this.Layout1.PerformLayout();
            this.TableLayout2.ResumeLayout(false);
            this.TableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_Category;
        private System.Windows.Forms.Button BTN_Create;
        private System.Windows.Forms.TableLayoutPanel TableLayout2;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Logo;
        private System.Windows.Forms.ComboBox CMB_Category;
        private System.Windows.Forms.TextBox TXB_Name;
    }
}