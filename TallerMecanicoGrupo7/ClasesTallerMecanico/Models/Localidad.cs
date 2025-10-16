using System.ComponentModel.DataAnnotations;

namespace ClasesTallerMecanico.Models
{
    public class Localidad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [Range(1000, 9999)]
        public int CodigoPostal { get; set; }

        [Required]
        public string Provincia { get; set; }
    }
}
