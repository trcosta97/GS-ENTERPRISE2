using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("tab_atividade")]
    public class Atividade
    {
        [Column("Id")]
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public CategoriaAtividade categoria{ get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }


}
