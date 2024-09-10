using La_Alianza;

    public class General : BaseMember
    {

        public General(string name, int id, string userName, string password, string type, Base @base) : base(name, id, userName, password, type, @base)
        {
            ListGlosary.listUsers.Add(this);
        }
        public General() : base()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public Squad MakeSquad(Soldier s)
        {
            Squad sq = new Squad();
            sq.ListSquadsSoldiers.Add(s);
            sq.CurrentBase = this.Base;
            return sq;
        }
        public Operation StartOperation(Squad sq)
        {
            Operation op = new Operation();
            op.Ssquad = sq;
            return op;
        }
        public Soldier EnlistSoldier()
        {
            Soldier s = new Soldier();
            s.Base = this.Base;
            return s;
        }
        public Base CreateBase(string str)
        {
            Base @base = new Base();
            @base.Name = str;
            @base.General = this;
            return @base;
        }

    }

