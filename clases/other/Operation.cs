using System;
using System.Windows.Forms;


public class Operation
{
    private int _operationID;
    private int _dificulty;
    private string _operationName;

    public int OperationID { get => _operationID; set => _operationID = value; }
    public string OperationName { get => _operationName; set => _operationName = value; }
    public int Dificulty { get => _dificulty; set => _dificulty = value; }
    public Operation(int operationID, int difficulty, string operationName)
    {
        _operationID = ListGlosary.listOperations.Count;
        _operationName = operationName;
        _dificulty = difficulty;
        ListGlosary.listOperations.Add(this);
    }
    public Operation()
    {
        _operationID = ListGlosary.listOperations.Count;
        _dificulty = 0;
        _operationName = "";
        ListGlosary.listOperations.Add(this);
    }
    public void RunOperation(int i, Squad s)
    {
        Random random = new Random();
        switch (i)
        {
            case 1:
                if (random.Next(100) < 80)
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = true; }
                    MessageBox.Show("Mission succesfull, all soldiers healthy");
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                    MessageBox.Show("Mission failed, all soldiers injured");
                }
                break;
            case 2:
                if (random.Next(100) < 50)
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = true; }
                    MessageBox.Show("Mission succesfull, all soldiers healthy");
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                    MessageBox.Show("Mission failed, all soldiers injured");
                }
                break;
            case 3:
                if (random.Next(100) < 30)
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = true; }
                    MessageBox.Show("Mission succesfull, all soldiers healthy");
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                    MessageBox.Show("Mission failed, all soldiers injured");
                }
                break;
        }
        foreach(var a in s.ListSquadsSoldiers)
        {
            Console.WriteLine($"Nombre: {a.Name}, Status: {a.Status}");
        }

    }
    public override string ToString()
    {
        return $"{_operationName} ID:{_operationID}  ";
    }

}
