using kmz_api_coding_test.Core.Entities;
using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence.Repositories.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceTestDbContext context) : base (context)
        {
        }
    }
}
