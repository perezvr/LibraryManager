using LibraryManager.Domain.Models;
using System.Collections.Generic;

namespace LibraryManager.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : ModelBase
    {
        void Add(T t);
        void Update(T t);
        void Delete(T obj);
        IEnumerable<T> Get();
        T Get(int id);
    }
}
