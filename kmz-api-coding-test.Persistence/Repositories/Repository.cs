﻿using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ECommerceTestDbContext _context;

        public Repository(ECommerceTestDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T> ();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if ( !tracking )
                query = query.AsNoTracking ();

            return query;
        }

        

        public async Task<T> GetSingleAsync(Expression<Func<T , bool>> method , bool tracking = true)
        {
            var query = Table.AsQueryable();
            if ( !tracking )
                query = Table.AsNoTracking ();
            return await query.FirstOrDefaultAsync (method);
        }

        public  IQueryable<T>  GetWhere(Expression<Func<T , bool>> method , bool tracking = true)
        {
            var query =  Table.Where(method);
            if ( !tracking )
                query =  query.AsNoTracking ();

            return query;
        }

       
    }
}
