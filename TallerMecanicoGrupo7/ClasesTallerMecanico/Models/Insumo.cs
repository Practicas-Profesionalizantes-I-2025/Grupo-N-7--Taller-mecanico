using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class Insumo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        [Required]
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal PrecioCompra { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal PrecioVenta { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

        // Denormalización
        [MaxLength(100)]
        public string NombreProveedor { get; set; }

        public ICollection<InsumoPorTrabajo> InsumosPorTrabajo { get; set; }
        public ICollection<DetalleFacturaCompra> DetallesCompra { get; set; }
    }

}
