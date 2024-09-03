using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using La_Alianza.clases.other;

namespace La_Alianza
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            InitAirborneFont();

            CMB_Formi.Items.Add("Scientist");
            CMB_Formi.Items.Add("Healer");
            CMB_Formi.Items.Add("Gunsmith");
            CMB_Formi.Items.Add("Distributor");
            CMB_Formi.Items.Add("General");

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
            string formiItem = CMB_Formi.SelectedItem.ToString();

            switch (formiItem)
            {
                case "Scientist":
                    foreach(var scientist in ListGlosary.listScientists)
                    {
                        if (scientist.UserName == TXB_Name.Text && scientist.Password == TXB_Password.Text)
                        {
                            ScientistForm ScientistForm = new ScientistForm();
                            ScientistForm.Show();
                            this.Hide();
                        }
                    };
                    
                break;
                case "Healer":
                    foreach(var healer in ListGlosary.listHealers){
                        if (healer.UserName == TXB_Name.Text && healer.Password == TXB_Password.Text)
                        {
                            HealerForm HealerForm = new HealerForm();
                            HealerForm.Show();
                            this.Hide();
                        }
                    };
                break;
                case "Gunsmith":
                    foreach(var gunsmith in ListGlosary.listGunsmiths){
                        if (gunsmith.UserName == TXB_Name.Text && gunsmith.Password == TXB_Password.Text)
                        {
                            GunsmithForm GunsmithForm = new GunsmithForm();
                            GunsmithForm.Show();
                            this.Hide();
                        }
                    };
                break;
                case "Distributor":
                    foreach(var distributor in ListGlosary.listDistributors){
                        if (distributor.UserName == TXB_Name.Text && distributor.Password == TXB_Password.Text)
                        {
                            DistributorForm DistributorForm = new DistributorForm();
                            DistributorForm.Show();
                            this.Hide();
                        }
                    };
                break;
                case "General":
                    foreach(var general in ListGlosary.listGenerals){
                        if (general.UserName == TXB_Name.Text && general.Password == TXB_Password.Text)
                        {
                            GeneralForm GeneralForm = new GeneralForm();
                            GeneralForm.Show();
                            this.Hide();
                        }
                    };
                break;
            }
        }
    }
}
