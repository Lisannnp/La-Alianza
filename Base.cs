using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Base
    {
        private int _baseID;
        private string _name;
        private General _general;

        public int BaseID { get => _baseID; set => _baseID = value; }
        public string Name { get => _name; set => _name = value; }
        internal General General { get => _general; set => _general = value; }

        public Base(int baseID, string name, General general)
        {
            _baseID = baseID;
            _name = name;
            _general = general;
        }
        public Base()
        {
            _baseID = 0;
            _name = "";
            _general = new General();
        }
        public override string ToString()
        {
            return _baseID.ToString();
        }
    }
}
