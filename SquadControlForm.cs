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
    public partial class SquadControlForm : Form
    {
        public SquadControlForm()
        {
            InitializeComponent();
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
    }
}
