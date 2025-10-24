using System.ComponentModel.DataAnnotations;

namespace ClasesTallerMecanico.Models
{
    public class Localidad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Range(1000, 99999)] // Longitud adaptada para códigos postales más largos
        public int CodigoPostal { get; set; }

        [Required]
        [MaxLength(50)]
        public string Provincia { get; set; }

        // Propiedades de navegación
        public ICollection<Persona> Personas { get; set; }
    }
}
