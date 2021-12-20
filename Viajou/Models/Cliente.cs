using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Viajou.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Cpf { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public virtual List<Venda> Venda { get; set; }
    }
}
