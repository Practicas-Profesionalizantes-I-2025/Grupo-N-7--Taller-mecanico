using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, double.MaxValue)]
        public decimal PrecioHsManoObra { get; set; }

        public bool Activo { get; set; } = true;
    }
}
