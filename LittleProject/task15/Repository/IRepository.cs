using System;
using System.Collections.Generic;

namespace task15.Repository
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> List();
        T Get(int id);

        void Create(T user);
        void Update(T user);
        void Delete(int id);
        void Save();
    }
}
