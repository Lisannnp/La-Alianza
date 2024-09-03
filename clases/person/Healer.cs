using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza.clases.other;

namespace La_Alianza
{
    class Healer:BaseMember
    {
        public Healer(string name, int id, string userName, string password, string type, Base @base) : base(name, id, userName, password, type, @base)
        {

            ListGlosary.listHealers.Add(this);
        }
        public Healer() : base()
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
