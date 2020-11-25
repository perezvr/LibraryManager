using LibraryManager.Domain.Core.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Data;

namespace LibraryManager.Infrastructure.Repository
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        private readonly ApplicationContext _context;

        public LivroRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
