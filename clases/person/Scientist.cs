using La_Alianza;
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
    public Item MakeItem(string type)
    {
        if (type == "Medicine")
        {
            Item i = new Item();
            i.Creator = this;
            i.Type = "Medicine";
            return i;
        }
        else
        {
            Item i = new Item();
            i.Creator = this;
            i.Type = "Gun";
            return i;
        }
    }
    public Cargament MakeCargament()
    {
        Cargament c = new Cargament();
        foreach (var item in ListGlosary.listPacking)
        {
            c.ListContents.Add(item);
            ListGlosary.listPacking.Remove(item);
        }
        return c;
    }
}



