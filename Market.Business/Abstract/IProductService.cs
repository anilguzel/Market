using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;

namespace Market.Business.Abstract
{
    public interface IProductService
    {
        Product Get(int id);
        List<Product> GetList();
        Product Add(Product product);
        Product Update(Product product);
        bool Delete(Product product);
    }
}
