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
    public partial class DistributorForm : Form
    {
        public DistributorForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
        {
            StartForm Start = new StartForm();
            Start.Show();
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
            LBL_Cargament.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Cargament.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Base.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Base.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Allocate.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_LogOut.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 35, boldStyle);
        }
    }
}