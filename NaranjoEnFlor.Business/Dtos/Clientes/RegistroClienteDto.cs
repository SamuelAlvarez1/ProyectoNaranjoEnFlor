using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Dtos.Clientes
{
    public class RegistroClienteDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe ser minimo de {2} y maximo {1} caracteres", MinimumLength = 10)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(30, ErrorMessage = "El {0} debe ser minimo de {2} y maximo {1} caracteres", MinimumLength = 5)]
        [EmailAddress(ErrorMessage = "El correo es invalido")]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La contraseña es requerido")]
        [StringLength(20, ErrorMessage = "El {0} debe ser minimo de {2} y maximo {1} caracteres", MinimumLength = 8)]
        [Display(Name = "contraseña")]
        public string Password { get; set; }
    }
}

