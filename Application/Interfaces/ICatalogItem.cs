namespace Application.Interfaces
{
    public interface ICatalogItem
    {
        uint id{get;set;}
         int quantity{get;set;}
         decimal price{get;set;}
         string descrition {get;set;}

         int idCatalog{get;}  

         string pictureUri{get;set;}
    }
}