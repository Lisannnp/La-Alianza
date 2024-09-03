using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza.clases.other;

namespace La_Alianza
{
    class Soldier:Person
    {
        
        private Item _gun;
        private Squad _squad;
        private bool _status;
        private Base _base;
        public bool Status { get => _status; set => _status = value; }
        internal Item Gun { get => _gun; set => _gun = value; }
        internal Squad Squad { get => _squad; set => _squad = value; }
        internal Base Base { get => _base; set => _base = value; }

        public Soldier(Item gun, Squad squad, bool status, Base @base)
        {
            _gun = gun;
            _squad = squad;
            _status = status;
            _base = @base;
            Base.ListSoldiers.Add(this);
        }
        public Soldier()
        {
            _gun = new Item();
            _squad = new Squad();
            _status = true;
            _base = new Base();
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
