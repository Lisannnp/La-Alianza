using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza.clases.other;

namespace La_Alianza
{
    class Scientist:User
    {
        
        public Scientist(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
        {
            ListGlosary.listScientists.Add(this);
        }
        public Scientist() : base()
        {
          
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
