using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class Maquina
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(100)]
        public string Motor { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Patente { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

        public ICollection<Turno> Turnos { get; set; }
    }
}
