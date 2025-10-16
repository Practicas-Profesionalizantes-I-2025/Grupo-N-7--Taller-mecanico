using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Range(0, double.MaxValue)]
        public decimal CostoInsumo { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }

        // --- Denormalización (Preservación Histórica) ---
        public string NombreInsumo { get; set; }
        public string? DescripcionInsumo { get; set; }
    }

}
