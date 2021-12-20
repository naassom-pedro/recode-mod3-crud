using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Viajou.Models
{
    public class Destino
    {
       
        [Key]
        public int Id { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Pais { get; set; }
        public string Valor { get; set; }

        public virtual List<Venda> Venda { get; set; }
    }
}
