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
            this.BTN_Allocate = new System.Windows.Forms.Button();
            this.CMB_Base = new System.Windows.Forms.ComboBox();
            this.LBL_Base = new System.Windows.Forms.Label();
            this.TXB_Base = new System.Windows.Forms.TextBox();
            this.CMB_Cargament = new System.Windows.Forms.ComboBox();
            this.LBL_Cargament = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Allocate
            // 
            this.BTN_Allocate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Allocate.Location = new System.Drawing.Point(137, 252);
            this.BTN_Allocate.Name = "BTN_Allocate";
            this.BTN_Allocate.Size = new System.Drawing.Size(110, 25);
            this.BTN_Allocate.TabIndex = 41;
            this.BTN_Allocate.Text = "Allocate";
            this.BTN_Allocate.UseVisualStyleBackColor = true;
            // 
            // CMB_Base
            // 
            this.CMB_Base.FormattingEnabled = true;
            this.CMB_Base.Location = new System.Drawing.Point(115, 213);
            this.CMB_Base.Name = "CMB_Base";
            this.CMB_Base.Size = new System.Drawing.Size(158, 21);
            this.CMB_Base.TabIndex = 40;
            // 
            // LBL_Base
            // 
            this.LBL_Base.AutoSize = true;
            this.LBL_Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Base.Location = new System.Drawing.Point(111, 188);
            this.LBL_Base.Name = "LBL_Base";
            this.LBL_Base.Size = new System.Drawing.Size(56, 22);
            this.LBL_Base.TabIndex = 39;
            this.LBL_Base.Text = "Base:";
            this.LBL_Base.UseWaitCursor = true;
            // 
            // TXB_Base
            // 
            this.TXB_Base.Location = new System.Drawing.Point(115, 213);
            this.TXB_Base.Name = "TXB_Base";
            this.TXB_Base.Size = new System.Drawing.Size(158, 20);
            this.TXB_Base.TabIndex = 38;
            // 
            // CMB_Cargament
            // 
            this.CMB_Cargament.FormattingEnabled = true;
            this.CMB_Cargament.Location = new System.Drawing.Point(113, 143);
            this.CMB_Cargament.Name = "CMB_Cargament";
            this.CMB_Cargament.Size = new System.Drawing.Size(158, 21);
            this.CMB_Cargament.TabIndex = 37;
            // 
            // LBL_Cargament
            // 
            this.LBL_Cargament.AutoSize = true;
            this.LBL_Cargament.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Cargament.Location = new System.Drawing.Point(111, 118);
            this.LBL_Cargament.Name = "LBL_Cargament";
            this.LBL_Cargament.Size = new System.Drawing.Size(103, 22);
            this.LBL_Cargament.TabIndex = 36;
            this.LBL_Cargament.Text = "Cargament:";
            this.LBL_Cargament.UseWaitCursor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(104, 35);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(177, 51);
            this.LBL_Title.TabIndex = 35;
            this.LBL_Title.Text = "Allocate";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.Location = new System.Drawing.Point(113, 310);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(158, 35);
            this.BTN_LogOut.TabIndex = 42;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // DistributorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.BTN_Allocate);
            this.Controls.Add(this.CMB_Base);
            this.Controls.Add(this.LBL_Base);
            this.Controls.Add(this.TXB_Base);
            this.Controls.Add(this.CMB_Cargament);
            this.Controls.Add(this.LBL_Cargament);
            this.Controls.Add(this.LBL_Title);
            this.Name = "DistributorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Allocate;
        private System.Windows.Forms.ComboBox CMB_Base;
        private System.Windows.Forms.Label LBL_Base;
        private System.Windows.Forms.TextBox TXB_Base;
        private System.Windows.Forms.ComboBox CMB_Cargament;
        private System.Windows.Forms.Label LBL_Cargament;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_LogOut;
    }
}