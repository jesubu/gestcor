using gestcor.Domain.Entidades;
using gestcor.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestcor.Domain.Repository.Repositorios
{
    public interface IGastosRepository : IGenericRepository<Gastos>
    {
        Gastos GetByNombre(string nombre);
    }
}
