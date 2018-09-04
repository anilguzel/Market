using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;

namespace Market.Business.Abstract
{
    public interface ICategoryService
    {
        Category Get(int id);
        List<Category> GetList();
        Category Add(Category category);
        Category Update(Category category);
        bool Delete(Category category);

    }
}
