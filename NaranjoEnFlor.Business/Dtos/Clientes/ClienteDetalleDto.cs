using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Dtos.Clientes
{
    public class ClienteDetalleDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }


        public string Correo { get; set; }
        public string Estado { get; set; }


        public string Password { get; set; }
    }
}
