using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Repositories
{
    public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T Find(string key);
        T Remove(string key);
        void Update(T item);
    }
}
