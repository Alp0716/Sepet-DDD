using Domain.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Ioc
{
    public static class Services
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>))
                .AddScoped(typeof(IUserRepository), typeof(UserRepository))
                .AddScoped(typeof(IProductRepository), typeof(ProductRepository));

        }
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
