using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class FacturaCompra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required]
        [ForeignKey("SesionCaja")]
        public int IdSesionCaja { get; set; }
        public SesionCaja SesionCaja { get; set; }

        [Required]
        public DateTime FechaFactura { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal TotalFactura { get; set; }

        // Denormalización
        [MaxLength(100)]
        public string NombreProveedor { get; set; }

        public ICollection<DetalleFacturaCompra> Detalles { get; set; }
    }
}
