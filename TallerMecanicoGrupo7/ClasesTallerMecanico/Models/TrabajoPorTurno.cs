using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Range(0.01, (double)decimal.MaxValue)]
        public decimal HsHombre { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal TarifaHsHombre { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        // --- Denormalización ---
        [MaxLength(100)]
        public string NombreMecanico { get; set; }
        [MaxLength(100)]
        public string ApellidoMecanico { get; set; }
        [MaxLength(100)]
        public string NombreTrabajo { get; set; }

        public ICollection<InsumoPorTrabajo> InsumosConsumidos { get; set; }
    }

}
