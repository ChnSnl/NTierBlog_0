using Project.BLL.DesignPatterns.GenericRepository.EFBaseRepository;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRepository
{
    public class AuthorRepository : BaseRepository<Author>
    {
        /// <summary>
        /// Bu metot Author'i eklerken beraberinde o Author'a ait özel iki makale daha ekler...
        /// </summary>
        public void SpecialAdd()
        {

            

           
            //_db.Authors diyerek sadece authora ait işlemleri burada gerçekleştirebilirsiniz.

        }
    }
}
