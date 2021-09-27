using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NaranjoEnFlor.Models.Entities
{
    public class Factura
    {
        [Key]
        public int codigo { get; set; }

        public DateTime fecha { get; set; }

        public int total { get; set; }
        public bool Estado{ get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual MetodoPago MetodoPago { get; set; }

        public virtual List<Producto> Productos { get; set; }
    }
}
