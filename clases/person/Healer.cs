using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;

public class Healer : BaseMember
{
    public Healer(string name, int id, string userName, string password, string type, Base @base) : base(name, id, userName, password, type, @base)
    {

        ListGlosary.listUsers.Add(this);
    }
    public Healer() : base()
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }
    public void HealSoldier(Soldier s)
    {
        s.Status = true;
        Base.ListMedicines.RemoveAt(0);
    }
}
