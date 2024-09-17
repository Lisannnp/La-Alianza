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
    public partial class HealerForm : Form
    {
        private Healer h;
        public HealerForm()
        {
            InitializeComponent();
            InitAirborneFont();

            foreach (var i in ListGlosary.listHealers)
            {
                if(i == ListGlosary.CurrentHealer)
                {
                    List<Soldier> soldi = ListGlosary.listSoldiersTemporary.Where(c => c.Status == true).ToList();
                    CMB_Soldier.DataSource = soldi;
                }
            }
           
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
        {
            StartForm Start = new StartForm();
            Start.Show();
            this.Hide();
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

            //Agregar los obje tos que la vayan a usar
            LBL_Soldier.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Soldier.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Heal.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_LogOut.Font = new Font(pfc.Families[0], 12, boldStyle);

            LBL_Title.Font = new Font(pfc.Families[0], 42, boldStyle);
        }
        public void BTN_Heal_Click(object sender, EventArgs e){
            Soldier soldier = (Soldier)CMB_Soldier.SelectedItem;
            h.HealSoldier(soldier);
        }
    }
}
