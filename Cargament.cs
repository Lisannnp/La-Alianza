using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Cargament
    {
        private int _cargamentID;
        private Base _destination;
        private Distributor _distributor;

        public int CargamentID { get => _cargamentID; set => _cargamentID = value; }
        internal Base Destination { get => _destination; set => _destination = value; }
        internal Distributor Distributor { get => _distributor; set => _distributor = value; }
        public Cargament(int cargamentID, Base destination, Distributor distributor)
        {
            _cargamentID = cargamentID;
            _destination = destination;
            _distributor = distributor;
        }
        public Cargament()
        {
            _cargamentID = 0;
            _destination = new Base();
            _distributor = new Distributor();
        }
        public override string ToString()
        {
            return _cargamentID.ToString();
        }
    }
}
