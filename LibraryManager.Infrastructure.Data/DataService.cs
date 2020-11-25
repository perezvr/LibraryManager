using LibraryManager.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LibraryManager.Infrastructure.Data
{
    public class DataService : IDataService
    {
        public void InitializeDB(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationContext>();
            context.Database.Migrate();
        }
    }
}
