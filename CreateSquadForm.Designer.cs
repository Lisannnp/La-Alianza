namespace La_Alianza
{
    partial class CreateSquadForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_CreateSquad = new System.Windows.Forms.Button();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.CMB_Soldier = new System.Windows.Forms.ComboBox();
            this.LBL_Soldier = new System.Windows.Forms.Label();
            this.BTN_General = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_SquadControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(230, 150);
            this.dataGridView1.TabIndex = 38;
            // 
            // BTN_CreateSquad
            // 
            this.BTN_CreateSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_CreateSquad.Location = new System.Drawing.Point(161, 370);
            this.BTN_CreateSquad.Name = "BTN_CreateSquad";
            this.BTN_CreateSquad.Size = new System.Drawing.Size(110, 25);
            this.BTN_CreateSquad.TabIndex = 37;
            this.BTN_CreateSquad.Text = "Create Squad";
            this.BTN_CreateSquad.UseVisualStyleBackColor = true;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.Location = new System.Drawing.Point(315, 128);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus.TabIndex = 36;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(161, 160);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(110, 25);
            this.BTN_Add.TabIndex = 34;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // CMB_Soldier
            // 
            this.CMB_Soldier.FormattingEnabled = true;
            this.CMB_Soldier.Location = new System.Drawing.Point(139, 128);
            this.CMB_Soldier.Name = "CMB_Soldier";
            this.CMB_Soldier.Size = new System.Drawing.Size(158, 21);
            this.CMB_Soldier.TabIndex = 33;
            // 
            // LBL_Soldier
            // 
            this.LBL_Soldier.AutoSize = true;
            this.LBL_Soldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Soldier.Location = new System.Drawing.Point(135, 103);
            this.LBL_Soldier.Name = "LBL_Soldier";
            this.LBL_Soldier.Size = new System.Drawing.Size(71, 22);
            this.LBL_Soldier.TabIndex = 32;
            this.LBL_Soldier.Text = "Soldier:";
            this.LBL_Soldier.UseWaitCursor = true;
            // 
            // BTN_General
            // 
            this.BTN_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_General.Location = new System.Drawing.Point(137, 450);
            this.BTN_General.Name = "BTN_General";
            this.BTN_General.Size = new System.Drawing.Size(158, 35);
            this.BTN_General.TabIndex = 31;
            this.BTN_General.Text = "Back to General";
            this.BTN_General.UseVisualStyleBackColor = true;
            this.BTN_General.Click += new System.EventHandler(this.BTN_General_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(74, 23);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(287, 51);
            this.LBL_Title.TabIndex = 39;
            this.LBL_Title.Text = "Create Squad";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_SquadControl
            // 
            this.BTN_SquadControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_SquadControl.Location = new System.Drawing.Point(137, 409);
            this.BTN_SquadControl.Name = "BTN_SquadControl";
            this.BTN_SquadControl.Size = new System.Drawing.Size(158, 35);
            this.BTN_SquadControl.TabIndex = 40;
            this.BTN_SquadControl.Text = "Go to Squad Control";
            this.BTN_SquadControl.UseVisualStyleBackColor = true;
            this.BTN_SquadControl.Click += new System.EventHandler(this.BTN_SquadControl_Click);
            // 
            // CreateSquadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.BTN_SquadControl);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_CreateSquad);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.CMB_Soldier);
            this.Controls.Add(this.LBL_Soldier);
            this.Controls.Add(this.BTN_General);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateSquadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeSquad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_CreateSquad;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.ComboBox CMB_Soldier;
        private System.Windows.Forms.Label LBL_Soldier;
        private System.Windows.Forms.Button BTN_General;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_SquadControl;
    }
}