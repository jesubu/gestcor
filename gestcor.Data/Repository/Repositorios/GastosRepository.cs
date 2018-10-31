using gestcor.Data.Context;
using gestcor.Data.Repository.Base;
using gestcor.Domain.Entidades;
using gestcor.Domain.Repository.Repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gestcor.Data.Repository.Repositorios
{
    public class GastosRepository : GenericRepository<Gastos>, IGastosRepository
    {
        public GastosRepository(GestcorContext context)
            : base(context)
        {

        }

        public Gastos GetByNombre(string nombre)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Gasto == nombre);
        }
    }
}
