using System.ComponentModel.DataAnnotations;

namespace ClasesTallerMecanico.Models
{
    public class CategoriaTrabajo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Categoria { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

        public ICollection<Trabajo> Trabajos { get; set; }
    }
}
