using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Fiap.Web.Aula03.Models
   {
    [Table("tab_endereco")]
    public class Endereco
    {

        [Column("Id")]
        public int Id { get; set; }

        [Required]
        public string Numero { get; set; }

        [Required]
        public string Rua { get; set; }
        
        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Pais { get; set; }
    }
}
