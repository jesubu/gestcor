using System;
using System.Collections.Generic;
using System.Text;

namespace gestcor.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {


            bool Commit();
        
    }
}
