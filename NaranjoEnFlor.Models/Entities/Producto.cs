using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NaranjoEnFlor.Models.Entities
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string nombre { get; set; }

        public string Cantidad { get; set; }
    }
}
