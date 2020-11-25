using LibraryManager.Application.DTO.DTO;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace LibraryManager.Infrastructure.CrossCutting.Adapter.Maps
{
    public class LivroMapper : ILivroMapper
    {
        public IEnumerable<LivroDTO> MapperToListDTO(IEnumerable<Livro> livros)
        {
            List<LivroDTO> livrosDTO = new List<LivroDTO>();

            foreach (var Livro in livros)
                livrosDTO.Add(MapperToDTO(Livro));

            return livrosDTO;
        }

        public LivroDTO MapperToDTO(Livro livro) => livro != null ? new LivroDTO(livro.Id, livro.ISBN, livro.Autor, livro.Nome, livro.Preco, livro.Publicacao, livro.ImagemCapa) : null;

        public Livro MapperToEntity(LivroDTO livroDTO) => livroDTO != null ? new Livro(livroDTO.Id, livroDTO.ISBN, livroDTO.Autor, livroDTO.Nome, livroDTO.Preco, livroDTO.Publicacao, livroDTO.ImagemCapa) : null;
    }
}
