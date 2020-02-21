using System;

namespace Application.Interfaces
{
    public interface ICatalog
    {    
        uint idCatalog{get;set;}
         DateTime dateCreation {get;set;}

         ICatalogItem catalogItem{get;}

         int idCatalogItem{get;set;}

         int pages{get;set;}
    }
}