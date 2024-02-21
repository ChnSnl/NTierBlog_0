using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AuthorConfiguration : BaseConfiguration<Author>
    {
        public AuthorConfiguration()
        {
            ToTable("Yazarlar");
            HasOptional(x => x.AuthorProfile).WithRequired(x => x.Author);
        }
    }
}
