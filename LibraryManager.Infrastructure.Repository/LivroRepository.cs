using LibraryManager.Domain.Core.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Data;
using System;

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

        public void Delete(Livro obj)
        {
            if (obj is null || obj.Id.Equals(0))
                throw new Exception("Livro não encontrado");

            DbSet.Remove(obj);
            _context.SaveChanges();
        }
    }
}
