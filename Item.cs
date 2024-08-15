using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Item
    {
        private int _itemID;
        private Scientist _creator;

        /*  private enum _type
            {
                Medicine,
                Gun
            }*/
        // pedir ayuda a luck con el enum


        internal Scientist Creator { get => _creator; set => _creator = value; }

        public Item(int itemID, Scientist creator)
        {
            _itemID = itemID;
            _creator = creator;
        }
        public Item()
        {
            _itemID = 0;
            _creator = new Scientist();
        }
        public override string ToString()
        {
            return _itemID.ToString();
        }
    }
}
