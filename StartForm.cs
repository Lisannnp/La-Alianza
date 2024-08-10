using System;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace La_Alianza
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            InitAirborneFont();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {}
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
            BTN_Register.Font = new Font(pfc.Families[0], BTN_Register.Font.Size);

            float titleFontSize = 46.0f;
            FontStyle fontStyle = FontStyle.Bold;
            LBL_Title.Font = new Font(pfc.Families[0], titleFontSize, fontStyle);
        }
    }
}
