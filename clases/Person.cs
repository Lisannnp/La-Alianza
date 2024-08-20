using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Person
    {
        private string _name;
        private int _id;

        public string Name { get => _name; set => _name = value; }
        public int ID { get => _id; set => _id = value; }

        public Person(string name, int id)
        {
            _name = name;
            _id = id;
        }
        public Person()
        {
            _name = "";
            _id = 0;
        }

        public override string ToString()
        {
            return _id.ToString();
        }

    }
}
