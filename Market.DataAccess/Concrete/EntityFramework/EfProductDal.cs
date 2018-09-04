using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;
using Market.Core.Repository.EntityFramework;
using Market.DataAccess.Abstract;

namespace Market.DataAccess.Concrete.EntityFramework
{ 
    public class EfProductDal:EfRepository<Product, MarketContext>, IProductDal
    {
    }
}
