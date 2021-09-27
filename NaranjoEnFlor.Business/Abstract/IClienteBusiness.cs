using NaranjoEnFlor.Business.Dtos.Clientes;
using NaranjoEnFlor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Abstract
{
    public interface IClienteBusiness
    {
        Task<IEnumerable<ClienteDetalleGestionarDto>> ObtenerClientes();
        void CrearCliente(RegistroClienteDto registroClienteDto);
        Task<bool> GuardarCambios();

        Task<Cliente> ObtenerClienteId(int? id);

        void Editar(Cliente cliente);

        
    }
}
