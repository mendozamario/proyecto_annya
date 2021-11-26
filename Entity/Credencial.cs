using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Credencial
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string AutogenerateAccess(string name, string lastName)
        { 
            return name.ToLower() + lastName.ToLower();
        }
    }
}
