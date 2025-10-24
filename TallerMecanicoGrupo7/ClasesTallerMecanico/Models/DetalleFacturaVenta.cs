using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class DetalleFacturaVenta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("FacturaVenta")]
        public int IdFactura { get; set; }
        public FacturaVenta FacturaVenta { get; set; }

        [Required]
        [MaxLength(50)]
        public string TipoItem { get; set; }

        [ForeignKey("TrabajoPorTurno")]
        public int? IdTrabajoPorTurno { get; set; }
        public TrabajoPorTurno? TrabajoPorTurno { get; set; }

        [ForeignKey("InsumoPorTrabajo")]
        public int? IdInsumoPorTrabajo { get; set; }
        public InsumoPorTrabajo? InsumoPorTrabajo { get; set; }

        [Required]
        [MaxLength(500)]
        public string DescripcionItem { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0.01, (double)decimal.MaxValue)]
        public decimal Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal PrecioUnitario { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal TotalDetalle { get; set; }

        // --- Denormalización ---
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal CostoUnitarioInsumoHistorico { get; set; }

        [MaxLength(100)]
        public string? NombreTrabajoPorTurno { get; set; }
    }
}
