namespace La_Alianza
{
    partial class SquadControlForm
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
            this.BTN_Operation = new System.Windows.Forms.Button();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.LBL_Squad = new System.Windows.Forms.Label();
            this.BTN_General = new System.Windows.Forms.Button();
            this.LBL_Soldier = new System.Windows.Forms.Label();
            this.BTN_AddToSquad = new System.Windows.Forms.Button();
            this.BTN_RemoveFromSquad = new System.Windows.Forms.Button();
            this.DGV_Squads = new System.Windows.Forms.DataGridView();
            this.Layout1 = new System.Windows.Forms.TableLayoutPanel();
            this.Layout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Layout3 = new System.Windows.Forms.TableLayoutPanel();
            this.Layout4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Layout5 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_Squad = new System.Windows.Forms.ComboBox();
            this.TableLayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Logo = new System.Windows.Forms.PictureBox();
            this.CMB_Soldier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Squads)).BeginInit();
            this.Layout1.SuspendLayout();
            this.Layout2.SuspendLayout();
            this.Layout3.SuspendLayout();
            this.Layout4.SuspendLayout();
            this.Layout5.SuspendLayout();
            this.TableLayout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Operation
            // 
            this.BTN_Operation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Operation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Operation.FlatAppearance.BorderSize = 0;
            this.BTN_Operation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Operation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Operation.Location = new System.Drawing.Point(138, 406);
            this.BTN_Operation.Name = "BTN_Operation";
            this.BTN_Operation.Size = new System.Drawing.Size(158, 34);
            this.BTN_Operation.TabIndex = 49;
            this.BTN_Operation.Text = "Go to Operation";
            this.BTN_Operation.UseVisualStyleBackColor = false;
            this.BTN_Operation.Click += new System.EventHandler(this.BTN_Operation_Click);
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Plus.FlatAppearance.BorderSize = 0;
            this.BTN_Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Plus.Location = new System.Drawing.Point(297, 5);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus.TabIndex = 45;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = false;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // LBL_Squad
            // 
            this.LBL_Squad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Squad.AutoSize = true;
            this.LBL_Squad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Squad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Squad.Location = new System.Drawing.Point(134, 112);
            this.LBL_Squad.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Squad.Name = "LBL_Squad";
            this.LBL_Squad.Size = new System.Drawing.Size(67, 22);
            this.LBL_Squad.TabIndex = 42;
            this.LBL_Squad.Text = "Squad:";
            this.LBL_Squad.UseWaitCursor = true;
            // 
            // BTN_General
            // 
            this.BTN_General.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_General.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_General.FlatAppearance.BorderSize = 0;
            this.BTN_General.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_General.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_General.Location = new System.Drawing.Point(138, 456);
            this.BTN_General.Name = "BTN_General";
            this.BTN_General.Size = new System.Drawing.Size(158, 34);
            this.BTN_General.TabIndex = 41;
            this.BTN_General.Text = "Back to General";
            this.BTN_General.UseVisualStyleBackColor = false;
            this.BTN_General.Click += new System.EventHandler(this.BTN_General_Click);
            // 
            // LBL_Soldier
            // 
            this.LBL_Soldier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_Soldier.AutoSize = true;
            this.LBL_Soldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Soldier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_Soldier.Location = new System.Drawing.Point(134, 289);
            this.LBL_Soldier.Margin = new System.Windows.Forms.Padding(134, 0, 3, 0);
            this.LBL_Soldier.Name = "LBL_Soldier";
            this.LBL_Soldier.Size = new System.Drawing.Size(71, 22);
            this.LBL_Soldier.TabIndex = 51;
            this.LBL_Soldier.Text = "Soldier:";
            this.LBL_Soldier.UseWaitCursor = true;
            // 
            // BTN_AddToSquad
            // 
            this.BTN_AddToSquad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_AddToSquad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_AddToSquad.FlatAppearance.BorderSize = 0;
            this.BTN_AddToSquad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddToSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_AddToSquad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_AddToSquad.Location = new System.Drawing.Point(51, 3);
            this.BTN_AddToSquad.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.BTN_AddToSquad.Name = "BTN_AddToSquad";
            this.BTN_AddToSquad.Size = new System.Drawing.Size(134, 25);
            this.BTN_AddToSquad.TabIndex = 52;
            this.BTN_AddToSquad.Text = "Add to Squad";
            this.BTN_AddToSquad.UseVisualStyleBackColor = false;
            this.BTN_AddToSquad.Click += new System.EventHandler(this.BTN_AddToSquad_Click);
            // 
            // BTN_RemoveFromSquad
            // 
            this.BTN_RemoveFromSquad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_RemoveFromSquad.FlatAppearance.BorderSize = 0;
            this.BTN_RemoveFromSquad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RemoveFromSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_RemoveFromSquad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_RemoveFromSquad.Location = new System.Drawing.Point(245, 3);
            this.BTN_RemoveFromSquad.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.BTN_RemoveFromSquad.Name = "BTN_RemoveFromSquad";
            this.BTN_RemoveFromSquad.Size = new System.Drawing.Size(134, 25);
            this.BTN_RemoveFromSquad.TabIndex = 53;
            this.BTN_RemoveFromSquad.Text = "Remove from Squad";
            this.BTN_RemoveFromSquad.UseVisualStyleBackColor = false;
            this.BTN_RemoveFromSquad.Click += new System.EventHandler(this.BTN_RemoveFromSquad_Click);
            // 
            // DGV_Squads
            // 
            this.DGV_Squads.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_Squads.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.DGV_Squads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Squads.Location = new System.Drawing.Point(102, 179);
            this.DGV_Squads.Name = "DGV_Squads";
            this.DGV_Squads.RowHeadersWidth = 62;
            this.DGV_Squads.Size = new System.Drawing.Size(230, 96);
            this.DGV_Squads.TabIndex = 47;
            // 
            // Layout1
            // 
            this.Layout1.BackColor = System.Drawing.Color.Transparent;
            this.Layout1.ColumnCount = 1;
            this.Layout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout1.Controls.Add(this.BTN_General, 0, 15);
            this.Layout1.Controls.Add(this.BTN_Operation, 0, 13);
            this.Layout1.Controls.Add(this.DGV_Squads, 0, 6);
            this.Layout1.Controls.Add(this.LBL_Soldier, 0, 8);
            this.Layout1.Controls.Add(this.LBL_Squad, 0, 3);
            this.Layout1.Controls.Add(this.Layout2, 0, 11);
            this.Layout1.Controls.Add(this.Layout4, 0, 4);
            this.Layout1.Controls.Add(this.TableLayout2, 0, 1);
            this.Layout1.Controls.Add(this.CMB_Soldier, 0, 9);
            this.Layout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout1.Location = new System.Drawing.Point(0, 0);
            this.Layout1.Name = "Layout1";
            this.Layout1.RowCount = 17;
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Layout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout1.Size = new System.Drawing.Size(434, 511);
            this.Layout1.TabIndex = 54;
            // 
            // Layout2
            // 
            this.Layout2.Controls.Add(this.Layout3);
            this.Layout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout2.Location = new System.Drawing.Point(0, 353);
            this.Layout2.Margin = new System.Windows.Forms.Padding(0);
            this.Layout2.Name = "Layout2";
            this.Layout2.Size = new System.Drawing.Size(434, 30);
            this.Layout2.TabIndex = 52;
            // 
            // Layout3
            // 
            this.Layout3.ColumnCount = 2;
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout3.Controls.Add(this.BTN_RemoveFromSquad, 1, 0);
            this.Layout3.Controls.Add(this.BTN_AddToSquad, 0, 0);
            this.Layout3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Layout3.Location = new System.Drawing.Point(0, 0);
            this.Layout3.Margin = new System.Windows.Forms.Padding(0);
            this.Layout3.Name = "Layout3";
            this.Layout3.RowCount = 1;
            this.Layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.Layout3.Size = new System.Drawing.Size(431, 32);
            this.Layout3.TabIndex = 0;
            // 
            // Layout4
            // 
            this.Layout4.Controls.Add(this.Layout5);
            this.Layout4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Layout4.Location = new System.Drawing.Point(0, 136);
            this.Layout4.Margin = new System.Windows.Forms.Padding(0);
            this.Layout4.Name = "Layout4";
            this.Layout4.Size = new System.Drawing.Size(434, 30);
            this.Layout4.TabIndex = 53;
            // 
            // Layout5
            // 
            this.Layout5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Layout5.ColumnCount = 2;
            this.Layout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.74194F));
            this.Layout5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.25806F));
            this.Layout5.Controls.Add(this.CMB_Squad, 0, 0);
            this.Layout5.Controls.Add(this.BTN_Plus, 1, 0);
            this.Layout5.Location = new System.Drawing.Point(0, 0);
            this.Layout5.Margin = new System.Windows.Forms.Padding(0);
            this.Layout5.Name = "Layout5";
            this.Layout5.RowCount = 1;
            this.Layout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Layout5.Size = new System.Drawing.Size(434, 32);
            this.Layout5.TabIndex = 0;
            // 
            // CMB_Squad
            // 
            this.CMB_Squad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CMB_Squad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_Squad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Squad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_Squad.Location = new System.Drawing.Point(136, 5);
            this.CMB_Squad.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_Squad.Name = "CMB_Squad";
            this.CMB_Squad.Size = new System.Drawing.Size(158, 21);
            this.CMB_Squad.TabIndex = 46;
            this.CMB_Squad.SelectedIndexChanged += new System.EventHandler(this.CMB_Squad_SelectedIndexChanged);
            // 
            // TableLayout2
            // 
            this.TableLayout2.BackColor = System.Drawing.Color.Transparent;
            this.TableLayout2.ColumnCount = 2;
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51613F));
            this.TableLayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.48387F));
            this.TableLayout2.Controls.Add(this.LBL_Title, 0, 0);
            this.TableLayout2.Controls.Add(this.PCB_Logo, 0, 0);
            this.TableLayout2.Location = new System.Drawing.Point(0, 10);
            this.TableLayout2.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayout2.Name = "TableLayout2";
            this.TableLayout2.RowCount = 1;
            this.TableLayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout2.Size = new System.Drawing.Size(434, 91);
            this.TableLayout2.TabIndex = 54;
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
            this.LBL_Title.Location = new System.Drawing.Point(63, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(231, 91);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "SQUAD CONTROL";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCB_Logo
            // 
            this.PCB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PCB_Logo.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Logo.Location = new System.Drawing.Point(14, 18);
            this.PCB_Logo.Margin = new System.Windows.Forms.Padding(14, 18, 0, 24);
            this.PCB_Logo.Name = "PCB_Logo";
            this.PCB_Logo.Size = new System.Drawing.Size(49, 49);
            this.PCB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Logo.TabIndex = 38;
            this.PCB_Logo.TabStop = false;
            // 
            // CMB_Soldier
            // 
            this.CMB_Soldier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMB_Soldier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_Soldier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_Soldier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_Soldier.Location = new System.Drawing.Point(138, 317);
            this.CMB_Soldier.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_Soldier.Name = "CMB_Soldier";
            this.CMB_Soldier.Size = new System.Drawing.Size(158, 21);
            this.CMB_Soldier.TabIndex = 55;
            // 
            // SquadControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.Layout1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SquadControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Squad Control";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Squads)).EndInit();
            this.Layout1.ResumeLayout(false);
            this.Layout1.PerformLayout();
            this.Layout2.ResumeLayout(false);
            this.Layout3.ResumeLayout(false);
            this.Layout4.ResumeLayout(false);
            this.Layout5.ResumeLayout(false);
            this.TableLayout2.ResumeLayout(false);
            this.TableLayout2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Operation;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Label LBL_Squad;
        private System.Windows.Forms.Button BTN_General;
        private System.Windows.Forms.Label LBL_Soldier;
        private System.Windows.Forms.Button BTN_AddToSquad;
        private System.Windows.Forms.Button BTN_RemoveFromSquad;
        private System.Windows.Forms.DataGridView DGV_Squads;
        private System.Windows.Forms.TableLayoutPanel Layout1;
        private System.Windows.Forms.FlowLayoutPanel Layout2;
        private System.Windows.Forms.TableLayoutPanel Layout3;
        private System.Windows.Forms.FlowLayoutPanel Layout4;
        private System.Windows.Forms.TableLayoutPanel Layout5;
        private System.Windows.Forms.TableLayoutPanel TableLayout2;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Logo;
        private System.Windows.Forms.ComboBox CMB_Squad;
        private System.Windows.Forms.ComboBox CMB_Soldier;
    }
}