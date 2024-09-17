using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace La_Alianza
{
    public partial class CreateSquadForm : Form
    {
        public CreateSquadForm()
        {
            InitializeComponent();
            InitAirborneFont();
            CMB_Soldier.DataSource = ListGlosary.CurrentGeneral.Base.ListSoldiers;
        }

        private void BTN_General_Click(object sender, EventArgs e)
        {
            GeneralForm General = new GeneralForm();
            General.Show();
            this.Hide();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            EnlistSoldierForm EnlistSoldier = new EnlistSoldierForm();
            EnlistSoldier.Show();
            this.Hide();
        }

        private void BTN_SquadControl_Click(object sender, EventArgs e)
        {
            SquadControlForm SquadControl = new SquadControlForm();
            SquadControl.Show();
            this.Hide();
        }

        private void BTN_Operation_Click(object sender, EventArgs e)
        {
            OperationForm Operation = new OperationForm();
            Operation.Show();
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
            LBL_Soldier.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Soldier.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Add.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_CreateSquad.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_Operation.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Plus.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_General.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Title.Font = new Font(pfc.Families[0], 30, boldStyle);
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {

            foreach (var i in ListGlosary.CurrentGeneral.Base.ListSoldiers)
            {
                if (i.Name == CMB_Soldier.Text)
                {
                    ListGlosary.listSoldiersTemporary.Add(i);
                }
            }
            DGV_Squads.DataSource = null;
            DGV_Squads.DataSource = ListGlosary.listSoldiersTemporary;
            DGV_Squads.Columns["status"].Visible = false;
        }

        private void BTN_CreateSquad_Click(object sender, EventArgs e)
        {
            ListGlosary.CurrentGeneral.MakeSquad();
            ListGlosary.listSoldiersTemporary.Clear();
            DGV_Squads.DataSource = null;
        }
    }
}
