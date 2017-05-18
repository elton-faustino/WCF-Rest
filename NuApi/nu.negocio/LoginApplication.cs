using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nu.requestWeak;
using Newtonsoft.Json;

namespace nu.negocio
{
    public class LoginApplication : Base
    {
        public LoginApplication ():base()
	    {

	    }

        public string Login()            
        {
            var res = JsonConvert.SerializeObject(new RootClass() { uSER = new User() { Conta = "010203", Senha = "MyPassword", Teste = new List<string>() { "1", "2", "outra" } } }) ;

            res = res.Replace("\"", "");

            return res;
        }
    }
}
