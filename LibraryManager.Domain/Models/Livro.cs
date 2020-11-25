using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.Domain.Models
{
    public class Livro : ModelBase
    {
        private Livro() { }

        public Livro(int id, string iSBN, string autor, string nome, decimal preco, DateTime publicacao, byte[] imagemCapa)
        {
            Id = id;
            ISBN = iSBN;
            Autor = autor;
            Nome = nome;
            Preco = preco;
            Publicacao = publicacao;
            ImagemCapa = imagemCapa;
        }

        [Required]
        [MaxLength(13, ErrorMessage = "ISBN deve ter no máximo 50 caracteres")]
        public string ISBN { get; private set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Autor deve ter no máximo 30 caracteres")]
        public string Autor { get; private set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Título deve ter no máximo 60 caracteres")]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }
        [Required]
        public DateTime Publicacao { get; private set; }
        [Required]
        public byte[] ImagemCapa { get; private set; }

        public void UpdateData(string iSBN, string autor, string nome, decimal preco, DateTime publicacao, byte[] imagemCapa)
        {
            ISBN = iSBN;
            Autor = autor;
            Nome = nome;
            Preco = preco;
            Publicacao = publicacao;
            ImagemCapa = imagemCapa;
        }
    }
}
