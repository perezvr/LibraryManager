using LibraryManager.Application.DTO.DTO;
using LibraryManager.Application.Interfaces;
using LibraryManager.Domain.Core.Interfaces.Services;
using LibraryManager.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace LibraryManager.Application.Services
{
    public class LivroApplicationService : ILivroApplicationService
    {
        private readonly ILivroService _LivroService;
        private readonly ILivroMapper _LivroMapper;

        public LivroApplicationService(ILivroService LivroService, ILivroMapper LivroMapper)
        {
            _LivroService = LivroService;
            _LivroMapper = LivroMapper;
        }

        public LivroDTO Add(LivroDTO LivroDTO)
        {
            var livro = _LivroMapper.MapperToEntity(LivroDTO);
            return _LivroMapper.MapperToDTO(_LivroService.Add(livro));
        }

        public LivroDTO Update(int id, LivroDTO LivroDTO)
        {
            var livro = _LivroService.Get(id);
            livro.UpdateData(LivroDTO.ISBN, LivroDTO.Autor, LivroDTO.Nome, LivroDTO.Preco, LivroDTO.Publicacao, LivroDTO.ImagemCapa);
            return _LivroMapper.MapperToDTO(_LivroService.Update(livro));
        }

        public void Delete(int id) => _LivroService.Delete(_LivroService.Get(id));

        public IEnumerable<LivroDTO> Get()
        {
            var livros = _LivroService.Get();
            return _LivroMapper.MapperToListDTO(livros);
        }

        public LivroDTO Get(int id)
        {
            var livro = _LivroService.Get(id);
            return _LivroMapper.MapperToDTO(livro);
        }
    }
}
