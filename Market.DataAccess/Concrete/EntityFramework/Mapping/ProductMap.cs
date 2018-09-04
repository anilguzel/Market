using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;

namespace Market.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ProductMap:EntityTypeConfiguration<Product> 
    {
        public ProductMap()
        {
            ToTable(@"Product", @"dbo");
            HasKey(x => x.ProductId);

            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.UnitInStock).HasColumnName("UnitInStock");
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.PriceVat).HasColumnName("PriceVat");
            Property(x => x.CategoryId).HasColumnName("CategoryId");

        }
    }
}
