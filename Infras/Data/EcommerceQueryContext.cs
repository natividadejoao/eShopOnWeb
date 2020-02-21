using System.Linq;
using System.Reflection;
using Application.Entities.Baskets;
using Application.Entities.Catalogs;
using Application.Entities.Orders;
using Application.Entities.Whilists;
using Microsoft.EntityFrameworkCore;

namespace Infras.Data
{
    public class EcommerceQueryContext :DbContext
    {
         public IQueryable<Basket> baskets {get;}
        
        public IQueryable<ProBasket> proBaskets{get;}
        public IQueryable<CatalogItem> catalogItems{get;}
        public IQueryable<NormalCatalog> normalCatalog{get;}

        public IQueryable<SpecialCatalog> specialCatalog{get;}
        
     //   public IQueryable<WhilistCatalog> whilistCatalogs{get;}
      //  public IQueryable<WhilistBasket> whilistBasket{get;}

        public IQueryable<Order> orders{get;}

       
        public EcommerceQueryContext(DbContextOptionsBuilder<EcommerceQueryContext> options) : base()
        {    catalogItems = base.Set<CatalogItem>();
          
         //   whilistCatalogs = base.Set<WhilistCatalog>();
          //  whilistBasket = base.Set<WhilistBasket>();
            baskets = base.Set<Basket>();
            proBaskets = base.Set<ProBasket>();
            orders = base.Set<Order>();
            specialCatalog = base.Set<SpecialCatalog>();
            normalCatalog =base.Set<NormalCatalog>();
        }

       protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}