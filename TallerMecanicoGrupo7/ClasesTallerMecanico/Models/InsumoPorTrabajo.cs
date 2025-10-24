using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class InsumoPorTrabajo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("TrabajoPorTurno")]
        public int IdTrabajoTurno { get; set; }
        public TrabajoPorTurno TrabajoPorTurno { get; set; }

        [Required]
        [ForeignKey("Insumo")]
        public int IdInsumo { get; set; }
        public Insumo Insumo { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal CostoInsumo { get; set; }

        [Required]
        [Range(1, int.MaxValue)] // CHECK (> 0)
        public int Cantidad { get; set; }

        // --- Denormalización (Preservación Histórica) ---
        [MaxLength(100)]
        public string NombreInsumo { get; set; }
        [MaxLength(500)]
        public string? DescripcionInsumo { get; set; }

        public ICollection<DetalleFacturaVenta> DetallesVenta { get; set; }
    }

}
