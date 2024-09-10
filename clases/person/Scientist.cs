using La_Alianza;


public class Scientist : User
{

    public Scientist(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
    {
        ListGlosary.listUsers.Add(this);
    }
    public Scientist() : base()
    {

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
    public Cargament MakeCargament(Item i)
    {
        Cargament c = new Cargament();
        c.ListContents.Add(i);
        return c;
    }
}



