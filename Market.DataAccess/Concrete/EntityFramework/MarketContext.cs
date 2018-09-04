using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Concrete;
using Market.DataAccess.Concrete.EntityFramework.Mapping;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class MarketContext:DbContext
    {
        public MarketContext():base("MarketContext")
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());

            modelBuilder.Entity<Product>()
                .HasRequired<Category>(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}
