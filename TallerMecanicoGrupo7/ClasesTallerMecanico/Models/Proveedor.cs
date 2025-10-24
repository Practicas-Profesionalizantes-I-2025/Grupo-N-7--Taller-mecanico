using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    [Table("Proveedor")]
    public class Proveedor : Persona
    {
        [Required]
        [StringLength(15, MinimumLength = 11)]
        public string CuilCuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string CondFiscal { get; set; }

        public ICollection<Insumo> Insumos { get; set; }
        public ICollection<FacturaCompra> FacturasCompra { get; set; }
    }
}
