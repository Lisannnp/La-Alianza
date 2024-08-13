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
    public partial class GeneralForm : Form
    {
        public GeneralForm()
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

        private void BTN_BaseControl_Click(object sender, EventArgs e)
        {
            BaseStatusForm BaseStatus = new BaseStatusForm();
            BaseStatus.Show();
            this.Hide();
        }

        private void BTN_Enlist_Click(object sender, EventArgs e)
        {
            EnlistSoldierForm EnlistSoldier = new EnlistSoldierForm();
            EnlistSoldier.Show();
            this.Hide();
        }

        private void BTN_Operation_Click(object sender, EventArgs e)
        {
            OperationForm Operation = new OperationForm();
            Operation.Show();
            this.Hide();
        }

        private void BTN_SquadControl_Click(object sender, EventArgs e)
        {
            SquadControlForm SquadControl = new SquadControlForm();
            SquadControl.Show();
            this.Hide();
        }

        private void BTN_MakeSquad_Click(object sender, EventArgs e)
        {
            CreateSquadForm CreateSquad = new CreateSquadForm();
            CreateSquad.Show();
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
            BTN_MakeSquad.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_SquadControl.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Operation.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Enlist.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_BaseControl.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_LogOut.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 45, boldStyle);
        }
    }
}
