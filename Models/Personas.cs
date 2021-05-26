using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoRegistroBlazor.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(10, ErrorMessage = "EL Teléfono debe tener minimo 10 caracteres")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MinLength(11, ErrorMessage = "Debe tener al menos 11 caracteres")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime FechaNacimiento { get; set; } = new DateTime(1990, 1, 1);

        public decimal Balance { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
