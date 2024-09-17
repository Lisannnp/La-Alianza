using La_Alianza;
using System;
using System.Collections.Generic;
using System.Linq;


public class Scientist : User
{

    public Scientist(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
    {
        ListGlosary.listScientists.Add(this);
    }
    public Scientist() : base()
    {
        ListGlosary.listScientists.Add(this);
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public void MakeItem(string type, string n)
    {
        if (type == "Medicine")
        {
            Item i = new Item();
            i.Creator = this;
            i.Type = "Medicine";
            i.Name = n;
        }
        else
        {
            Item i = new Item();
            i.Creator = this;
            i.Type = "Gun";
            i.Name = n;
        }
    }
    public void MakeCargament()
    {
        Cargament c = new Cargament();
        c.ListContents = ListGlosary.listPacking;
        ListGlosary.listPacking.Clear();
    }
}



