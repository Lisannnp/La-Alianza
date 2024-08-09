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
    public partial class OperationForm : Form
    {
        public OperationForm()
        {
            InitializeComponent();
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

        private void BTN_Plus2_Click(object sender, EventArgs e)
        {
            CreateOperationForm CreateOperation = new CreateOperationForm();
            CreateOperation.Show();
        }
    }
}
