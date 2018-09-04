using Market.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Market.Core.Entities.Concrete;

namespace Market.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetList();
        }
        [HttpGet]
        public Product Get(int id)
        {
            return _productService.Get(id);
        }

        [HttpPost]
        public Product Add([FromBody] Product product)
        {
            return _productService.Add(product);
        }

        [HttpPut]
        public Product Update([FromBody] Product product)
        {
            return _productService.Update(product);
        }

        [HttpDelete]
        public bool Delete(int id)
        {   
            return _productService.Delete(_productService.Get(id));
        }

    }
}
