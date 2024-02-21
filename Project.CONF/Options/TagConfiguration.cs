using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class TagConfiguration : BaseConfiguration<Tag>
    {
        public TagConfiguration()
        {
            ToTable("Etiketler");
        }
    }
}
