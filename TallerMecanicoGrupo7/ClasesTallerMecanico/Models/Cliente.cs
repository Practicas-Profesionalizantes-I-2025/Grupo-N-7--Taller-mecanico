using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClasesTallerMecanico.Models
{
    [Table("Cliente")]
    public class Cliente : Persona
    {
        [Required]
        [StringLength(15, MinimumLength = 11)]
        public string CuilCuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string CondFiscal { get; set; }

        public ICollection<Maquina> Maquinas { get; set; }
        public ICollection<Turno> Turnos { get; set; }
        public ICollection<FacturaVenta> FacturasVenta { get; set; }

    }
}
