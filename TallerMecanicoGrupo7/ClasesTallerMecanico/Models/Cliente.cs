using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTallerMecanico.Models
{
    [Table("Cliente")]
    public class Cliente : Persona
    {
        [Required]
        [MaxLength(15)]
        public string CuilCuit { get; set; }

        [Required]
        [MaxLength(50)]
        public string CondFiscal { get; set; }

    }
}
