using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class FacturaVenta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("SesionCaja")]
        public int IdSesionCaja { get; set; }
        public SesionCaja SesionCaja { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        [ForeignKey("Turno")]
        public int IdTurno { get; set; }
        public Turno Turno { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal TotalFactura { get; set; }

        // --- Denormalización (Reportes Financieros) ---
        public string NombreCliente { get; set; }
        public string CuilCuitCliente { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal CostoTotalServicio { get; set; }
    }

}
