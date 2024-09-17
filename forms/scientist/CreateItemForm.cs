using La_Alianza;
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
    public partial class CreateItemForm : Form
    {
        public CreateItemForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void BTN_Scientist_Click(object sender, EventArgs e)
        {
            ScientistForm scientistForm = new ScientistForm();
            this.Hide();
            scientistForm.Show();
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
            LBL_Category.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Category.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Create.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_Scientist.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 38, boldStyle);
        }

        private void BTN_Create_Click(object sender, EventArgs e)
        {
            ListGlosary.CurrentScientist.MakeItem(CMB_Category.Text, TXB_Name.Text);
            CMB_Category.Text = "";
            TXB_Name.Text = "";
        }
    }
}
