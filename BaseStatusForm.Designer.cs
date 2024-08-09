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
            this.DGV_SoldierList = new System.Windows.Forms.DataGridView();
            this.CMB_List = new System.Windows.Forms.ComboBox();
            this.LBL_List = new System.Windows.Forms.Label();
            this.BTN_BackToGeneral = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.DGV_SquadList = new System.Windows.Forms.DataGridView();
            this.DGV_MedicineList = new System.Windows.Forms.DataGridView();
            this.DGV_GunList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SoldierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SquadList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GunList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_SoldierList
            // 
            this.DGV_SoldierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SoldierList.Location = new System.Drawing.Point(152, 242);
            this.DGV_SoldierList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_SoldierList.Name = "DGV_SoldierList";
            this.DGV_SoldierList.RowHeadersWidth = 62;
            this.DGV_SoldierList.Size = new System.Drawing.Size(345, 399);
            this.DGV_SoldierList.TabIndex = 38;
            // 
            // CMB_List
            // 
            this.CMB_List.FormattingEnabled = true;
            this.CMB_List.Location = new System.Drawing.Point(152, 174);
            this.CMB_List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_List.Name = "CMB_List";
            this.CMB_List.Size = new System.Drawing.Size(345, 28);
            this.CMB_List.TabIndex = 33;
            // 
            // LBL_List
            // 
            this.LBL_List.AutoSize = true;
            this.LBL_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_List.Location = new System.Drawing.Point(154, 139);
            this.LBL_List.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_List.Name = "LBL_List";
            this.LBL_List.Size = new System.Drawing.Size(60, 30);
            this.LBL_List.TabIndex = 32;
            this.LBL_List.Text = "List:";
            this.LBL_List.UseWaitCursor = true;
            // 
            // BTN_BackToGeneral
            // 
            this.BTN_BackToGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BackToGeneral.Location = new System.Drawing.Point(206, 697);
            this.BTN_BackToGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_BackToGeneral.Name = "BTN_BackToGeneral";
            this.BTN_BackToGeneral.Size = new System.Drawing.Size(237, 54);
            this.BTN_BackToGeneral.TabIndex = 31;
            this.BTN_BackToGeneral.Text = "Back To General";
            this.BTN_BackToGeneral.UseVisualStyleBackColor = true;
            this.BTN_BackToGeneral.Click += new System.EventHandler(this.BTN_BackToGeneral_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(139, 31);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(379, 73);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "Base Status";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV_SquadList
            // 
            this.DGV_SquadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_SquadList.Location = new System.Drawing.Point(152, 242);
            this.DGV_SquadList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_SquadList.Name = "DGV_SquadList";
            this.DGV_SquadList.RowHeadersWidth = 62;
            this.DGV_SquadList.Size = new System.Drawing.Size(345, 399);
            this.DGV_SquadList.TabIndex = 40;
            // 
            // DGV_MedicineList
            // 
            this.DGV_MedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MedicineList.Location = new System.Drawing.Point(152, 242);
            this.DGV_MedicineList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_MedicineList.Name = "DGV_MedicineList";
            this.DGV_MedicineList.RowHeadersWidth = 62;
            this.DGV_MedicineList.Size = new System.Drawing.Size(345, 399);
            this.DGV_MedicineList.TabIndex = 41;
            // 
            // DGV_GunList
            // 
            this.DGV_GunList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_GunList.Location = new System.Drawing.Point(153, 242);
            this.DGV_GunList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_GunList.Name = "DGV_GunList";
            this.DGV_GunList.RowHeadersWidth = 62;
            this.DGV_GunList.Size = new System.Drawing.Size(345, 399);
            this.DGV_GunList.TabIndex = 42;
            // 
            // BaseStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 794);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.CMB_List);
            this.Controls.Add(this.LBL_List);
            this.Controls.Add(this.BTN_BackToGeneral);
            this.Controls.Add(this.DGV_GunList);
            this.Controls.Add(this.DGV_MedicineList);
            this.Controls.Add(this.DGV_SquadList);
            this.Controls.Add(this.DGV_SoldierList);
            this.Name = "BaseStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseStatusForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SoldierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_SquadList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_GunList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_SoldierList;
        private System.Windows.Forms.ComboBox CMB_List;
        private System.Windows.Forms.Label LBL_List;
        private System.Windows.Forms.Button BTN_BackToGeneral;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.DataGridView DGV_SquadList;
        private System.Windows.Forms.DataGridView DGV_MedicineList;
        private System.Windows.Forms.DataGridView DGV_GunList;
    }
}