public class General : BaseMember
{

    public General(string name, int id, string userName, string password, string type, Base @base) : base(name, id, userName, password, type)
    {
        ListGlosary.listGenerals.Add(this);
    }
    public General() : base()
    {
        ListGlosary.listGenerals.Add(this);
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public void MakeSquad()
    {
        Squad sq = new Squad(this.Base);
        foreach (var s in ListGlosary.listSoldiersTemporary)
        {
            sq.ListSquadsSoldiers.Add(s);
        }
        sq.CurrentBase = this.Base;
    }
    public Operation StartOperation(string n, int i)
    {
        Operation op = new Operation();
        op.OperationName = n;
        op.Dificulty = i;
        return op;
    }
    public void EnlistSoldier(string n)
    {
        Soldier s = new Soldier(this.Base);
        s.Name = n;
    }
    public void CreateBase(string str)
    {
        Base = new Base();
        Base.Name = str;
        Base.General = this;
    }

}

