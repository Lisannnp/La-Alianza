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
    public partial class ScientistForm : Form
    {
        public ScientistForm()
        {
            InitializeComponent();
            InitAirborneFont();
            CMB_Item.DataSource = ListGlosary.listItems;
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
        {
            StartForm Start = new StartForm();
            Start.Show();
            this.Hide();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            CreateItemForm CreateItem = new CreateItemForm();
            this.Hide();
            CreateItem.Show();
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
            LBL_Item.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_Item.Font = new Font(pfc.Families[0], 9, boldStyle);
            BTN_Add.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_AddPackage.Font = new Font(pfc.Families[0], 8, boldStyle);
            BTN_LogOut.Font = new Font(pfc.Families[0], 12, boldStyle);
            BTN_Plus.Font = new Font(pfc.Families[0], 8, boldStyle);
            LBL_Title.Font = new Font(pfc.Families[0], 38, boldStyle);
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {

            foreach(var i in ListGlosary.listItems)
            {

                if(i == (Item)CMB_Item.SelectedItem)
                {
                    bool itemExist = ListGlosary.listPacking.Any(s => s.ItemID == i.ItemID);
                    if (!itemExist)
                    {
                        ListGlosary.listPacking.Add(i);
                    }
                    else
                    {
                        MessageBox.Show("The item already exist in the list");
                    }
                }
            }
            ListGlosary.listItems.Remove((Item)CMB_Item.SelectedItem);
            DGV_Squads.DataSource = null;
            DGV_Squads.DataSource = ListGlosary.listPacking;

            DGV_Squads.Columns[3].DisplayIndex = 0;
            DGV_Squads.Columns[2].DisplayIndex = 2;
            DGV_Squads.Columns[1].DisplayIndex = 1;
            DGV_Squads.Columns[0].DisplayIndex = 3;
        }

        private void BTN_AddPackage_Click(object sender, EventArgs e)
        {
            ListGlosary.CurrentScientist.MakeCargament();
            DGV_Squads.DataSource = null;
        }

        private void CMB_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_Item.DataSource = null;
            CMB_Item.DataSource = ListGlosary.listItems;
        }
    }
}
