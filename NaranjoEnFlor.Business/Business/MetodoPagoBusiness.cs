using Microsoft.EntityFrameworkCore;
using NaranjoEnFlor.Business.Abstract;
using NaranjoEnFlor.DAL;
using NaranjoEnFlor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Business
{
    public class MetodoPagoBusiness:IMetodoPagoBusiness
    {
        private readonly AppDbContext _context;

        public MetodoPagoBusiness(AppDbContext AppDbContext)
        {
            _context = AppDbContext;
        }

        public async Task<IEnumerable<MetodoPago>> ObtenerMetodosPago()
        {
            return await _context.metodosPago.ToListAsync();

        }

        public void CrearMetodoPago(MetodoPago MetodoPago)
        {
            if (MetodoPago == null)
                throw new ArgumentNullException(nameof(MetodoPago));
            MetodoPago.Estado = true;
            _context.Add(MetodoPago);
        }

        public async Task<bool> GuardarCambios()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<MetodoPago> ObtenerMetodoPagoId(int? id)
        {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            return await _context.metodosPago.FirstOrDefaultAsync(m => m.IdMetodoPago == id);
        }

        public void Editar(MetodoPago metodoPago)
        {
            if (metodoPago == null)
                throw new ArgumentNullException(nameof(metodoPago));
            _context.Update(metodoPago);
        }

        public void Eliminar(MetodoPago metodoPago)
        {
            if (metodoPago == null)
                throw new ArgumentNullException(nameof(metodoPago));
            _context.Remove(metodoPago);
        }
    }
}
