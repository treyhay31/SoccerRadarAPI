﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.DataStore
{
    public interface IDataStore<T>
    {
        IEnumerable<T> GetAll();
        T Find(string key);
    }
}
