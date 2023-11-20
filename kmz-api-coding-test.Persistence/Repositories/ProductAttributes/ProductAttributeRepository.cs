﻿using kmz_api_coding_test.Core.Entities;
using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence.Repositories 
{
    public class ProductAttributeRepository : Repository<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(ECommerceTestDbContext context) : base (context)
        {
        }
    }
}
