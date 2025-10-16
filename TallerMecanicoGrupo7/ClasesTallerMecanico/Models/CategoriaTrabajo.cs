using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    public class CategoriaTrabajo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Categoria { get; set; }

        public bool Activo { get; set; } = true;

        public ICollection<Trabajo> Trabajos { get; set; }
    }
}
