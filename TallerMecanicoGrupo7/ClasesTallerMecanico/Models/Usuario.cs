using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    [Table("Usuario")]
    public class Usuario : Persona
    {

        [Required]
        [MaxLength(15)]
        public string Dni { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [Required]
        [ForeignKey("Rol")]
        public int IdRol { get; set; }
        public Rol Rol { get; set; }

        [Required]
        [MaxLength(256)]
        public string ContraseñaHash { get; set; }

        public ICollection<SesionCaja> SesionesCaja { get; set; }
        public ICollection<TrabajoPorTurno> TrabajosRealizados { get; set; }

    }
}
