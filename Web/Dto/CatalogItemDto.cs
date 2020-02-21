using Application.Entities.Catalogs;

namespace Web.Dto
{
    public class CatalogItemDto
    {   
        public CatalogItemDto(CatalogItem catalogItem){
            this.descrition = catalogItem.descrition;
            this.pictureUri = catalogItem.pictureUri;
            this.price = catalogItem.price;
            this.showPrice = catalogItem.showPrice;
            this.quantity = catalogItem.quantity;
            this.id = catalogItem.id;
        }
        public uint id{get;}
        public int quantity { get ; }
        public decimal price { get ; }
        public string descrition { get ; }

        public string pictureUri{get;}

        public bool showPrice{get;} = true;
    }
}