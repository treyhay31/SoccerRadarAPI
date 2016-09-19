using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.DataStore
{
    public interface IData<T>
    {
        IEnumerable<T> GetAll();
        T Find(string key);
        void Refresh();
    }
}
