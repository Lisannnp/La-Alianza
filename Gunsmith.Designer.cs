﻿namespace La_Alianza
{
    partial class Gunsmith
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
            this.BTN_Arm = new System.Windows.Forms.Button();
            this.CMB_Gun = new System.Windows.Forms.ComboBox();
            this.LBL_Gun = new System.Windows.Forms.Label();
            this.TXB_Base = new System.Windows.Forms.TextBox();
            this.CMB_Cargament = new System.Windows.Forms.ComboBox();
            this.LBL_Soldier = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.Location = new System.Drawing.Point(113, 300);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(158, 35);
            this.BTN_LogOut.TabIndex = 50;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            // 
            // BTN_Arm
            // 
            this.BTN_Arm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Arm.Location = new System.Drawing.Point(137, 242);
            this.BTN_Arm.Name = "BTN_Arm";
            this.BTN_Arm.Size = new System.Drawing.Size(110, 25);
            this.BTN_Arm.TabIndex = 49;
            this.BTN_Arm.Text = "Arm";
            this.BTN_Arm.UseVisualStyleBackColor = true;
            // 
            // CMB_Gun
            // 
            this.CMB_Gun.FormattingEnabled = true;
            this.CMB_Gun.Location = new System.Drawing.Point(115, 203);
            this.CMB_Gun.Name = "CMB_Gun";
            this.CMB_Gun.Size = new System.Drawing.Size(158, 21);
            this.CMB_Gun.TabIndex = 48;
            // 
            // LBL_Gun
            // 
            this.LBL_Gun.AutoSize = true;
            this.LBL_Gun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Gun.Location = new System.Drawing.Point(111, 178);
            this.LBL_Gun.Name = "LBL_Gun";
            this.LBL_Gun.Size = new System.Drawing.Size(49, 22);
            this.LBL_Gun.TabIndex = 47;
            this.LBL_Gun.Text = "Gun:";
            this.LBL_Gun.UseWaitCursor = true;
            // 
            // TXB_Base
            // 
            this.TXB_Base.Location = new System.Drawing.Point(115, 203);
            this.TXB_Base.Name = "TXB_Base";
            this.TXB_Base.Size = new System.Drawing.Size(158, 20);
            this.TXB_Base.TabIndex = 46;
            // 
            // CMB_Cargament
            // 
            this.CMB_Cargament.FormattingEnabled = true;
            this.CMB_Cargament.Location = new System.Drawing.Point(113, 133);
            this.CMB_Cargament.Name = "CMB_Cargament";
            this.CMB_Cargament.Size = new System.Drawing.Size(158, 21);
            this.CMB_Cargament.TabIndex = 45;
            // 
            // LBL_Soldier
            // 
            this.LBL_Soldier.AutoSize = true;
            this.LBL_Soldier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Soldier.Location = new System.Drawing.Point(111, 108);
            this.LBL_Soldier.Name = "LBL_Soldier";
            this.LBL_Soldier.Size = new System.Drawing.Size(71, 22);
            this.LBL_Soldier.TabIndex = 44;
            this.LBL_Soldier.Text = "Soldier:";
            this.LBL_Soldier.UseWaitCursor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(142, 35);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(101, 51);
            this.LBL_Title.TabIndex = 51;
            this.LBL_Title.Text = "Arm";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gunsmith
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.BTN_Arm);
            this.Controls.Add(this.CMB_Gun);
            this.Controls.Add(this.LBL_Gun);
            this.Controls.Add(this.TXB_Base);
            this.Controls.Add(this.CMB_Cargament);
            this.Controls.Add(this.LBL_Soldier);
            this.Name = "Gunsmith";
            this.Text = "Gunsmith";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_Arm;
        private System.Windows.Forms.ComboBox CMB_Gun;
        private System.Windows.Forms.Label LBL_Gun;
        private System.Windows.Forms.TextBox TXB_Base;
        private System.Windows.Forms.ComboBox CMB_Cargament;
        private System.Windows.Forms.Label LBL_Soldier;
        private System.Windows.Forms.Label LBL_Title;
    }
}