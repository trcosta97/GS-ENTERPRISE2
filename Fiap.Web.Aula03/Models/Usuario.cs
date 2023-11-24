using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("tab_usuario")]
    public class Usuario
    {
        [Column("Id")]
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public int pontos { get; set; }

        public Endereco Endereco { get; set; }

        public IList<AtividadesUsuario> Atividades { get; set; }
    }
}
