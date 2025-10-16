using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class TrabajoPorTurno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Turno")]
        public int IdTurno { get; set; }
        public Turno Turno { get; set; }

        [Required]
        [ForeignKey("Trabajo")]
        public int IdTrabajo { get; set; }
        public Trabajo Trabajo { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0.01, double.MaxValue)]
        public decimal HsHombre { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal TarifaHsHombre { get; set; }

        public string? Descripcion { get; set; }

        // --- Denormalización ---
        public string NombreMecanico { get; set; }
        public string ApellidoMecanico { get; set; }
        public string NombreTrabajo { get; set; }

        public ICollection<InsumoPorTrabajo> InsumosConsumidos { get; set; }
    }

}
