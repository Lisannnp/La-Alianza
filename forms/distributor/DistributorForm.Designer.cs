namespace La_Alianza
{
    partial class DistributorForm
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
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.LBL_Cargament = new System.Windows.Forms.Label();
            this.LBL_Base = new System.Windows.Forms.Label();
            this.BTN_Allocate = new System.Windows.Forms.Button();
            this.TableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Logo = new System.Windows.Forms.PictureBox();
            this.CMB_Base = new System.Windows.Forms.ComboBox();
            this.CMB_Cargament = new System.Windows.Forms.ComboBox();
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
            this.Layout1.Controls.Add(this.BTN_LogOut, 0, 11);
            this.Layout1.Controls.Add(this.LBL_Cargament, 0, 3);
            this.Layout1.Controls.Add(this.LBL_Base, 0, 6);
            this.Layout1.Controls.Add(this.BTN_Allocate, 0, 9);
            this.Layout1.Controls.Add(this.TableLayout2, 0, 1);
            this.Layout1.Controls.Add(this.CMB_Base, 0, 7);
            this.Layout1.Controls.Add(this.CMB_Cargament, 0, 4);
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
            this.Layout1.TabIndex = 56;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_LogOut.FlatAppearance.BorderSize = 0;
            this.BTN_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_LogOut.Location = new System.Drawing.Point(138, 349);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(158, 35);
            this.BTN_LogOut.TabIndex = 49;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = false;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // LBL_Cargament
            // 
            this.LBL_Cargament.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Cargament.AutoSize = true;
            this.LBL_Cargament.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Cargament.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Cargament.Location = new System.Drawing.Point(134, 135);
            this.LBL_Cargament.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Cargament.Name = "LBL_Cargament";
            this.LBL_Cargament.Size = new System.Drawing.Size(103, 22);
            this.LBL_Cargament.TabIndex = 44;
            this.LBL_Cargament.Text = "Cargament:";
            this.LBL_Cargament.UseWaitCursor = true;
            // 
            // LBL_Base
            // 
            this.LBL_Base.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Base.AutoSize = true;
            this.LBL_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Base.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Base.Location = new System.Drawing.Point(134, 211);
            this.LBL_Base.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Base.Name = "LBL_Base";
            this.LBL_Base.Size = new System.Drawing.Size(56, 22);
            this.LBL_Base.TabIndex = 46;
            this.LBL_Base.Text = "Base:";
            this.LBL_Base.UseWaitCursor = true;
            // 
            // BTN_Allocate
            // 
            this.BTN_Allocate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Allocate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Allocate.FlatAppearance.BorderSize = 0;
            this.BTN_Allocate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Allocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Allocate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Allocate.Location = new System.Drawing.Point(162, 289);
            this.BTN_Allocate.Name = "BTN_Allocate";
            this.BTN_Allocate.Size = new System.Drawing.Size(110, 25);
            this.BTN_Allocate.TabIndex = 48;
            this.BTN_Allocate.Text = "Allocate";
            this.BTN_Allocate.UseVisualStyleBackColor = false;
            this.BTN_Allocate.Click += new System.EventHandler(this.BTN_Allocate_Click);
            // 
            // TableLayout2
            // 
            this.TableLayout2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout2.ColumnCount = 2;
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.81567F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.18433F));
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
            this.LBL_Title.Location = new System.Drawing.Point(86, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(313, 86);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "DISTRIBUTOR";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCB_Logo
            // 
            this.PCB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PCB_Logo.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Logo.Location = new System.Drawing.Point(29, 18);
            this.PCB_Logo.Margin = new System.Windows.Forms.Padding(18, 18, 1, 24);
            this.PCB_Logo.Name = "PCB_Logo";
            this.PCB_Logo.Size = new System.Drawing.Size(44, 44);
            this.PCB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Logo.TabIndex = 38;
            this.PCB_Logo.TabStop = false;
            // 
            // CMB_Base
            // 
            this.CMB_Base.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMB_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_Base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Base.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_Base.Location = new System.Drawing.Point(138, 237);
            this.CMB_Base.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_Base.Name = "CMB_Base";
            this.CMB_Base.Size = new System.Drawing.Size(158, 21);
            this.CMB_Base.TabIndex = 58;
            // 
            // CMB_Cargament
            // 
            this.CMB_Cargament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMB_Cargament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_Cargament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Cargament.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_Cargament.Location = new System.Drawing.Point(138, 161);
            this.CMB_Cargament.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_Cargament.Name = "CMB_Cargament";
            this.CMB_Cargament.Size = new System.Drawing.Size(158, 21);
            this.CMB_Cargament.TabIndex = 59;
            // 
            // DistributorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.Layout1);
            this.Name = "DistributorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distributor";
            this.Layout1.ResumeLayout(false);
            this.Layout1.PerformLayout();
            this.TableLayout2.ResumeLayout(false);
            this.TableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Label LBL_Cargament;
        private System.Windows.Forms.Label LBL_Base;
        private System.Windows.Forms.Button BTN_Allocate;
        private System.Windows.Forms.TableLayoutPanel TableLayout2;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Logo;
        private System.Windows.Forms.ComboBox CMB_Base;
        private System.Windows.Forms.ComboBox CMB_Cargament;
    }
}