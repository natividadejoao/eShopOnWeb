using System;
using Application.Interfaces;

namespace Application.Entities.Catalogs
{
    public class SpecialCatalog : ICatalog
    {
        public SpecialCatalog(DateTime dateCreation, ICatalogItem catalogItem,int pages)
        {   idCatalog = ++Seed;
            this.dateCreation = dateCreation;
            this.catalogItem = catalogItem;
            this.pages = pages;
        }

        private SpecialCatalog(){
            
        }
        public int idCatalogItem{get;set;}
        public DateTime dateCreation { get ; set ; }

        public CatalogType type{get;set;}

        public ICatalogItem catalogItem {get;}
        public uint idCatalog { get ; set ; }
        public int pages { get ; set ; }

        public static uint Seed = 0;
    }
}