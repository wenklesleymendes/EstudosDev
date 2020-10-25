using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PremierLearn.Cursos.CursoWebapi.Models.Entities
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O nome não pode ultrapassar 200 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessário informar a edição desse livro.")]
        public string Edicao { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "O número de página deve estar entre {1} e {2}.")]
        public int NumeroPagina { get; set; }
        public decimal Preco { get; set; }
        //public string Editora { get; set; }

        [Url(ErrorMessage = "Esse campo necessita de uma url válida.")]
        public string SiteLivro { get; set; }

        [EmailAddress(ErrorMessage = "Necessário um e-mail válido.")]
        public string EmailAutor { get; set; }
        [ForeignKey("Editora")]
        public Guid CodigoEditora { get; set; }

        [JsonIgnore]
        public virtual Editora Editora { get; set; } //Propriedade_IdDaClasse
    }
}