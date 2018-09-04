using Market.Core.Entities.Concrete;

namespace Market.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Market.DataAccess.Concrete.EntityFramework.MarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Market.DataAccess.Concrete.EntityFramework.MarketContext context)
        {
            //context.Categories.AddOrUpdate(x => x.CategoryId,
            //    new Category() { CategoryName = "Beverages", IsActive = true },
            //    new Category() { CategoryName = "Condiments", IsActive = true },
            //    new Category() { CategoryName = "Confections", IsActive = true },
            //    new Category() { CategoryName = "Dairy Products", IsActive = true },
            //    new Category() { CategoryName = "Grains/Cereals", IsActive = true },
            //    new Category() { CategoryName = "Meat/Poultry", IsActive = true },
            //    new Category() { CategoryName = "Produce", IsActive = true });

            //context.Products.AddOrUpdate(x => x.ProductId,
            //    new Product() { ProductName = "Chai", CategoryId = 1, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Chang", CategoryId = 1, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Guaraná Fantástica", CategoryId = 1, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Aniseed Syrup", CategoryId = 2, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Teatime Chocolate Biscuits", CategoryId = 2, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Sir Rodney's Marmalade", CategoryId = 2, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Pavlova", CategoryId = 3, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Chef Anton's Cajun Seasoning", CategoryId = 3, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Gula Malacca", CategoryId = 3, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Queso Cabrales", CategoryId = 4, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Geitost", CategoryId = 4, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Gudbrandsdalsost", CategoryId = 4, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Tunnbröd", CategoryId = 5, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Filo Mix", CategoryId = 5, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Ravioli Angelo", CategoryId = 5, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Alice Mutton", CategoryId = 6, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Thüringer Rostbratwurst", CategoryId = 6, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Perth Pasties", CategoryId = 6, Price = 100, PriceVat = 18, UnitInStock = 5 },

            //    new Product() { ProductName = "Longlife Tofu", CategoryId = 7, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Rössle Sauerkraut", CategoryId = 7, Price = 100, PriceVat = 18, UnitInStock = 5 },
            //    new Product() { ProductName = "Tofu", CategoryId = 7, Price = 100, PriceVat = 18, UnitInStock = 5 });

        }
    }
}
