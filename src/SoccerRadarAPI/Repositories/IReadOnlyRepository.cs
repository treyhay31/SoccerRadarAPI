using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Repositories
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> GetAll();
        T Find(string key);
    }
}
