using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;

public class Healer : BaseMember
{
    public Healer(string name, int id, string userName, string password, string type ) : base(name, id, userName, password, type)
    {

        ListGlosary.listHealers.Add(this);
    }
    public Healer() : base()
    {
        ListGlosary.listHealers.Add(this);

    }
    public override string ToString()
    {
        return base.ToString();
    }
    public void HealSoldier(Soldier s)
    {
        Console.WriteLine("mi abuela es una genia");
        s.Status = true;
        Base.ListMedicines.RemoveAt(0);
        Console.WriteLine($"new status for {s.Name} is {s.Status}");
    }
}
