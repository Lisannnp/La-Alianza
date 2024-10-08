﻿using La_Alianza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Alianza
{
    public partial class CreateOperationForm : Form
    {
        public CreateOperationForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitAirborneFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //Modificar la font
            int fontLength = Properties.Resources.airborne.Length;
            byte[] fontdata = Properties.Resources.airborne;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);

            FontStyle boldStyle = FontStyle.Bold;

            //Agregar los objetos que la vayan a usar
            LBL_Name.Font = new Font(pfc.Families[0], 12, boldStyle);
            TXB_Name.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Difficulty.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Difficulty.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Create.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_Exit.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 26, boldStyle);
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            ListGlosary.CurrentGeneral.StartOperation(TXB_Name.Text, Convert.ToInt32(CMB_Difficulty.Text));
            MessageBox.Show(ListGlosary.listOperations[0].OperationName);
            CMB_Difficulty.Text = "";
            TXB_Name.Text = "";
        }
    }
}
