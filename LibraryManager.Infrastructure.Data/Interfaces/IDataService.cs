using System;

namespace LibraryManager.Infrastructure.Data.Interfaces
{
    public interface IDataService
    {
        public void InitializeDB(IServiceProvider serviceProvider);
    }
}
