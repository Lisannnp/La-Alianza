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
    public partial class EnlistSoldierForm : Form
    {
        public EnlistSoldierForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void BTN_BackToGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm General = new GeneralForm();
            General.Show();
            this.Hide();
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
            BTN_BackToGeneral.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Add.Font = new Font(pfc.Families[0], 8, boldStyle);
            LBL_Name.Font = new Font(pfc.Families[0], 12, boldStyle);
            TXB_Name.Font = new Font(pfc.Families[0], 12);


            LBL_Title.Font = new Font(pfc.Families[0], 28, boldStyle);
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try {
                ListGlosary.CurrentGeneral.EnlistSoldier(TXB_Name.Text);
                TXB_Name.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo crear:" + ex.Message);
            }
        }
    }
}
