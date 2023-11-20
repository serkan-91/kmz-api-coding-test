using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.Entities
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public string PropertyName { get; set; }
    }
}
