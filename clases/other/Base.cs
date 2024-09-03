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
        private static List<Squad> _listSquads = new List<Squad>();
        private static List<Soldier> _listSoldiers = new List<Soldier>();

        public int BaseID { get => _baseID; set => _baseID = value; }
        public string Name { get => _name; set => _name = value; }
        internal General General { get => _general; set => _general = value; }
        internal static List<Item> ListMedicines { get => _listMedicines; set => _listMedicines = value; }
        internal static List<Item> ListGuns { get => _listGuns; set => _listGuns = value; }
        internal static List<Squad> ListSquads { get => _listSquads; set => _listSquads = value; }
        internal static List<Soldier> ListSoldiers { get => _listSoldiers; set => _listSoldiers = value; }

        public Base(int baseID, string name, General general, List<Item> listMedicines, List<Item> listGuns, List<Squad> listSquads, List<Soldier> listSoldiers)
        {
            _baseID = baseID;
            _name = name;
            _general = general;
            _listGuns = listGuns;
            _listMedicines = listMedicines;
            _listSquads = listSquads;
            _listSoldiers = listSoldiers;

        }
        public Base()
        {
            _baseID = 0;
            _name = "";
            _general = new General();
            _listMedicines = new List<Item> { };
            _listGuns = new List<Item> { };
            _listSquads = new List<Squad> { };
        }
        public override string ToString()
        {
            return _baseID.ToString();
        }
    }
}
