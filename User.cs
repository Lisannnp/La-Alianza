using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Alianza
{
    class User:Person
    {
        private string _userName;
        private string _password;
        private string _type;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Type { get => _type; set => _type = value; }
        public User(string name, int id, string userName, string password, string type):base(name, id)
        {
            _userName = userName;
            _password = password;
            _type = type;
        }
        public User() : base()
        {
            _userName = "";
            _password = "";
            _type = "";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
