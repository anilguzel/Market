using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Business.Abstract;
using Market.Core.Entities.Concrete;
using Market.DataAccess.Abstract;

namespace Market.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public bool Delete(Product product)
        {
            return _productDal.Delete(product);
        }

        public Product Get(int id)
        {
            return _productDal.Get(x => x.ProductId == id);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList();
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }
    }
}
