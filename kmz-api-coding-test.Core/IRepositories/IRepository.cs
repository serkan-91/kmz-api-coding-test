using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kmz_api_coding_test.Core.IRepositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T>  GetWhere(Expression<Func<T , bool>> method , bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T , bool>> method , bool tracking = true);

    }
}
