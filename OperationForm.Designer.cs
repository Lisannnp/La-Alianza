namespace La_Alianza
{
    partial class OperationForm
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
            this.BTN_BackToGeneral = new System.Windows.Forms.Button();
            this.BTN_RunOperation = new System.Windows.Forms.Button();
            this.CMB_Operation = new System.Windows.Forms.ComboBox();
            this.LBL_Operation = new System.Windows.Forms.Label();
            this.CMB_Squad = new System.Windows.Forms.ComboBox();
            this.LBL_Squad = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_Plus = new System.Windows.Forms.Button();
            this.BTN_Plus2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_BackToGeneral
            // 
            this.BTN_BackToGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BackToGeneral.Location = new System.Drawing.Point(115, 300);
            this.BTN_BackToGeneral.Name = "BTN_BackToGeneral";
            this.BTN_BackToGeneral.Size = new System.Drawing.Size(158, 35);
            this.BTN_BackToGeneral.TabIndex = 49;
            this.BTN_BackToGeneral.Text = "Back to General";
            this.BTN_BackToGeneral.UseVisualStyleBackColor = true;
            this.BTN_BackToGeneral.Click += new System.EventHandler(this.BTN_BackToGeneral_Click);
            // 
            // BTN_RunOperation
            // 
            this.BTN_RunOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_RunOperation.Location = new System.Drawing.Point(139, 236);
            this.BTN_RunOperation.Name = "BTN_RunOperation";
            this.BTN_RunOperation.Size = new System.Drawing.Size(110, 25);
            this.BTN_RunOperation.TabIndex = 48;
            this.BTN_RunOperation.Text = "Run Operation";
            this.BTN_RunOperation.UseVisualStyleBackColor = true;
            // 
            // CMB_Operation
            // 
            this.CMB_Operation.FormattingEnabled = true;
            this.CMB_Operation.Location = new System.Drawing.Point(117, 197);
            this.CMB_Operation.Name = "CMB_Operation";
            this.CMB_Operation.Size = new System.Drawing.Size(158, 21);
            this.CMB_Operation.TabIndex = 47;
            // 
            // LBL_Operation
            // 
            this.LBL_Operation.AutoSize = true;
            this.LBL_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Operation.Location = new System.Drawing.Point(113, 172);
            this.LBL_Operation.Name = "LBL_Operation";
            this.LBL_Operation.Size = new System.Drawing.Size(94, 22);
            this.LBL_Operation.TabIndex = 46;
            this.LBL_Operation.Text = "Operation:";
            this.LBL_Operation.UseWaitCursor = true;
            // 
            // CMB_Squad
            // 
            this.CMB_Squad.FormattingEnabled = true;
            this.CMB_Squad.Location = new System.Drawing.Point(115, 133);
            this.CMB_Squad.Name = "CMB_Squad";
            this.CMB_Squad.Size = new System.Drawing.Size(158, 21);
            this.CMB_Squad.TabIndex = 45;
            // 
            // LBL_Squad
            // 
            this.LBL_Squad.AutoSize = true;
            this.LBL_Squad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.LBL_Squad.Location = new System.Drawing.Point(113, 109);
            this.LBL_Squad.Name = "LBL_Squad";
            this.LBL_Squad.Size = new System.Drawing.Size(67, 22);
            this.LBL_Squad.TabIndex = 44;
            this.LBL_Squad.Text = "Squad:";
            this.LBL_Squad.UseWaitCursor = true;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(17, 25);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(361, 51);
            this.LBL_Title.TabIndex = 50;
            this.LBL_Title.Text = "Operation Control";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Plus
            // 
            this.BTN_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus.Location = new System.Drawing.Point(282, 132);
            this.BTN_Plus.Name = "BTN_Plus";
            this.BTN_Plus.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus.TabIndex = 51;
            this.BTN_Plus.Text = "+";
            this.BTN_Plus.UseVisualStyleBackColor = true;
            this.BTN_Plus.Click += new System.EventHandler(this.BTN_Plus_Click);
            // 
            // BTN_Plus2
            // 
            this.BTN_Plus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Plus2.Location = new System.Drawing.Point(282, 196);
            this.BTN_Plus2.Name = "BTN_Plus2";
            this.BTN_Plus2.Size = new System.Drawing.Size(21, 21);
            this.BTN_Plus2.TabIndex = 52;
            this.BTN_Plus2.Text = "+";
            this.BTN_Plus2.UseVisualStyleBackColor = true;
            this.BTN_Plus2.Click += new System.EventHandler(this.BTN_Plus2_Click);
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.BTN_Plus2);
            this.Controls.Add(this.BTN_Plus);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_BackToGeneral);
            this.Controls.Add(this.BTN_RunOperation);
            this.Controls.Add(this.CMB_Operation);
            this.Controls.Add(this.LBL_Operation);
            this.Controls.Add(this.CMB_Squad);
            this.Controls.Add(this.LBL_Squad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BackToGeneral;
        private System.Windows.Forms.Button BTN_RunOperation;
        private System.Windows.Forms.ComboBox CMB_Operation;
        private System.Windows.Forms.Label LBL_Operation;
        private System.Windows.Forms.ComboBox CMB_Squad;
        private System.Windows.Forms.Label LBL_Squad;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_Plus;
        private System.Windows.Forms.Button BTN_Plus2;
    }
}