using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Infras.Data
{
    public class EnsureSeed
    {
         public static async Task CommandSeed( EcommerceCommandContext context, ILoggerFactory logger,int? retry = 0){
            int retryForAvailability = retry.Value; 
          try{ if(!context.catalogItems.Any()) EcommerceSeed.GetPreconfiguredItems();
           await context.SaveChangesAsync();
          } catch (Exception ex) {
                if (retryForAvailability < 10) {
                    retryForAvailability++;
                    var log = logger.CreateLogger<EnsureSeed>();
                    log.LogError(ex.Message);
                    await CommandSeed(context, logger, retryForAvailability);
                }
                throw;
            }
     
        }

        public  static async Task QuerySeed(  EcommerceQueryContext context,ILoggerFactory logger, int? retry = 0 ){
          int retryForAvailability = retry.Value;
          try{
            if(!context.catalogItems.Any()) EcommerceSeed.GetPreconfiguredItems();
            await context.SaveChangesAsync();
            
            } catch (Exception ex) {
                if (retryForAvailability < 10) {
                    retryForAvailability++;
                    var log = logger.CreateLogger<EnsureSeed>();
                    log.LogError(ex.Message);
                    await QuerySeed(context, logger, retryForAvailability);
                }
                throw;
            }
           
        }
    }
}