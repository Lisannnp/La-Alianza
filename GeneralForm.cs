using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
