using NaranjoEnFlor.Business.Abstract;
using NaranjoEnFlor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Business
{
    class ClienteBusiness:IClienteBusiness
        
    {
        private readonly AppDbContext _context;
        //contexto
        public ClienteBusiness(AppDbContext AppDbContext)
        {
            _context = AppDbContext;
        }


    }
}
