using LibraryManager.Application.DTO.DTO;
using LibraryManager.Domain.Models;

namespace LibraryManager.Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface ILivroMapper : IMapperBase<Livro, LivroDTO> { }
}
