using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class Trabajo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("CategoriaTrabajo")]
        public int IdCategoria { get; set; }
        public CategoriaTrabajo CategoriaTrabajo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, (double)decimal.MaxValue)]
        public decimal PrecioHsManoObra { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

        public ICollection<TrabajoPorTurno> TrabajosPorTurno { get; set; }
    }
}
