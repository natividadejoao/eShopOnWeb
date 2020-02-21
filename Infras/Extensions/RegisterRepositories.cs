using Application.Adapters;
using Application.Adapters.Repositories;
using Infras.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infras.Extensions
{
    public static class RegisterRepositories
    {
        public static void ConfigureRepos(this IServiceCollection services, IConfiguration configuration )
        {
             services.AddScoped<IAsyncCatalogItemReposiotry, CatalogItemRepo>();
              services.AddScoped<IAsyncBasketRepository, BasketRepo>();
               services.AddScoped<IAsyncProBasketRepository, ProBasketRepo>();
                services.AddScoped<IAsyncOrderRepository, OrderRepo>();
               //  services.AddScoped<IAsyncWhilistBasketRepository, WhilistBasketRepo>();
                // services.AddScoped<IAsyncWhilistCatalogRepository, WhilistCatalogRepo>();

                 

           
        }
    }
}