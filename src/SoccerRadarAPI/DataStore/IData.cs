using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.DataStore
{
    public interface IData<T>
    {
        /// <summary>
        /// Get all of the specified type
        /// </summary>
        /// <returns>List of objects</returns>
        IEnumerable<T> GetAll();
        
        /// <summary>
        /// Get a single specified type by ID
        /// </summary>
        /// <param name="key">36 character guid for the object</param>
        /// <returns>A single object</returns>
        T Find(string key);

        /// <summary>
        /// Update the cached/stored data
        /// </summary>
        void Refresh();
    }
}
