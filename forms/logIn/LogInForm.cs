using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace La_Alianza
{

    public partial class LogInForm : Form
    {
        public LogInForm()
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
            BTN_LogIn.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Start.Font = new Font(pfc.Families[0], 10, boldStyle);
            LBL_Name.Font = new Font(pfc.Families[0], 12, boldStyle);
            LBL_Password.Font = new Font(pfc.Families[0], 12, boldStyle);
            TXB_Name.Font = new Font(pfc.Families[0], 12);
            TXB_Password.Font = new Font(pfc.Families[0], 12);


            LBL_Title.Font = new Font(pfc.Families[0], 45, boldStyle);
        }

        private void BTN_LogIn_Click(object sender, EventArgs e)
        {
            string username = TXB_Name.Text;
            string password = TXB_Password.Text;

            foreach (var scientist in ListGlosary.listScientists)
            {
                if (scientist.UserName == username && scientist.Password == password)
                {
                    ScientistForm scientistform = new ScientistForm();
                    scientistform.Show();
                    this.Hide();
                }
            }
            foreach (var general in ListGlosary.listGenerals)
            {
                if (general.UserName == username && general.Password == password)
                {
                    GeneralForm generalform = new GeneralForm();
                    generalform.Show();
                    this.Hide();
                }
            }
            foreach (var healer in ListGlosary.listHealers)
            {
                if (healer.UserName == username && healer.Password == password)
                {
                    HealerForm healerform = new HealerForm();
                    healerform.Show();
                    this.Hide();
                }
            }
            foreach (var gunsmith in ListGlosary.listGunsmiths)
            {
                if (gunsmith.UserName == username && gunsmith.Password == password)
                {
                    GunsmithForm gunsmithform = new GunsmithForm();
                    gunsmithform.Show();
                    this.Hide();
                }
            }
            foreach (var distributor in ListGlosary.listDistributors)
            {
                if (distributor.UserName == username && distributor.Password == password)
                {
                    DistributorForm distributorform = new DistributorForm();
                    distributorform.Show();
                    this.Hide();
                }

            }


        }
    }
}
