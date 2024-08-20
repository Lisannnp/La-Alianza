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

          public enum _type
            {
                Medicine,
                Gun
            }
        //pedir ayuda a luck con el enum


        internal Scientist Creator { get => _creator; set => _creator = value; }
        public int ItemID { get => _itemID; set => _itemID = value; }
        public  _type Type { get; set; }

        public Item(int itemID, Scientist creator, _type type)
        {
            _itemID = itemID;
            _creator = creator;
            Type = type;
            ListGlosary.listItems.Add(this);

        }
        public Item()
        {
            _itemID = 0;
            _creator = new Scientist();
            Type = _type.Gun;
        }
        public override string ToString()
        {
            return ItemID.ToString();
        }
    }
}
