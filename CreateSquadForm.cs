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
    public partial class CreateSquadForm : Form
    {
        public CreateSquadForm()
        {
            InitializeComponent();
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
    }
}
