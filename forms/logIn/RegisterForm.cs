using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
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
                    CMB_Base.DataSource = ListGlosary.listBases;
                    break;
                case "Healer":
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = true;
                    CMB_Base.DataSource = ListGlosary.listBases;
                    break;
                case "Distributor":
                    LBL_Base.Visible = false;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = false;
                    break;
            }
        }
        private void BTN_Register_Click(object sender, EventArgs e)
        {
            string rol = CMB_Rol.SelectedItem.ToString();

            string username = TXB_Name.Text;
            string pass = TXB_Password.Text;
            string baseSelected = TXB_Base.Text;
            Base basefromcombo = (Base)CMB_Base.SelectedItem;

            switch (rol)
            {
                case "Scientist":
                    foreach (var item in ListGlosary.listScientists)
                    {
                        if (TXB_Name.Text == item.Name)
                        {
                            MessageBox.Show("This username cant be used");
                            TXB_Name.Text = "";
                        }
                    }
                    Scientist scientist = new Scientist();
                    scientist.UserName = username;
                    scientist.Password = pass;
                    scientist.Type = "Scientist";
                    ListGlosary.CurrentScientist = scientist;
                    break;

                case "General":
                    foreach (var item in ListGlosary.listGenerals)
                    {
                        if (TXB_Name.Text == item.Name)
                        {
                            MessageBox.Show("This username cant be used");
                            TXB_Name.Text = "";
                        }
                    }
                    General general = new General();
                    foreach (var a in ListGlosary.listBases)
                    {
                        if (baseSelected == a.Name)
                        {
                            MessageBox.Show("The base you are trying to create already exists, please assign a new base to the general you want to create.");
                            break;
                        }
                    }
                    general.CreateBase(baseSelected);
                    general.UserName = username;
                    general.Password = pass;
                    general.Type = "General";
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = true;
                    CMB_Base.Visible = false;
                    ListGlosary.CurrentGeneral = general;

                    break;
                case "Gunsmith":
                    foreach (var item in ListGlosary.listGunsmiths)
                    {
                        if (TXB_Name.Text == item.Name)
                        {
                            MessageBox.Show("This username cant be used");
                            TXB_Name.Text = "";
                        }
                    }
                    Gunsmith gunsmith = new Gunsmith();
                    gunsmith.UserName = username;
                    gunsmith.Password = pass;
                    gunsmith.Type = "Gunsmith";
                    gunsmith.Base = basefromcombo;
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = true;

                    ListGlosary.CurrentGunsmith = gunsmith;

                    break;
                case "Healer":
                    foreach (var item in ListGlosary.listHealers)
                    {
                        if (TXB_Name.Text == item.Name)
                        {
                            MessageBox.Show("This username cant be used");
                            TXB_Name.Text = "";
                        }
                    }
                    Healer healer = new Healer();
                    healer.UserName = username;
                    healer.Password = pass;
                    healer.Type = "Healer";
                    healer.Base = basefromcombo;
                    LBL_Base.Visible = true;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = true;
                    ListGlosary.CurrentHealer = healer;


                    break;
                case "Distributor":
                    foreach (var item in ListGlosary.listDistributors)
                    {
                        if (TXB_Name.Text == item.Name)
                        {
                            MessageBox.Show("This username cant be used");
                            TXB_Name.Text = "";
                        }
                    }
                    Distributor distributor = new Distributor();
                    distributor.UserName = username;
                    distributor.Password = pass;
                    distributor.Type = "Distributor";
                    LBL_Base.Visible = false;
                    TXB_Base.Visible = false;
                    CMB_Base.Visible = false;
                    ListGlosary.CurrentDistributor = distributor;

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
