using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class BaseMember : User
    {
        private Base _base;

        internal Base Base { get => _base; set => _base = value; }

        public BaseMember(string name, int id, string userName, string password, string type, Base @base):base(name, id, userName, password, type)
        {
            _base = @base;
        }
        public BaseMember() : base()
        {
            _base = new Base();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
