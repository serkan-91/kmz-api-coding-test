using kmz_api_coding_test.Core.Entities;
using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ECommerceTestDbContext context) : base (context)
        {
        }
    }
}
