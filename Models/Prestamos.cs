using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoRegistroBlazor.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaPrestamo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal Balance { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas personas { get; set; }

    }
}
