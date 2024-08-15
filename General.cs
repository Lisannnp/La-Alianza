using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class General:BaseMember
    {
        public General(string name, int id, string userName, string password, string type, Base @base) : base(name, id, userName, password, type, @base)
        {

        }
        public General() : base()
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
