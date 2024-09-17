using System;


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
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                }
                break;
            case 2:
                if (random.Next(100) < 50)
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = true; }
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                }
                break;
            case 3:
                if (random.Next(100) < 30)
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = true; }
                }
                else
                {
                    foreach (var item in s.ListSquadsSoldiers) { item.Status = false; }
                }
                break;

        }
    }
    public override string ToString()
    {
        return $"{_operationName} ID:{_operationID}  ";
    }

}
