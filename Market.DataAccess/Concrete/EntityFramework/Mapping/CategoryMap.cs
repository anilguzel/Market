using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;

namespace Market.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Category", @"dbo");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryName).HasColumnName("CategoryName");
            Property(x => x.IsActive).HasColumnName("IsActive");
            Property(x => x.Order).HasColumnName("Order");
        }

    }
}
