using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_UnitOfWork.Entities;

namespace EF_UnitOfWork
{
    public class MethodUnitOfWork
    {
        public static void UseUoW()
        {
            using (var unitOfWork = new UnitOfWork(new LibraryContext()))
            {
                unitOfWork.BeginTransaction();

                try
                {
                    var reader = new Reader { Name = "John Doe", PhoneNumber = "123-456-7890", Email = "john@example.com" };
                    var book = new Book { Name = "Sample Book" };
                    var author = new Author { Name = "Author Name" };

                    unitOfWork.Readers.Add(reader);
                    unitOfWork.Books.Add(book);
                    unitOfWork.Authors.Add(author);

                    unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    unitOfWork.Rollback();
                }
            }
        }
    }
}
