using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.ViewModels
{
    public class ProductDetailVM
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string UnitName { get; set; } 
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
