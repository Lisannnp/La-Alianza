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
        private static List<Item> _listMedicines = new List<Item>();
        private static List<Item> _listGuns = new List<Item>();

        public int BaseID { get => _baseID; set => _baseID = value; }
        public string Name { get => _name; set => _name = value; }
        internal General General { get => _general; set => _general = value; }
        internal static List<Item> ListMedicines { get => _listMedicines; set => _listMedicines = value; }
        internal static List<Item> ListGuns { get => _listGuns; set => _listGuns = value; }

        public Base(int baseID, string name, General general, List<Item> listMedicines, List<Item> listGuns)
        {
            _baseID = baseID;
            _name = name;
            _general = general;
            _listGuns = listGuns;
            _listMedicines = listMedicines;
        }
        public Base()
        {
            _baseID = 0;
            _name = "";
            _general = new General();
            _listMedicines = new List<Item> { };
            _listGuns = new List<Item> { };
        }
        public override string ToString()
        {
            return _baseID.ToString();
        }
    }
}
