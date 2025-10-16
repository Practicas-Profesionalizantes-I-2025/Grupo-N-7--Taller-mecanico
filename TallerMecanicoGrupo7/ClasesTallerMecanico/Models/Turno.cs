using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string? DomicilioTrabajo { get; set; }

        [ForeignKey("Localidad")]
        public int? IdLocalidad { get; set; }
        public Localidad? Localidad { get; set; }

        [Required]
        public string Estado { get; set; }

        public string? Descripcion { get; set; }

        // --- Denormalización ---
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string PatenteMaquina { get; set; }
        public string? NombreLocalidad { get; set; }

        // Colecciones de tareas y facturación
        public ICollection<TrabajoPorTurno> TrabajosPorTurno { get; set; }
        public FacturaVenta FacturaVenta { get; set; }
    }
}
