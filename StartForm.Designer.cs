
namespace La_Alianza
{
    partial class StartForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_LogIn = new System.Windows.Forms.Button();
            this.BTN_Register = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PCB_Start = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_LogIn
            // 
            this.BTN_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_LogIn.AutoSize = true;
            this.BTN_LogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_LogIn.FlatAppearance.BorderSize = 0;
            this.BTN_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_LogIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_LogIn.Location = new System.Drawing.Point(137, 411);
            this.BTN_LogIn.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_LogIn.Name = "BTN_LogIn";
            this.BTN_LogIn.Size = new System.Drawing.Size(160, 30);
            this.BTN_LogIn.TabIndex = 7;
            this.BTN_LogIn.Text = "Log In";
            this.BTN_LogIn.UseVisualStyleBackColor = false;
            this.BTN_LogIn.Click += new System.EventHandler(this.BTN_LogIn_Click);
            // 
            // BTN_Register
            // 
            this.BTN_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Register.AutoSize = true;
            this.BTN_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Register.FlatAppearance.BorderSize = 0;
            this.BTN_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Register.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Register.Location = new System.Drawing.Point(137, 371);
            this.BTN_Register.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Register.Name = "BTN_Register";
            this.BTN_Register.Size = new System.Drawing.Size(160, 30);
            this.BTN_Register.TabIndex = 6;
            this.BTN_Register.Text = "Register";
            this.BTN_Register.UseVisualStyleBackColor = false;
            this.BTN_Register.Click += new System.EventHandler(this.BTN_Register_Click_1);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Exit.AutoSize = true;
            this.BTN_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.BTN_Exit.FlatAppearance.BorderSize = 0;
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BTN_Exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_Exit.Location = new System.Drawing.Point(137, 451);
            this.BTN_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(160, 30);
            this.BTN_Exit.TabIndex = 19;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = false;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.LBL_Title.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Bold);
            this.LBL_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this.LBL_Title.Location = new System.Drawing.Point(84, 43);
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(265, 66);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "LA ALIANZA";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Exit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.BTN_LogIn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Register, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Title, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PCB_Start, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4898F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.77551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.122449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.163265F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.040816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 511);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // PCB_Start
            // 
            this.PCB_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PCB_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PCB_Start.Image = global::La_Alianza.Properties.Resources.LOGO;
            this.PCB_Start.Location = new System.Drawing.Point(120, 142);
            this.PCB_Start.Margin = new System.Windows.Forms.Padding(0);
            this.PCB_Start.Name = "PCB_Start";
            this.PCB_Start.Size = new System.Drawing.Size(194, 194);
            this.PCB_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCB_Start.TabIndex = 3;
            this.PCB_Start.TabStop = false;
            this.PCB_Start.UseWaitCursor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(29)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCB_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PCB_Start;
        private System.Windows.Forms.Button BTN_LogIn;
        private System.Windows.Forms.Button BTN_Register;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_Title;
    }
}

