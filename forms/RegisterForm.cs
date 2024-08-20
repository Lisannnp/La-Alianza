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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            InitAirborneFont();
            CMB_Rol.Items.Add("General");

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            StartForm Start = new StartForm();
            Start.Show();
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
            BTN_Exit.Font = new Font(pfc.Families[0], 10, boldStyle);
            BTN_LogIn.Font = new Font(pfc.Families[0], 10, boldStyle);
            BTN_Start.Font = new Font(pfc.Families[0], 10, boldStyle);
            LBL_Name.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Password.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Rol.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Base.Font = new Font(pfc.Families[0], 12, boldStyle);
            TXB_Name.Font = new Font(pfc.Families[0], 12);
            TXB_Password.Font = new Font(pfc.Families[0], 12);
            TXB_Base.Font = new Font(pfc.Families[0], 12);
            CMB_Rol.Font = new Font(pfc.Families[0], 9);
            BTN_Register.Font = new Font(pfc.Families[0], 8);

            LBL_Title.Font = new Font(pfc.Families[0], 45, boldStyle);
        }

        private void CMB_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_Rol.SelectedIndex == 0)
            {
                LBL_Base.Visible = true;
                TXB_Base.Visible = true;
            }
        }
    }
}
