using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public Category Category { get; set; }
        public SalesUnit SalesUnit { get; set; }
        public decimal Price { get; set; }
        public int RemainStock { get; set; }
        public ICollection<InventoryProducts> InventoryProducts { get; set; }
        public ProductAttribute ProductAttributes { get; set; } // Yeni eklenen property


    }
}
