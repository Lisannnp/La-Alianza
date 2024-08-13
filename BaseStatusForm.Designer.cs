namespace La_Alianza
{
    partial class BaseStatusForm
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
            this.LBL_List = new System.Windows.Forms.Label();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Layout3 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PCB_Logo = new System.Windows.Forms.PictureBox();
            this.Layout2 = new System.Windows.Forms.Panel();
            this.DGV_SquadList = new System.Windows.Forms.DataGridView();
            this.DGV_GunList = new System.Windows.Forms.DataGridView();
            this.DGV_MedicineList = new System.Windows.Forms.DataGridView();
            this.DGV_SoldierList = new System.Windows.Forms.DataGridView();
            this.BTN_BackToGeneral = new System.Windows.Forms.Button();
            this.CMB_List = new System.Windows.Forms.ComboBox();
            this.Layout.SuspendLayout();
            this.Layout3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).BeginInit();
            this.Layout2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SquadList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GunList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SoldierList)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_List
            // 
            this.LBL_List.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_List.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_List.Location = new System.Drawing.Point(134, 96);
            this.LBL_List.Margin = new System.Windows.Forms.Padding(134, 0, 0, 0);
            this.LBL_List.Name = "LBL_List";
            this.LBL_List.Size = new System.Drawing.Size(62, 20);
            this.LBL_List.TabIndex = 32;
            this.LBL_List.Text = "List:";
            this.LBL_List.UseWaitCursor = true;
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.Transparent;
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.Layout3, 0, 1);
            this.Layout.Controls.Add(this.Layout2, 0, 6);
            this.Layout.Controls.Add(this.BTN_BackToGeneral, 0, 8);
            this.Layout.Controls.Add(this.LBL_List, 0, 3);
            this.Layout.Controls.Add(this.CMB_List, 0, 4);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 10;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.Layout.Size = new System.Drawing.Size(434, 511);
            this.Layout.TabIndex = 43;
            // 
            // Layout3
            // 
            this.Layout3.BackColor = System.Drawing.Color.Transparent;
            this.Layout3.ColumnCount = 2;
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58986F));
            this.Layout3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.41014F));
            this.Layout3.Controls.Add(this.LBL_Title, 0, 0);
            this.Layout3.Controls.Add(this.PCB_Logo, 0, 0);
            this.Layout3.Location = new System.Drawing.Point(0, 10);
            this.Layout3.Margin = new System.Windows.Forms.Padding(0);
            this.Layout3.Name = "Layout3";
            this.Layout3.RowCount = 1;
            this.Layout3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout3.Size = new System.Drawing.Size(434, 76);
            this.Layout3.TabIndex = 34;
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
            this.LBL_Title.Location = new System.Drawing.Point(71, 0);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(319, 76);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "BASE STATUS";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCB_Logo
            // 
            this.PCB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PCB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PCB_Logo.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Logo.Location = new System.Drawing.Point(22, 15);
            this.PCB_Logo.Margin = new System.Windows.Forms.Padding(20, 15, 0, 14);
            this.PCB_Logo.Name = "PCB_Logo";
            this.PCB_Logo.Size = new System.Drawing.Size(47, 47);
            this.PCB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Logo.TabIndex = 38;
            this.PCB_Logo.TabStop = false;
            // 
            // Layout2
            // 
            this.Layout2.Controls.Add(this.DGV_SquadList);
            this.Layout2.Controls.Add(this.DGV_GunList);
            this.Layout2.Controls.Add(this.DGV_MedicineList);
            this.Layout2.Controls.Add(this.DGV_SoldierList);
            this.Layout2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout2.Location = new System.Drawing.Point(0, 166);
            this.Layout2.Margin = new System.Windows.Forms.Padding(0);
            this.Layout2.Name = "Layout2";
            this.Layout2.Size = new System.Drawing.Size(434, 281);
            this.Layout2.TabIndex = 32;
            // 
            // DGV_SquadList
            // 
            this.DGV_SquadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SquadList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.DGV_SquadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SquadList.Location = new System.Drawing.Point(42, 0);
            this.DGV_SquadList.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.DGV_SquadList.Name = "DGV_SquadList";
            this.DGV_SquadList.RowHeadersWidth = 62;
            this.DGV_SquadList.Size = new System.Drawing.Size(350, 280);
            this.DGV_SquadList.TabIndex = 45;
            // 
            // DGV_GunList
            // 
            this.DGV_GunList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_GunList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.DGV_GunList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GunList.Location = new System.Drawing.Point(42, 0);
            this.DGV_GunList.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.DGV_GunList.Name = "DGV_GunList";
            this.DGV_GunList.RowHeadersWidth = 62;
            this.DGV_GunList.Size = new System.Drawing.Size(350, 280);
            this.DGV_GunList.TabIndex = 44;
            // 
            // DGV_MedicineList
            // 
            this.DGV_MedicineList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_MedicineList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.DGV_MedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MedicineList.Location = new System.Drawing.Point(42, 1);
            this.DGV_MedicineList.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.DGV_MedicineList.Name = "DGV_MedicineList";
            this.DGV_MedicineList.RowHeadersWidth = 62;
            this.DGV_MedicineList.Size = new System.Drawing.Size(350, 280);
            this.DGV_MedicineList.TabIndex = 47;
            // 
            // DGV_SoldierList
            // 
            this.DGV_SoldierList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_SoldierList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.DGV_SoldierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SoldierList.Location = new System.Drawing.Point(42, 1);
            this.DGV_SoldierList.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.DGV_SoldierList.Name = "DGV_SoldierList";
            this.DGV_SoldierList.RowHeadersWidth = 62;
            this.DGV_SoldierList.Size = new System.Drawing.Size(350, 280);
            this.DGV_SoldierList.TabIndex = 46;
            // 
            // BTN_BackToGeneral
            // 
            this.BTN_BackToGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BTN_BackToGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_BackToGeneral.FlatAppearance.BorderSize = 0;
            this.BTN_BackToGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BackToGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BackToGeneral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_BackToGeneral.Location = new System.Drawing.Point(138, 460);
            this.BTN_BackToGeneral.Name = "BTN_BackToGeneral";
            this.BTN_BackToGeneral.Size = new System.Drawing.Size(158, 34);
            this.BTN_BackToGeneral.TabIndex = 35;
            this.BTN_BackToGeneral.Text = "Back To General";
            this.BTN_BackToGeneral.UseVisualStyleBackColor = false;
            this.BTN_BackToGeneral.Click += new System.EventHandler(this.BTN_BackToGeneral_Click);
            // 
            // CMB_List
            // 
            this.CMB_List.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CMB_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.CMB_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_List.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CMB_List.Location = new System.Drawing.Point(138, 118);
            this.CMB_List.Margin = new System.Windows.Forms.Padding(0);
            this.CMB_List.Name = "CMB_List";
            this.CMB_List.Size = new System.Drawing.Size(158, 21);
            this.CMB_List.TabIndex = 36;
            // 
            // BaseStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.Layout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaseStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseStatusForm";
            this.Layout.ResumeLayout(false);
            this.Layout3.ResumeLayout(false);
            this.Layout3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Logo)).EndInit();
            this.Layout2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SquadList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GunList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SoldierList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBL_List;
        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.Panel Layout2;
        private System.Windows.Forms.TableLayoutPanel Layout3;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.PictureBox PCB_Logo;
        private System.Windows.Forms.DataGridView DGV_GunList;
        private System.Windows.Forms.Button BTN_BackToGeneral;
        private System.Windows.Forms.DataGridView DGV_SquadList;
        private System.Windows.Forms.DataGridView DGV_MedicineList;
        private System.Windows.Forms.DataGridView DGV_SoldierList;
        private System.Windows.Forms.ComboBox CMB_List;
    }
}