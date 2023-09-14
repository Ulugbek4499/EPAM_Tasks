using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_UnitOfWork.Entities;
using EF_UnitOfWork.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EF_UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly DbContext _context;
        private IDbTransaction _transaction;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public IRepository<Reader> Readers { get; }
        public IRepository<ReaderCard> ReaderCards { get; }
        public IRepository<Book> Books { get; }
        public IRepository<Author> Authors { get; }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
                _transaction?.Commit();
            }
            catch
            {
                _transaction?.Rollback();
                throw;
            }
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}
