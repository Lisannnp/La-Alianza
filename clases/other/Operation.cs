using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;


    public class Operation
    {
        private int _operationID;
        private Squad _squad;

        public int OperationID { get => _operationID; set => _operationID = value; }
        internal Squad Ssquad { get => _squad; set => _squad = value; }
        public Operation(int operationID, int difficulty, Squad squad)
        {
            _operationID = ListGlosary.listOperations.Count;
            _squad = squad;
        ListGlosary.listOperations.Add(this);
        }
        public Operation()
        {
            _operationID = ListGlosary.listOperations.Count;
            _squad = new Squad();
        }
        public override string ToString()
        {
            return _operationID.ToString();
        }
        public void RunOperation()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 2); 
            if (randomValue == 1) 
            {
                foreach (var I in Ssquad.ListSquadsSoldiers)
                {
                    I.Status = true;
                }
            }else
            {
                foreach (var Item in Ssquad.ListSquadsSoldiers)
                {
                    Item.Status = false;
                }
            }
        }
    }
