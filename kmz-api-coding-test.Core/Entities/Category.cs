using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; } = 0;
        public ICollection<Product> Products { get; set; } // Bir kategorinin birden fazla ürünü olabilir


    }
} 
