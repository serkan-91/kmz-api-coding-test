using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.Entities
{
    public class Inventory
    {
        public string SKU { get; set; }
        public string FriendlyName { get; set; }
        public int UnitQuantity { get; set; }
        public int UnitPerQuantity { get; set; }
        public SalesUnit SalesUnit { get; set; }
        public List<InventoryProducts> InventoryProducts { get; set; }
    }
}
