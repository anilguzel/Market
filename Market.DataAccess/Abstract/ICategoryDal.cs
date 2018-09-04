using Market.Core.Entities.Concrete;
using Market.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
    }
}
