using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nu.requestWeak
{
    public class RootClass
    {
        public User uSER { get; set; }
    }


    public class User
    {
        public string Conta { get; set; }

        public string Senha { get; set; }

        public List<string> Teste { get; set; }
    }
}
