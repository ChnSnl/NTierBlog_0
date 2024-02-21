using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ArticleConfiguration : BaseConfiguration<Article>
    {
        public ArticleConfiguration()
        {
            ToTable("Makaleler");
        }
    }
}
