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
    public partial class CreateItemForm : Form
    {
        public CreateItemForm()
        {
            InitializeComponent();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
