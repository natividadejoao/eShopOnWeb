
using Application.Entities.Baskets;
using Application.Entities.Catalogs;
using Application.Entities.Orders;
using Application.Entities.Whilists;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



namespace Infras.Data
{
    public class EcommerceCommandContext : DbContext
    {   
        public DbSet<Basket> baskets {get;set;}

     
        
        public DbSet<ProBasket> proBaskets{get;set;}
        public DbSet<CatalogItem> catalogItems{get;set;}
        public DbSet<NormalCatalog> normalCatalog{get;set;}

        public DbSet<SpecialCatalog> specialCatalog{get;set;}
        
     //   public DbSet<WhilistCatalog> whilistCatalogs{get;set;}
      //  public DbSet<WhilistBasket> whilistBasket{get;set;}

        public DbSet<Order> orders{get;set;}

       
        public EcommerceCommandContext(DbContextOptionsBuilder<EcommerceCommandContext> options) : base()
        {
        }

       protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}