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
    public partial class SquadControlForm : Form
    {
        public SquadControlForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            CreateSquadForm CreateSquad = new CreateSquadForm();
            CreateSquad.Show();
            this.Hide();
        }

        private void BTN_Operation_Click(object sender, EventArgs e)
        {
            OperationForm Operation = new OperationForm();
            Operation.Show();
            this.Hide();
        }

        private void BTN_General_Click(object sender, EventArgs e)
        {
            GeneralForm General = new GeneralForm();
            General.Show();
            this.Hide();
        }

        private void BTN_AddToSquad_Click(object sender, EventArgs e)
        {

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
            LBL_Squad.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Squad.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Soldier.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Soldier.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_AddToSquad.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_RemoveFromSquad.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Operation.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_General.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 30, boldStyle);
        }
    }
}
