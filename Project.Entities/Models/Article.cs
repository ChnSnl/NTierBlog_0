using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }

        public int? AuthorID { get; set; }

        public int? CategoryID { get; set; }

        // Relational Properties

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<ArticleTag> ArticleTags { get; set; }
    }
}
