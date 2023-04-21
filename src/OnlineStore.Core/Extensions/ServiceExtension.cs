using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.Interfaces;
using OnlineStore.Core.Services;

namespace OnlineStore.Core.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
