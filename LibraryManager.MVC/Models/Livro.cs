using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.MVC.Models
{
    public class Livro : ModelBase
    {
        public Livro() { }

        public Livro(int id, string iSBN, string autor, string nome, decimal preco, DateTime publicacao)
        {
            Id = id;
            ISBN = iSBN;
            Autor = autor;
            Nome = nome;
            Preco = preco;
            Publicacao = publicacao;
        }

        [Required(ErrorMessage = "Informe o ISBN")]
        [MaxLength(13, ErrorMessage = "ISBN deve ter no máximo 50 caracteres")]
        public string ISBN { get; private set; }
        [Required(ErrorMessage = "Informe o autor")]
        [MaxLength(30, ErrorMessage = "Autor deve ter no máximo 30 caracteres")]
        public string Autor { get; private set; }
        [Required(ErrorMessage = "Informe o nome do livro")]
        [MaxLength(60, ErrorMessage = "Título deve ter no máximo 60 caracteres")]
        public string Nome { get; private set; }
        [Required(ErrorMessage = "Informe o preço do livro")]
        public decimal Preco { get; private set; }
        [Required(ErrorMessage = "Informe a data de publicação do livro")]
        public DateTime Publicacao { get; private set; }

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
