using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;


    public class Cargament
    {
        private int _cargamentID;
        private Base _destination;
        private List<Item> _listContents = new List<Item>();

        public int CargamentID { get => _cargamentID; set => _cargamentID = value; }
        public Base Destination { get => _destination; set => _destination = value; }
        public List<Item> ListContents { get => _listContents; set => _listContents = value; }

        public Cargament(int cargamentID, Base destination, List<Item> listContents)
        {
            _cargamentID = ListGlosary.listCargaments.Count;
            _destination = destination;
            _listContents = listContents;
            ListGlosary.listCargaments.Add(this);
        }
        public Cargament()
        {
            _cargamentID = ListGlosary.listCargaments.Count;
            _listContents = new List<Item>();
            ListGlosary.listCargaments.Add(this);
    }
        public override string ToString()
        {
            return _cargamentID.ToString();
        }
        public void Allocate ()
        {
            foreach (var i in _listContents)
            {
                if (i.Type == "Gun")
                {
                    _destination.ListGuns.Add(i);
                }
                else
                {
                    _destination.ListMedicines.Add(i);
                }
            }
        }
    }

