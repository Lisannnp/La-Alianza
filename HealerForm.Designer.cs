﻿namespace La_Alianza
{
    partial class HealerForm
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
            this.BTN_Heal = new System.Windows.Forms.Button();
            this.CMB_Cargament = new System.Windows.Forms.ComboBox();
            this.LBL_Soldier = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.Location = new System.Drawing.Point(170, 400);
            this.BTN_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(237, 54);
            this.BTN_LogOut.TabIndex = 58;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // BTN_Heal
            // 
            this.BTN_Heal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Heal.Location = new System.Drawing.Point(206, 263);
            this.BTN_Heal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Heal.Name = "BTN_Heal";
            this.BTN_Heal.Size = new System.Drawing.Size(165, 38);
            this.BTN_Heal.TabIndex = 57;
            this.BTN_Heal.Text = "Heal";
            this.BTN_Heal.UseVisualStyleBackColor = true;
            // 
            // CMB_Cargament
            // 
            this.CMB_Cargament.FormattingEnabled = true;
            this.CMB_Cargament.Location = new System.Drawing.Point(170, 208);
            this.CMB_Cargament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CMB_Cargament.Name = "CMB_Cargament";
            this.CMB_Cargament.Size = new System.Drawing.Size(235, 28);
            this.CMB_Cargament.TabIndex = 53;
            // 
            // LBL_Soldier
            // 
            this.LBL_Soldier.AutoSize = true;
            this.LBL_Soldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Soldier.Location = new System.Drawing.Point(166, 169);
            this.LBL_Soldier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Soldier.Name = "LBL_Soldier";
            this.LBL_Soldier.Size = new System.Drawing.Size(100, 30);
            this.LBL_Soldier.TabIndex = 52;
            this.LBL_Soldier.Text = "Soldier:";
            this.LBL_Soldier.UseWaitCursor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(207, 39);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(164, 73);
            this.LBL_Title.TabIndex = 61;
            this.LBL_Title.Text = "Heal";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(576, 478);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.BTN_Heal);
            this.Controls.Add(this.CMB_Cargament);
            this.Controls.Add(this.LBL_Soldier);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HealerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Healer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_Heal;
        private System.Windows.Forms.ComboBox CMB_Cargament;
        private System.Windows.Forms.Label LBL_Soldier;
        private System.Windows.Forms.Label LBL_Title;
    }
}