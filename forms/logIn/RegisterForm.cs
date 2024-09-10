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
            CMB_Rol.Items.Add("Scientist");
            CMB_Rol.Items.Add("Distributor");
            CMB_Rol.Items.Add("Healer");
            CMB_Rol.Items.Add("Gunsmith");
            CMB_Rol.Items.Add("General");


            LBL_Base.Visible = false;
            TXB_Base.Visible = false;
            CMB_Base.Visible = false;

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

            switch (CMB_Rol.SelectedItem.ToString())
            {
                case "Scientist":
                    LBL_Base.Visible = false;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = false;
                    break;

                case "General":
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = true;
                    CMB_Base.Visible = false;
                    break;
                case "Gunsmith":
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = true;
                    break;
                case "Healer":
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = true;
                    break;
                case "Distributor":
                    LBL_Base.Visible = false;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = false;
                    break;
            }
        }
        private void BTN_Register_Click(object sender, EventArgs e){
            string rol = CMB_Rol.SelectedItem.ToString();

            foreach (var i in ListGlosary.listUsers)
            {
                if (TXB_Name.Text == i.Name)
                {
                    MessageBox.Show("This username cant be used");
                    TXB_Name.Text = "";
                } else
                {
                    string username = TXB_Name.Text;
                    string pass = TXB_Password.Text;
                    string baseSelected = TXB_Base.Text;
                    Base basefromcombo = (Base)CMB_Base.SelectedItem;

                    switch (rol)
                    {
                        case "Scientist":
                            Scientist scientist = new Scientist();
                            scientist.UserName = username;
                            scientist.Password = pass;
                            scientist.Type = "Scientist";
                            ListGlosary.CurrentUser = scientist;
                            break;

                        case "General":
                            General general = new General();
                            foreach (var a in ListGlosary.listBases)
                            {
                                if (baseSelected == a.Name)
                                {
                                    MessageBox.Show("La base que se intenta crear ya existe, asigne una nueva base al general que se quiere crear");
                                    break;
                                }
                            }
                            general.CreateBase(baseSelected);
                            general.UserName = username;
                            general.Password = pass;
                            general.Type = "General";
                            general.Base.Name = baseSelected;
                            LBL_Base.Visible = true;
                            TXB_Base.Visible = true;
                            CMB_Base.Visible = false;
                            ListGlosary.CurrentUser = general;

                            break;
                        case "Gunsmith":
                            Gunsmith gunsmith = new Gunsmith();
                            gunsmith.UserName = username;
                            gunsmith.Password = pass;
                            gunsmith.Type = "Gunsmith";
                            gunsmith.Base = basefromcombo;
                            LBL_Base.Visible = true;
                            TXB_Base.Visible = false;
                            CMB_Base.Visible = true;

                            ListGlosary.CurrentUser = gunsmith;

                            break;
                        case "Healer":
                            Healer healer = new Healer();
                            healer.UserName = username;
                            healer.Password = pass;
                            healer.Type = "Healer";
                            healer.Base = basefromcombo;
                            LBL_Base.Visible = true;
                            TXB_Base.Visible = false;
                            CMB_Base.Visible = true;
                            ListGlosary.CurrentUser = healer;


                            break;
                        case "Distributor":
                            Distributor distributor = new Distributor();
                            distributor.UserName = username;
                            distributor.Password = pass;
                            distributor.Type = "Distributor";
                            LBL_Base.Visible = false;
                            TXB_Base.Visible = false;
                            CMB_Base.Visible = false;
                            ListGlosary.CurrentUser = distributor;

                            break;
                        default:
                            LBL_Base.Visible = false;
                            TXB_Base.Visible = false;
                            CMB_Base.Visible = false;
                            break;
                    }

                    TXB_Base.Text = "";
                    CMB_Base.Text = "";
                    CMB_Rol.Text = "";
                    TXB_Name.Text = "";
                    TXB_Password.Text = "";
                }
            }
        }
    }
}
