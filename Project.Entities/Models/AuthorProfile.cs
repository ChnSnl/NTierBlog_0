using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class AuthorProfile : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Relational Properties

        public virtual Author Author { get; set; }
    }
}
