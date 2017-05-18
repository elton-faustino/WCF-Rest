using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nu.requestWeak;

namespace nu.negocio
{
    public class LoginApplication : Base
    {
        public LoginApplication ():base()
	    {

	    }

        public string Login(string request)            
        {
            return SerializeJSON<User>(request);
        }
    }
}
