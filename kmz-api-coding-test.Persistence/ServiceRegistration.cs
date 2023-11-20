using kmz_api_coding_test.Core.IRepositories;
using kmz_api_coding_test.Persistence.Contexts;
using kmz_api_coding_test.Persistence.Repositories;
using kmz_api_coding_test.Persistence.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 

namespace kmz_api_coding_test.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<ECommerceTestDbContext> (options => options.UseSqlServer (Configurations.ConnectionString));
            services.AddScoped<IProductRepository , ProductRepository> ();
            services.AddScoped<ISalesUnitRepository , SalesUnitRepository> ();
            services.AddScoped<IProductAttributeRepository , ProductAttributeRepository> ();
            services.AddScoped<ICategoryRepository , CategoryRepository> ();
        }
    }
}
