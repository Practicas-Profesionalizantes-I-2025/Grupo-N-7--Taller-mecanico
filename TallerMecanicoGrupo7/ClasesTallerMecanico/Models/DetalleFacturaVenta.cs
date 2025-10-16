using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string TipoItem { get; set; }

        [ForeignKey("TrabajoPorTurno")]
        public int? IdTrabajoPorTurno { get; set; }
        public TrabajoPorTurno? TrabajoPorTurno { get; set; }

        [ForeignKey("InsumoPorTrabajo")]
        public int? IdInsumoPorTrabajo { get; set; }
        public InsumoPorTrabajo? InsumoPorTrabajo { get; set; }

        [Required]
        public string DescripcionItem { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0.01, double.MaxValue)]
        public decimal Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal PrecioUnitario { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal TotalDetalle { get; set; }

        // --- Denormalización (Preservación Histórica) ---
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal CostoUnitarioInsumoHistorico { get; set; }

        public string? NombreTrabajoPorTurno { get; set; }
    }
}
