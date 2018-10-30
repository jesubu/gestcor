using gestcor.Data.Context;
using gestcor.Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestcor.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GestcorContext _context;

        public UnitOfWork(GestcorContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
