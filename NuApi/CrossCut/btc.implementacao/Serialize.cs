using btc.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace btc.implementacao
{
    public abstract class Serialize : ISerialize
    {

        public string SerializeJSON<TEntity>(string request)
        {
            var oRootObject = Activator.CreateInstance<TEntity>();

            var json = new JavaScriptSerializer().Serialize(oRootObject);

            return json;
        }

        public object DeserializeJSON<TEntity>(string request)
        {
            var oJS = new JavaScriptSerializer();

            var oRootObject = Activator.CreateInstance<TEntity>();

            return oRootObject = oJS.Deserialize<TEntity>(request);
        }

    }
}
