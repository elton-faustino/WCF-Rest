using nu.interfaces;
using nu.requestWeak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using nu.negocio;

namespace nu.implementacao
{
    public abstract class Security : ISecurity
    {
        public string Login()
        {
            try
            {
                //return new LoginApplication().Login(request);
            }
            catch (Exception ex)
            {
                //return warning message
            }

            return string.Empty;
        }
    }
}
