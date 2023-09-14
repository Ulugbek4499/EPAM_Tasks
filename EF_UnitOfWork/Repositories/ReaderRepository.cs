using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_UnitOfWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_UnitOfWork.Repositories
{
    public class ReaderRepository : IRepository<Reader>
    {
        private readonly DbContext _context;

        public ReaderRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(Reader reader)
        {
            _context.Set<Reader>().Add(reader);
        }

        public Reader GetById(int id)
        {
            return _context.Set<Reader>().Find(id);
        }

        public void Update(Reader reader)
        {
            _context.Entry(reader).State = EntityState.Modified;
        }

        public void Delete(Reader reader)
        {
            _context.Set<Reader>().Remove(reader);
        }

        public IEnumerable<Reader> GetAll()
        {
            return _context.Set<Reader>().ToList();
        }
    }


}
