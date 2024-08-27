using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Scientist:User
    {
        public static List<Scientist> listScientists = new List<Scientist>();
        public Scientist(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
        {
            listScientists.Add(this);
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
