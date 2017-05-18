﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btc.interfaces
{
    public interface ISerialize
    {
        string SerializeJSON<TEntity>(string request);

        object DeserializeJSON<TEntity>(string json);
    }
}
