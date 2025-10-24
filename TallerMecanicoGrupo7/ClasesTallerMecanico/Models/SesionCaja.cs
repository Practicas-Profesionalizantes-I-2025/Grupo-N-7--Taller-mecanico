using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class SesionCaja
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        public ICollection<FacturaCompra> FacturasCompra { get; set; }
        public ICollection<FacturaVenta> FacturasVenta { get; set; }
    }

}
