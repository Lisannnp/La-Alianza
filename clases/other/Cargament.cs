using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza.clases.other;

namespace La_Alianza
{
    class Cargament
    {
        private int _cargamentID;
        private Base _destination;
        private static List<Item> _listContents = new List<Item>();

        public int CargamentID { get => _cargamentID; set => _cargamentID = value; }
        internal Base Destination { get => _destination; set => _destination = value; }
        internal static List<Item> ListContents { get => _listContents; set => _listContents = value; }

        public Cargament(int cargamentID, Base destination, List<Item> listContents)
        {
            _cargamentID = cargamentID;
            _destination = destination;
            _listContents = listContents;
            ListGlosary.listCargaments.Add(this);
        }
        public Cargament()
        {
            _cargamentID = 0;
            _destination = new Base();
            _listContents = new List<Item>();
        }
        public override string ToString()
        {
            return _cargamentID.ToString();
        }
        public void Allocate ()
        {
            foreach (var i in Cargament.ListContents)
            {
                if (i.Type == Item._type.Gun)
                {
                    Base.ListGuns.Add(i);
                }
                else
                {
                    Base.ListMedicines.Add(i);
                }
            }
        }
    }
}
