namespace La_Alianza
{
    partial class EnlistSoldierForm
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
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXB_Name = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_BackToGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Name.Location = new System.Drawing.Point(129, 135);
            this.LBL_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(89, 30);
            this.LBL_Name.TabIndex = 44;
            this.LBL_Name.Text = "Name:";
            this.LBL_Name.UseWaitCursor = true;
            // 
            // TXB_Name
            // 
            this.TXB_Name.Location = new System.Drawing.Point(134, 174);
            this.TXB_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXB_Name.Name = "TXB_Name";
            this.TXB_Name.Size = new System.Drawing.Size(235, 26);
            this.TXB_Name.TabIndex = 43;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Add.Location = new System.Drawing.Point(170, 230);
            this.BTN_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(165, 38);
            this.BTN_Add.TabIndex = 41;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(19, 28);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(455, 73);
            this.LBL_Title.TabIndex = 45;
            this.LBL_Title.Text = "Enlist  Soldiers";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_BackToGeneral
            // 
            this.BTN_BackToGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BackToGeneral.Location = new System.Drawing.Point(132, 320);
            this.BTN_BackToGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_BackToGeneral.Name = "BTN_BackToGeneral";
            this.BTN_BackToGeneral.Size = new System.Drawing.Size(237, 54);
            this.BTN_BackToGeneral.TabIndex = 50;
            this.BTN_BackToGeneral.Text = "Back to General";
            this.BTN_BackToGeneral.UseVisualStyleBackColor = true;
            this.BTN_BackToGeneral.Click += new System.EventHandler(this.BTN_BackToGeneral_Click);
            // 
            // EnlistSoldierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(487, 388);
            this.Controls.Add(this.BTN_BackToGeneral);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.LBL_Name);
            this.Controls.Add(this.TXB_Name);
            this.Controls.Add(this.BTN_Add);
            this.Name = "EnlistSoldierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnlistSoldierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXB_Name;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_BackToGeneral;
    }
}