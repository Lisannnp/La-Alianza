using La_Alianza;

public class Soldier : Person
{

    private Item _gun;
    private Squad _squad;
    private bool _status; // true = normal, false = herido 
    private Base _base;
    public bool Status { get => _status; set => _status = value; }
    internal Item Gun { get => _gun; set => _gun = value; }
    internal Squad Squad { get => _squad; set => _squad = value; }
    internal Base Base { get => _base; set => _base = value; }

    public Soldier(string name, int id, Item gun, Squad squad, bool status, Base @base):base(name, id)
    {
        _gun = gun;
        _squad = squad;
        _status = status;
        _base = @base;
        @base.ListSoldiers.Add(this);
    }
    public Soldier(Base @base)
    {
        _gun = new Item();
        _status = true;
        _base = new Base();
        @base.ListSoldiers.Add(this);
    }
    public override string ToString()
    {
        return Name;
    }
}

