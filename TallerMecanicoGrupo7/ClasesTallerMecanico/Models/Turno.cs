using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    public class Turno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        [Required]
        [ForeignKey("Maquina")]
        public int IdMaquina { get; set; }
        public Maquina Maquina { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [MaxLength(200)]
        public string? DomicilioTrabajo { get; set; }

        [ForeignKey("Localidad")]
        public int? IdLocalidad { get; set; }
        public Localidad? Localidad { get; set; }

        [Required]
        [MaxLength(50)]
        public string Estado { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        // --- Denormalización ---
        [MaxLength(100)]
        public string NombreCliente { get; set; }
        [MaxLength(100)]
        public string ApellidoCliente { get; set; }
        [MaxLength(10)]
        public string PatenteMaquina { get; set; }
        [MaxLength(100)]
        public string? NombreLocalidad { get; set; }

        public ICollection<TrabajoPorTurno> TrabajosPorTurno { get; set; }
        public FacturaVenta FacturaVenta { get; set; }
    }
}
