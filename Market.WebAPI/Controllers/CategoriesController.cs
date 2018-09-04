using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Market.Business.Abstract;
using Market.Core.Entities.Concrete;

namespace Market.WebAPI.Controllers
{
    public class CategoriesController : ApiController
    {
        private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetList();
        }
        [HttpGet]
        public Category Get(int id)
        {
            return _categoryService.Get(id);
        }
        [HttpPost]
        public Category Add([FromBody] Category category)
        {
            return _categoryService.Add(category);
        }

        [HttpPut]
        public Category Update(Category category)
        {
            return _categoryService.Update(category);
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return _categoryService.Delete(_categoryService.Get(id));
        }
    }
}
