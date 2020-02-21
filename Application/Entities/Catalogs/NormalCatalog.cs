using System;
using System.Collections.Generic;
using Application.Interfaces;

namespace Application.Entities.Catalogs
{
    public class NormalCatalog : ICatalog
    {
        public NormalCatalog(DateTime dateCreation, ICatalogItem catalogItem,int pages)
        {   idCatalog = ++Seed;
            this.dateCreation = dateCreation;
            this.catalogItem = catalogItem;
            this.pages =pages;
        }

        private NormalCatalog(){
            
        }
        
        public int idCatalogItem{get;set;}
        public DateTime dateCreation { get ; set ; }

        public int pages{get;set;}
        public ICatalogItem catalogItem {get;}
        public uint idCatalog { get ; set ; }
        public static uint Seed = 0;
    }
}