namespace La_Alianza
{
    partial class GeneralForm
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.BTN_Operation = new System.Windows.Forms.Button();
            this.BTN_SquadControl = new System.Windows.Forms.Button();
            this.BTN_BaseControl = new System.Windows.Forms.Button();
            this.BTN_Enlist = new System.Windows.Forms.Button();
            this.BTN_MakeSquad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.LBL_Title.Location = new System.Drawing.Point(207, 40);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(239, 73);
            this.LBL_Title.TabIndex = 62;
            this.LBL_Title.Text = "Control";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogOut.Location = new System.Drawing.Point(209, 466);
            this.BTN_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(237, 54);
            this.BTN_LogOut.TabIndex = 65;
            this.BTN_LogOut.Text = "Log Out";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // BTN_Operation
            // 
            this.BTN_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Operation.Location = new System.Drawing.Point(75, 251);
            this.BTN_Operation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Operation.Name = "BTN_Operation";
            this.BTN_Operation.Size = new System.Drawing.Size(237, 54);
            this.BTN_Operation.TabIndex = 68;
            this.BTN_Operation.Text = "Operation";
            this.BTN_Operation.UseVisualStyleBackColor = true;
            this.BTN_Operation.Click += new System.EventHandler(this.BTN_Operation_Click);
            // 
            // BTN_SquadControl
            // 
            this.BTN_SquadControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_SquadControl.Location = new System.Drawing.Point(338, 251);
            this.BTN_SquadControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_SquadControl.Name = "BTN_SquadControl";
            this.BTN_SquadControl.Size = new System.Drawing.Size(237, 54);
            this.BTN_SquadControl.TabIndex = 69;
            this.BTN_SquadControl.Text = "Squad Control";
            this.BTN_SquadControl.UseVisualStyleBackColor = true;
            this.BTN_SquadControl.Click += new System.EventHandler(this.BTN_SquadControl_Click);
            // 
            // BTN_BaseControl
            // 
            this.BTN_BaseControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_BaseControl.Location = new System.Drawing.Point(75, 167);
            this.BTN_BaseControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_BaseControl.Name = "BTN_BaseControl";
            this.BTN_BaseControl.Size = new System.Drawing.Size(237, 54);
            this.BTN_BaseControl.TabIndex = 70;
            this.BTN_BaseControl.Text = "Base Control";
            this.BTN_BaseControl.UseVisualStyleBackColor = true;
            this.BTN_BaseControl.Click += new System.EventHandler(this.BTN_BaseControl_Click);
            // 
            // BTN_Enlist
            // 
            this.BTN_Enlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Enlist.Location = new System.Drawing.Point(338, 167);
            this.BTN_Enlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_Enlist.Name = "BTN_Enlist";
            this.BTN_Enlist.Size = new System.Drawing.Size(237, 54);
            this.BTN_Enlist.TabIndex = 71;
            this.BTN_Enlist.Text = "Enlist Soldiers";
            this.BTN_Enlist.UseVisualStyleBackColor = true;
            this.BTN_Enlist.Click += new System.EventHandler(this.BTN_Enlist_Click);
            // 
            // BTN_MakeSquad
            // 
            this.BTN_MakeSquad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_MakeSquad.Location = new System.Drawing.Point(209, 328);
            this.BTN_MakeSquad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_MakeSquad.Name = "BTN_MakeSquad";
            this.BTN_MakeSquad.Size = new System.Drawing.Size(237, 54);
            this.BTN_MakeSquad.TabIndex = 72;
            this.BTN_MakeSquad.Text = "Make Squad";
            this.BTN_MakeSquad.UseVisualStyleBackColor = true;
            this.BTN_MakeSquad.Click += new System.EventHandler(this.BTN_MakeSquad_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(651, 544);
            this.Controls.Add(this.BTN_MakeSquad);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.LBL_Title);
            this.Controls.Add(this.BTN_Enlist);
            this.Controls.Add(this.BTN_BaseControl);
            this.Controls.Add(this.BTN_SquadControl);
            this.Controls.Add(this.BTN_Operation);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_Operation;
        private System.Windows.Forms.Button BTN_SquadControl;
        private System.Windows.Forms.Button BTN_BaseControl;
        private System.Windows.Forms.Button BTN_Enlist;
        private System.Windows.Forms.Button BTN_MakeSquad;
    }
}