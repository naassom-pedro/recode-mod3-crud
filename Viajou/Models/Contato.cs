using System.ComponentModel.DataAnnotations;

namespace Viajou.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Mensagem { get; set; }
    }
}
