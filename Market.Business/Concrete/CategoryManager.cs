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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        public bool Delete(Category category)
        {
            return _categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetList();
        }

        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }
    }
}
