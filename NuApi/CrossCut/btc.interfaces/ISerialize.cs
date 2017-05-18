using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.interfaces
{
    public interface ISerialize
    {
        string SerializeJSON<TEntity>(TEntity o);

        object DeserializeJSON<TEntity>(string json);
    }
}
