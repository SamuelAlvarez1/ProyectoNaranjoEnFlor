using Microsoft.EntityFrameworkCore;
using NaranjoEnFlor.Business.Abstract;
using NaranjoEnFlor.Business.Dtos.Clientes;
using NaranjoEnFlor.DAL;
using NaranjoEnFlor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Business
{
    public class ClienteBusiness:IClienteBusiness
        
    {
        private readonly AppDbContext _context;
        
        public ClienteBusiness(AppDbContext AppDbContext)
        {
            _context = AppDbContext;
        }

        public async Task<IEnumerable<ClienteDetalleGestionarDto>> ObtenerClientes()
        {
            List<ClienteDetalleGestionarDto> listaClienteDetalleGestionarDto = new();

            var clientes = await _context.clientes.ToListAsync();
            clientes.ForEach(c =>
            {
                ClienteDetalleGestionarDto clienteDetalleGestionarDto = new()
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Correo = c.Correo,
                    Password = c.Password,
                    Estado = ObtenerEstado(c.Estado),
                    
                };
                listaClienteDetalleGestionarDto.Add(clienteDetalleGestionarDto);
            });
            return listaClienteDetalleGestionarDto;
        }
        private string ObtenerEstado(bool estado)
        {
            if (estado)
                return "Activo";
            else
                return "Deshabilitado";
        }
        
        public void CrearCliente(RegistroClienteDto RegistroClienteDto)
        {
            if (RegistroClienteDto == null)
                throw new ArgumentNullException(nameof(RegistroClienteDto));
            RegistroClienteDto.Estado = true;

            Cliente cliente = new()
            {
                Id = RegistroClienteDto.Id,
                Nombre = RegistroClienteDto.Nombre,
                Correo = RegistroClienteDto.Correo,
                Password = RegistroClienteDto.Password,
                Estado = RegistroClienteDto.Estado,

            };

            _context.Add(cliente);
        }

        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Cliente> ObtenerClienteId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await _context.clientes.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Editar(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));
            _context.Update(cliente);
        }

        

    }
}
