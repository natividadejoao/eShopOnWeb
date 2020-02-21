using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Catalogs
{
    public class CatalogItem : ICatalogItem
    {
        public static uint Seed = 0;
        public uint id { get ; set ; }
        public int quantity { get ; set ; }
        public decimal price { get ; set ; }
        public string descrition { get ; set ; }

        public string pictureUri{get;set;}

        public bool showPrice{get;set;} = true;

        public int idCatalog {get;}

        public CatalogItem(){
            
        }
        public CatalogItem(decimal price,int quantity){
            this.quantity = quantity;
            this.price = price;
        }

        public CatalogItem(int quantity, decimal price, string descrition, int idCatalog,string pictureUri)
        {
            id =++Seed;
            this.quantity = quantity;
            this.price = price;
            this.descrition = descrition;
            this.pictureUri = pictureUri;
            this.idCatalog = idCatalog;
        }
    }
}