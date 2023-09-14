using EF_UnitOfWork.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_UnitOfWork.Repositories
{
    public class AuthorRepository : IRepository<Author>
    {
        private readonly DbContext _context;

        public AuthorRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(Author author)
        {
            _context.Set<Author>().Add(author);
        }

        public Author GetById(int id)
        {
            return _context.Set<Author>().Find(id);
        }

        // Implement other CRUD methods for Author
    }
}