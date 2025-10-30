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
        public Proveedor Proveedor { get; set; } //relacion  1 a 1 con proveedor

        [Required]
        [ForeignKey("SesionCaja")]
        public int IdSesionCaja { get; set; }
        public SesionCaja SesionCaja { get; set; } //relacion  1 a 1 con sesion caja

        [Required(ErrorMessage = "La fecha de factura es requerida.")]
        public DateTime FechaFactura { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal TotalFactura { get; set; }

        public bool Pagado { get; set; }

        [Required]
        public DateTime FechaPagoFactura { get; set; }

        // Denormalización
        [MaxLength(100)]
        public string NombreProveedor { get; set; } // Almacena el nombre del proveedor para evitar joins frecuentes

        public ICollection<DetalleFacturaCompra> Detalles { get; set; } //relacion 1 a muchos con detalle factura compra
    }
}
