using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using La_Alianza;


    public class Distributor:User
    {
        
        public Distributor(string name, int id, string userName, string password, string type) : base(name, id, userName, password, type)
        {
            ListGlosary.listDistributors.Add(this);
        }
        public Distributor() : base()
        {
            ListGlosary.listDistributors.Add(this);
        }
    public override string ToString()
        {
            return base.ToString();
        }
    }
