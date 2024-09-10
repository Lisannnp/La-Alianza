using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;

    public class Person
    {
        private string _name;
        private int _id;
        private static int _contadorID = 0;

        public string Name { get => _name; set => _name = value; }
        public int ID { get => _id; set => _id = value; }

        public Person(string name, int id)
        {
            _name = name;
            _id = ++_contadorID;
        }
        public Person()
        {
            _name = "";
            _id = ++_contadorID;
            
        }

        public override string ToString()
        {
            return _id.ToString();
        }

    }
