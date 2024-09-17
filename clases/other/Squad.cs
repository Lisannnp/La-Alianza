using La_Alianza;
using System.Collections.Generic;

public class Squad
{
    private int _squadID;
    private Base _currentBase;
    private List<Soldier> _listSquadsSoldiers = new List<Soldier>();  

    public int SquadID { get => _squadID; set => _squadID = value; }
    internal Base CurrentBase { get => _currentBase; set => _currentBase = value; }

    internal List<Soldier> ListSquadsSoldiers { get => _listSquadsSoldiers; set => _listSquadsSoldiers = value; }

    public Squad(int squadID, Base currentBase, List<Soldier> listSquadsSoldiers)
    {
        _squadID = currentBase.ListSquads.Count;
        _currentBase = currentBase;
        currentBase.ListSquads.Add(this);
        _listSquadsSoldiers = listSquadsSoldiers;
    }

    public Squad(Base currentBase)
    {
        _currentBase = currentBase;
        _squadID = currentBase.ListSquads.Count;
        currentBase.ListSquads.Add(this);
        _listSquadsSoldiers = new List<Soldier>();  
    }


    public void AddSoldier(Soldier s)
    {
        _listSquadsSoldiers.Add(s);  
    }

    public void RemoveSoldier(Soldier s)
    {
        _listSquadsSoldiers.Remove(s);  
    }

    public void Move(Squad s, Base b)
    {
        s._currentBase = b;  
    }
    public override string ToString()
    {
        return _squadID.ToString();
    }
}


