using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;
using Market.Core.Repository;

namespace Market.DataAccess.Abstract
{
    public interface IProductDal: IRepository<Product>
    {
    }
}
