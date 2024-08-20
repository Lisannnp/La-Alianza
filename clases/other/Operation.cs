using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class Operation
    {
        private int _operationID;
        private int _difficulty;
        private Squad _squad;

        public int OperationID { get => _operationID; set => _operationID = value; }
        public int Difficulty { get => _difficulty; set => _difficulty = value; }
        internal Squad Squad { get => _squad; set => _squad = value; }
        public Operation(int operationID, int difficulty, Squad squad)
        {
            _operationID = operationID;
            _difficulty = difficulty;
            _squad = squad;
        }
        public Operation()
        {
            _operationID = 0;
            _difficulty = 0;
            _squad = new Squad();
        }
        public override string ToString()
        {
            return _operationID.ToString();
        }
    }
}
