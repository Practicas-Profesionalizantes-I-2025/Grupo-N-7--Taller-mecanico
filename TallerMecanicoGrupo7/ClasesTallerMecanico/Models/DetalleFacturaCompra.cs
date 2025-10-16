using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class DetalleFacturaCompra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("FacturaCompra")]
        public int IdFacturaCompra { get; set; }
        public FacturaCompra FacturaCompra { get; set; }

        [Required]
        [ForeignKey("Insumo")]
        public int IdInsumo { get; set; }
        public Insumo Insumo { get; set; }

        [Required]
        public DateTime FechaCompra { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal PrecioUnitario { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal TotalCompra { get; set; }
    }
}
