using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Squad
    {
        public static List<Squad> listSquads = new List<Squad>();
        private int _squadID;
        private Base _currentBase;

        public int SquadID { get => _squadID; set => _squadID = value; }
        internal Base CurrentBase { get => _currentBase; set => _currentBase = value; }
        public Squad(int squadID, Base currentBase)
        {
            _squadID = squadID;
            _currentBase = currentBase;
            listSquads.Add(this);
        }
        public Squad()
        {
            _squadID = 0;
            _currentBase = new Base();
        }
        public override string ToString()
        {
            return _squadID.ToString();
        }
    }
}
