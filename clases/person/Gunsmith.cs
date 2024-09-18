using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using La_Alianza;

    public class Gunsmith:BaseMember
    {
        public Gunsmith(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
        {
            ListGlosary.listGunsmiths.Add(this);
        }
        public Gunsmith() : base()
        {
            ListGlosary.listGunsmiths.Add(this);

        }
    public override string ToString()
        {
            return base.ToString();
        }
        public void AssignGun (Soldier s, Item i)
        {
            s.Gun = i;
            Base.ListGuns.RemoveAt(0);
            Console.WriteLine(s.Gun.Name);
            MessageBox.Show("Se añadio el arma al soldado");
        }
    }
