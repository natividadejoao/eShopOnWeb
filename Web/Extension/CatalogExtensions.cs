
using Application;
using Application.Adapters;
using Infras.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Extension
{

    public static class CatalogExtensions
    {
        /// <summary>
        /// Add catalog services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddCatalogServices(this IServiceCollection services, IConfiguration configuration) {
           /*  services.AddScoped<ICatalogViewModelService, CachedCatalogViewModelService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBasketViewModelService, BasketViewModelService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<CatalogViewModelService>();
            services.AddScoped<ICatalogItemViewModelService, CatalogItemViewModelService>(); */
            services.Configure<CatalogSettings>(configuration);
            services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
            
        }
        
    }
}