﻿using NaranjoEnFlor.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaranjoEnFlor.Business.Abstract
{
    public interface IMetodoPagoBusiness
    {
        Task<IEnumerable<MetodoPago>> ObtenerMetodosPago();
        void CrearMetodoPago(MetodoPago MetodoPago);
        Task<bool> GuardarCambios();

        Task<MetodoPago> ObtenerMetodoPagoId(int? id);

        void Editar(MetodoPago MetodoPago);

        void Eliminar(MetodoPago MetodoPago);
    }
}
