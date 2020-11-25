using LibraryManager.Domain.Models;
using System.Collections.Generic;

namespace LibraryManager.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : ModelBase
    {
        T Add(T t);
        T Update(T t);
        void Delete(T t);
        IEnumerable<T> Get();
        T Get(int id);
    }
}
