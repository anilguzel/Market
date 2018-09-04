using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Business.Abstract;
using Market.Business.Concrete;
using Market.DataAccess.Abstract;
using Market.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Market.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();


            Bind<IProductDal>().To<EfProductDal>();
            Bind<ICategoryDal>().To<EfCategoryDal>();



            Bind<DbContext>().To<MarketContext>();
        }
    }
}