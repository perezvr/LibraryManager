using System;
using System.Runtime.Serialization;

namespace LibraryManager.Application.DTO.DTO
{
    [DataContract]
    public class LivroDTO : ModelBaseDTO
    {
        public LivroDTO() { }

        public LivroDTO(int id, string iSBN, string autor, string nome, decimal preco, DateTime publicacao, byte[] imagemCapa)
        {
            Id = id;
            ISBN = iSBN;
            Autor = autor;
            Nome = nome;
            Preco = preco;
            Publicacao = publicacao;
            ImagemCapa = imagemCapa;
        }

        [DataMember(Name = "isbn")]
        public string ISBN { get; set; }
        [DataMember(Name = "autor")]
        public string Autor { get; set; }
        [DataMember(Name = "nome")]
        public string Nome { get; set; }
        [DataMember(Name = "preco")]
        public decimal Preco { get; set; }
        [DataMember(Name = "publicacao")]
        public DateTime Publicacao { get; set; }
        [DataMember(Name = "imagem_capa")]
        public byte[] ImagemCapa { get; set; }
    }
}
