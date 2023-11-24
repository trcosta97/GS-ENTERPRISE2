using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("tab_endereco_usuario")]
    public class AtividadesUsuario
    {
        public int UsuarioId { get; set; }
        public Usuario usuario{ get; set; }
        public Atividade atividade{ get; set; }
        public int atividadeId { get; set; }
    }
}
