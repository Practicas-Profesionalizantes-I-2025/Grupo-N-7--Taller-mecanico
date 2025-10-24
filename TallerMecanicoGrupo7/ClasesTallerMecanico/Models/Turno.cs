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
        public Cliente Cliente { get; set; } // Relacion 1 a 1 con Cliente

        [Required]
        [ForeignKey("Maquina")]
        public int IdMaquina { get; set; }
        public Maquina Maquina { get; set; } // Relacion 1 a 1 con Maquina

        [Required(ErrorMessage = "La fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [MaxLength(200)]
        public string? DomicilioTrabajo { get; set; }

        [ForeignKey("Localidad")]
        public int? IdLocalidad { get; set; }
        public Localidad? Localidad { get; set; } // Relacion 1 a 1 con Localidad

        [Required(ErrorMessage = "El estado es requerido.")]
        [MaxLength(50)]
        public string Estado { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }

        // --- Denormalización ---
        [MaxLength(100)]
        public string NombreCliente { get; set; } // Nombre del cliente para evitar joins

        [MaxLength(100)]
        public string ApellidoCliente { get; set; } // Apellido del cliente para evitar joins

        [MaxLength(10)]
        public string PatenteMaquina { get; set; } // Patente de la máquina para evitar joins

        [MaxLength(100)]
        public string? NombreLocalidad { get; set; } // Nombre de la localidad para evitar joins

        public ICollection<TrabajoPorTurno> TrabajosPorTurno { get; set; } // Relacion 1 a muchos con TrabajoPorTurno
        public FacturaVenta FacturaVenta { get; set; } // Relacion 1 a 1 con FacturaVenta
    }
}
