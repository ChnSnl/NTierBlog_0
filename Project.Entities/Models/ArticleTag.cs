using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models
{
    public class ArticleTag : BaseEntity
    {
        public int ArticleID { get; set; }

        public int TagID { get; set; }

        // Relational Properties

        public virtual Article Article { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
