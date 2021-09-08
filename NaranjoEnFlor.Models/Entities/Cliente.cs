using System;
using System.Collections.Generic;
using System.Text;

namespace NaranjoEnFlor.Models.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string contraseña { get; set; }
    }
}
