using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
