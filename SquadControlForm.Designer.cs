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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.DGV_Squads = new System.Windows.Forms.DataGridView();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.CMB_Squad = new System.Windows.Forms.ComboBox();
            this.LBL_Squad = new System.Windows.Forms.Label();
            this.BTN_General = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LBL_Soldier = new System.Windows.Forms.Label();
            this.BTN_AddToSquad = new System.Windows.Forms.Button();
            this.BTN_RemoveFormSquad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Squads)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Operation
            // 
            this.BTN_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Operation.Location = new System.Drawing.Point(137, 412);
            this.BTN_Operation.Name = "BTN_Operation";
            this.BTN_Operation.Size = new System.Drawing.Size(158, 35);
            this.BTN_Operation.TabIndex = 49;
            this.BTN_Operation.Text = "Go to Operation";
            this.BTN_Operation.UseVisualStyleBackColor = true;
            this.BTN_Operation.Click += new System.EventHandler(this.BTN_Operation_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(74, 17);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(297, 51);
            this.LBL_Title.TabIndex = 48;
            this.LBL_Title.Text = "Control Squad";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGV_Squads
            // 
            this.DGV_Squads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Squads.Location = new System.Drawing.Point(107, 141);
            this.DGV_Squads.Name = "DGV_Squads";
            this.DGV_Squads.RowHeadersWidth = 62;
            this.DGV_Squads.Size = new System.Drawing.Size(230, 150);
            this.DGV_Squads.TabIndex = 47;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.Location = new System.Drawing.Point(315, 105);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus.TabIndex = 45;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // CMB_Squad
            // 
            this.CMB_Squad.FormattingEnabled = true;
            this.CMB_Squad.Location = new System.Drawing.Point(139, 105);
            this.CMB_Squad.Name = "CMB_Squad";
            this.CMB_Squad.Size = new System.Drawing.Size(158, 21);
            this.CMB_Squad.TabIndex = 43;
            // 
            // LBL_Squad
            // 
            this.LBL_Squad.AutoSize = true;
            this.LBL_Squad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Squad.Location = new System.Drawing.Point(135, 81);
            this.LBL_Squad.Name = "LBL_Squad";
            this.LBL_Squad.Size = new System.Drawing.Size(67, 22);
            this.LBL_Squad.TabIndex = 42;
            this.LBL_Squad.Text = "Squad:";
            this.LBL_Squad.UseWaitCursor = true;
            // 
            // BTN_General
            // 
            this.BTN_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_General.Location = new System.Drawing.Point(137, 454);
            this.BTN_General.Name = "BTN_General";
            this.BTN_General.Size = new System.Drawing.Size(158, 35);
            this.BTN_General.TabIndex = 41;
            this.BTN_General.Text = "Back to General";
            this.BTN_General.UseVisualStyleBackColor = true;
            this.BTN_General.Click += new System.EventHandler(this.BTN_General_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // LBL_Soldier
            // 
            this.LBL_Soldier.AutoSize = true;
            this.LBL_Soldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Soldier.Location = new System.Drawing.Point(134, 308);
            this.LBL_Soldier.Name = "LBL_Soldier";
            this.LBL_Soldier.Size = new System.Drawing.Size(71, 22);
            this.LBL_Soldier.TabIndex = 51;
            this.LBL_Soldier.Text = "Soldier:";
            this.LBL_Soldier.UseWaitCursor = true;
            // 
            // BTN_AddToSquad
            // 
            this.BTN_AddToSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_AddToSquad.Location = new System.Drawing.Point(74, 364);
            this.BTN_AddToSquad.Name = "BTN_AddToSquad";
            this.BTN_AddToSquad.Size = new System.Drawing.Size(134, 25);
            this.BTN_AddToSquad.TabIndex = 52;
            this.BTN_AddToSquad.Text = "Add to Squad";
            this.BTN_AddToSquad.UseVisualStyleBackColor = true;
            // 
            // BTN_RemoveFormSquad
            // 
            this.BTN_RemoveFormSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_RemoveFormSquad.Location = new System.Drawing.Point(220, 364);
            this.BTN_RemoveFormSquad.Name = "BTN_RemoveFormSquad";
            this.BTN_RemoveFormSquad.Size = new System.Drawing.Size(134, 25);
            this.BTN_RemoveFormSquad.TabIndex = 53;
            this.BTN_RemoveFormSquad.Text = "Remove from Squad";
            this.BTN_RemoveFormSquad.UseVisualStyleBackColor = true;
            // 
            // SquadControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.BTN_RemoveFormSquad);
            this.Controls.Add(this.BTN_AddToSquad);
            this.Controls.Add(this.LBL_Soldier);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTN_Operation);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.DGV_Squads);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.CMB_Squad);
            this.Controls.Add(this.LBL_Squad);
            this.Controls.Add(this.BTN_General);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SquadControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SquadControlForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Squads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Operation;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.DataGridView DGV_Squads;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.ComboBox CMB_Squad;
        private System.Windows.Forms.Label LBL_Squad;
        private System.Windows.Forms.Button BTN_General;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LBL_Soldier;
        private System.Windows.Forms.Button BTN_AddToSquad;
        private System.Windows.Forms.Button BTN_RemoveFormSquad;
    }
}