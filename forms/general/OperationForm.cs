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
    public partial class OperationForm : Form
    {
        public OperationForm()
        {
            InitializeComponent();
            InitAirborneFont();
            CMB_Operation.DataSource = ListGlosary.listOperations;
            CMB_Squad.DataSource = ListGlosary.CurrentGeneral.Base.ListSquads;
        }

        private void BTN_BackToGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm General = new GeneralForm();
            General.Show();
            this.Hide();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            CreateSquadForm CreateSquad = new CreateSquadForm();
            CreateSquad.Show();
            this.Hide();
        }
        private void BTN_Plus_Click_1(object sender, EventArgs e)
        {
            CreateSquadForm CreateSquad = new CreateSquadForm();
            CreateSquad.Show();
            this.Hide();
        }
        private void BTN_Plus2_Click(object sender, EventArgs e)
        {
            CreateOperationForm CreateOperation = new CreateOperationForm();
            CreateOperation.Show();
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
            CMB_Squad.Font = new Font(pfc.Families[0], 9, boldStyle);
            LBL_Operation.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Operation.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Plus.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_Plus2.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_RunOperation.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_BackToGeneral.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 24, boldStyle);
        }

        private void BTN_RunOperation_Click(object sender, EventArgs e)
        {
            Operation o = (Operation)CMB_Operation.SelectedItem;
            Squad s = (Squad)CMB_Squad.SelectedItem;
            o.RunOperation(o.Dificulty, s);


        }

        private void CMB_Squad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_Squad.DataSource = ListGlosary.CurrentGeneral.Base.ListSquads;
        }

        private void CMB_Operation_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_Operation.DataSource = ListGlosary.listOperations;
        }
    }
}
