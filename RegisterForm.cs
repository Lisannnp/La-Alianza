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


            //Agregar los objetos que la vayan a usar
            BTN_Exit.Font = new Font(pfc.Families[0], BTN_Exit.Font.Size);
            BTN_LogIn.Font = new Font(pfc.Families[0], BTN_LogIn.Font.Size);
            BTN_Start.Font = new Font(pfc.Families[0], BTN_Start.Font.Size);
            LBL_Name.Font = new Font(pfc.Families[0], LBL_Name.Font.Size);
            LBL_Password.Font = new Font(pfc.Families[0], LBL_Password.Font.Size);
            LBL_Rol.Font = new Font(pfc.Families[0], LBL_Rol.Font.Size);
            LBL_Base.Font = new Font(pfc.Families[0], LBL_Base.Font.Size);
            TXB_Name.Font = new Font(pfc.Families[0], TXB_Name.Font.Size);
            TXB_Password.Font = new Font(pfc.Families[0], TXB_Password.Font.Size);
            TXB_Base.Font = new Font(pfc.Families[0], TXB_Base.Font.Size);
            

            float titleFontSize = 46.0f;
            FontStyle fontStyle = FontStyle.Bold;
            LBL_Title.Font = new Font(pfc.Families[0], titleFontSize, fontStyle);
        }
    }
}
