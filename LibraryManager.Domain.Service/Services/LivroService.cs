using LibraryManager.Domain.Core.Interfaces.Repositories;
using LibraryManager.Domain.Core.Interfaces.Services;
using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Service.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _LivroRepository;

        public LivroService(ILivroRepository LivroRepository)
            : base(LivroRepository)
        {
            _LivroRepository = LivroRepository;
        }
    }
}
