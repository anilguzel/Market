using Market.Core.Entities.Concrete;
using Market.Core.Repository.EntityFramework;
using Market.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfRepository<Category, MarketContext>, ICategoryDal
    {
    }
}
