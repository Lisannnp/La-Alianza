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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            StartForm Start = new StartForm();
            Start.Show();
            this.Hide();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
