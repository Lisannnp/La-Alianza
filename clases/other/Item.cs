using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;


    public class Item
    {
        private int _itemID;
        private Scientist _creator;
        public string _type;

        internal Scientist Creator { get => _creator; set => _creator = value; }
        public int ItemID { get => _itemID; set => _itemID = value; }
        public string Type { get => _type; set => _type = value; }
        public Item(int itemID, Scientist creator, string type)
        {
            _itemID = ListGlosary.listItems.Count;
            _creator = creator;
            _type = type;
            ListGlosary.listItems.Add(this);
        }
        public Item()
        {
            _itemID = ListGlosary.listItems.Count;
            _creator = new Scientist();
            _type = "";
            ListGlosary.listItems.Add(this);
        }
    public override string ToString()
        {
            return ItemID.ToString();
        }
    }
