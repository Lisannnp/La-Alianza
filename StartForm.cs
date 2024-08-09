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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void BTN_Register_Click_1(object sender, EventArgs e)
        {
            RegisterForm Register = new RegisterForm();
            Register.Show();
            this.Hide();
        }

        private void BTN_LogIn_Click(object sender, EventArgs e)
        {
            LogInForm LogIn = new LogInForm();
            LogIn.Show();
            this.Hide();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
