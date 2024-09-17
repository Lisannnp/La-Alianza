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
    public partial class BaseStatusForm : Form
    {
        public BaseStatusForm()
        {
            InitializeComponent();
            InitAirborneFont();
            DGV_GunList.DataSource = ListGlosary.CurrentGeneral.Base.ListGuns;
            DGV_MedicineList.DataSource = ListGlosary.CurrentGeneral.Base.ListMedicines;
            DGV_SoldierList.DataSource = ListGlosary.CurrentGeneral.Base.ListSoldiers;
            DGV_SquadList.DataSource= ListGlosary.CurrentGeneral.Base.ListSquads;
            DGV_GunList.Visible = false;
            DGV_MedicineList.Visible = false;
            DGV_SoldierList.Visible = false;
            DGV_SquadList.Visible = false;
        }

        private void BTN_BackToGeneral_Click(object sender, EventArgs e)
        {
            GeneralForm General = new GeneralForm();
            General.Show();
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

            //Agregar los objetos que la vayan a usar
            BTN_BackToGeneral.Font = new Font(pfc.Families[0], 12, boldStyle);
            CMB_List.Font = new Font(pfc.Families[0], 9, boldStyle);
            LBL_List.Font = new Font(pfc.Families[0], 12, boldStyle);


            LBL_Title.Font = new Font(pfc.Families[0], 36, boldStyle);
        }

        private void CMB_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CMB_List.Text)
            {
                case "Guns":
                    DGV_GunList.Visible = true;
                    DGV_MedicineList.Visible = false;
                    DGV_SoldierList.Visible = false;
                    DGV_SquadList.Visible = false;
                    break;
                case "Medicines":
                    DGV_GunList.Visible = false;
                    DGV_MedicineList.Visible = true;
                    DGV_SoldierList.Visible = false;
                    DGV_SquadList.Visible = false;
                    break;
                case "Soldiers":
                    DGV_GunList.Visible = false;
                    DGV_MedicineList.Visible = false;
                    DGV_SoldierList.Visible = true;
                    DGV_SquadList.Visible = false;
                    break;
                case "Squads":
                    DGV_GunList.Visible = false;
                    DGV_MedicineList.Visible = false;
                    DGV_SoldierList.Visible = false;
                    DGV_SquadList.Visible = true;
                    break;
            }
        }
    }
}
