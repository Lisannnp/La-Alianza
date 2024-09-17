public class Item
{
    private string _name;
    private int _itemID;
    private string _type;
    private Scientist _creator;

    public Scientist Creator { get => _creator; set => _creator = value; }
    public int ItemID { get => _itemID; set => _itemID = value; }
    public string Type { get => _type; set => _type = value; }
    public string Name { get => _name; set => _name = value; }

    public Item(int itemID, Scientist creator, string type, string name)
    {
        _name = name;
        _itemID = ListGlosary.listItems.Count;
        _creator = creator;
        _type = type;
        ListGlosary.listItems.Add(this);
    }
    public Item()
    {
        _name = "";
        _itemID = ListGlosary.listItems.Count;
        _creator = new Scientist();
        _type = "";
        ListGlosary.listItems.Add(this);
    }
    public override string ToString()
    {
        return $"{_name} ID:{_itemID}";
    }
}
