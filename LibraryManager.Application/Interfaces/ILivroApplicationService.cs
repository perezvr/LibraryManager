using LibraryManager.Application.DTO.DTO;
using System.Collections.Generic;

namespace LibraryManager.Application.Interfaces
{
    public interface ILivroApplicationService
    {
        LivroDTO Add(LivroDTO obj);
        LivroDTO Update(int id, LivroDTO obj);
        void Delete(int id);
        IEnumerable<LivroDTO> Get();
        LivroDTO Get(int id);
    }
}
