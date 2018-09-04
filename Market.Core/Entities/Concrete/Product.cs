using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Core.Entities.Abstract;

namespace Market.Core.Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitInStock { get; set; }
        public int Price { get; set; }
        public int PriceVat { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
