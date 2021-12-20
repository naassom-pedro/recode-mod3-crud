using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Viajou.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public string ValorTotal { get; set; }
        public int Desconto { get; set; }

        [ForeignKey("Cliente")]
        [Display(Name = "Nome do cliente")]

        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("Destino")]
        [Display(Name = "Cidade")]
        public int DestinoId { get; set; }
        public virtual Destino Destino { get; set; }
    }
}
