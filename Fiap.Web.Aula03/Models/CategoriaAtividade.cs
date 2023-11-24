using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("tab_atividade")]
    public class CategoriaAtividade
    {
        [Column("Id")]
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Nome{ get; set; }

        [DataType(DataType.Date)]
        public int Pontos{ get; set; }
    }


}
