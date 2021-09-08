using Microsoft.EntityFrameworkCore;
using NaranjoEnFlor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Mesa> mesas { get; set; }
        public DbSet<MetodoPago> metodosPago { get; set; }
        public DbSet<Producto> productos { get; set; }
    }
}
