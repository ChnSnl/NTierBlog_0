using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ArticleTagConfiguration : BaseConfiguration<ArticleTag>
    {
        public ArticleTagConfiguration()
        {
            ToTable("MakaleEtiketleri");
            Ignore(x => x.ID);
            HasKey(x => new
            {
                x.ArticleID,
                x.TagID
            });
        }
    }
}
