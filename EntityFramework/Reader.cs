using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Reader
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int? CardId { get; set; }
        public virtual Card? Card { get; set; }
    }
}
