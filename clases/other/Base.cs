using La_Alianza;
using System.Collections.Generic;

public class Base
{
    private int _baseID;
    private string _name;
    private General _general;
    private List<Item> _listMedicines;
    private List<Item> _listGuns;
    private List<Squad> _listSquads;
    private List<Soldier> _listSoldiers;

    public int BaseID { get => _baseID; set => _baseID = value; }
    public string Name { get => _name; set => _name = value; }
    public General General { get => _general; set => _general = value; }
    public List<Item> ListMedicines { get => _listMedicines; set => _listMedicines = value; }
    public List<Item> ListGuns { get => _listGuns; set => _listGuns = value; }
    public List<Squad> ListSquads { get => _listSquads; set => _listSquads = value; }
    public List<Soldier> ListSoldiers { get => _listSoldiers; set => _listSoldiers = value; }

    public Base(string name, General general, List<Item> listMedicines, List<Item> listGuns, List<Squad> listSquads, List<Soldier> listSoldiers)
    {
        _baseID = ListGlosary.listBases.Count;
        _name = name;
        _general = general;
        _listGuns = listGuns;
        _listMedicines = listMedicines;
        _listSquads = listSquads;
        _listSoldiers = listSoldiers;
        ListGlosary.listBases.Add(this);
    }

    public Base()
    {
        _baseID = ListGlosary.listBases.Count;
        _name = "";
        _general = new General();
        _listMedicines = new List<Item>();
        _listGuns = new List<Item>();
        _listSquads = new List<Squad>();
        _listSoldiers = new List<Soldier>();
        ListGlosary.listBases.Add(this);
    }

    public override string ToString()
    {
        return _baseID.ToString();
    }
}
