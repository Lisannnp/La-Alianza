using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Distributor:User
    {
        public Distributor(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
        {

        }
        public Distributor() : base()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
