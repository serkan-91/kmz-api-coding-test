using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.Entities
{
    public class InventoryProducts
    {
        public int InventoryProductsId { get; set; }
        public string InventorySKU { get; set; }
        public int SaleUnitAmount { get; set; }
        public int Quantity { get; set; }
        public int UnitPerQuantity { get; set; }

    }
}
