using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure
{
    public static class InfrastructureRegisteration
    {
        public static IServiceCollection InfrastructureConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepositry<>), typeof(GenericRepositry<>));
            //services.AddScoped<IPhotoRepositry, PhotoRepositry>();
            //services.AddScoped<IProductRepositry, ProductRepositry>();
            //services.AddScoped<ICategoryRepositry, CategoryRepositry>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
