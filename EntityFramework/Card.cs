using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Card
    {
        public int Id { get; set; }

        public int? ReaderId { get; set; }
        public virtual Reader? Reader { get; set; }

        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
