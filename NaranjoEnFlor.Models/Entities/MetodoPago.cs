using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NaranjoEnFlor.Models.Entities
{
    public class MetodoPago
    {
        [Key]
        public int IdMetodoPago { get; set; }
        public string nombre { get; set; }
    }
}
