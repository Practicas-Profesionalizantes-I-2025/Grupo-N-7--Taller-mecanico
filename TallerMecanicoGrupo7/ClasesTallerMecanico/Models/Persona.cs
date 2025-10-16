using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    [Table("Persona")]
    public abstract class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(200)]
        public string Domicilio { get; set; }

        [Required]
        [ForeignKey("Localidad")]
        public int IdLocalidad { get; set; }
        public Localidad Localidad { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

    }
}
