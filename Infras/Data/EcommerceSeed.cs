using System.Collections.Generic;
using Application.Entities.Catalogs;

namespace Infras.Data
{
    public class EcommerceSeed
    {
          public static IEnumerable<CatalogItem> GetPreconfiguredItems() => new List<CatalogItem>() {
                new CatalogItem() { quantity = 20, descrition = ".NET Bot Black Sweatshirt",  price = 19.5M, pictureUri = "http://catalogbaseurltobereplaced/images/products/1.png" },
                    new CatalogItem() {  quantity = 10, descrition = ".NET Black & White Mug",   price = 8.50M, pictureUri = "http://catalogbaseurltobereplaced/images/products/2.png" },
                    new CatalogItem() { showPrice  = false, quantity = 2, descrition = "Prism White T-Shirt",  price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/3.png" },
                    new CatalogItem() {   quantity = 10, descrition = ".NET Foundation Sweatshirt",  price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/4.png" },
                    new CatalogItem() {  quantity = 10, descrition = "Roslyn Red Sheet",  price = 8.5M, pictureUri = "http://catalogbaseurltobereplaced/images/products/5.png" },
                    new CatalogItem() {  showPrice =false, quantity = 2, descrition = ".NET Blue Sweatshirt",  price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/6.png" },
                    new CatalogItem() {   quantity = 100, descrition = "Roslyn Red T-Shirt",  price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/7.png" },
                    new CatalogItem() {   quantity = 40, descrition = "Kudu Purple Sweatshirt",   price = 8.5M, pictureUri = "http://catalogbaseurltobereplaced/images/products/8.png" },
                    new CatalogItem() {  quantity = 34, descrition = "Cup<T> White Mug",  price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/9.png" },
                    new CatalogItem() {  quantity = 1000, descrition = ".NET Foundation Sheet",   price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/10.png" },
                    new CatalogItem() {   quantity = 10, descrition = "Cup<T> Sheet",   price = 8.5M, pictureUri = "http://catalogbaseurltobereplaced/images/products/11.png" },
                    new CatalogItem() {  quantity = 20, descrition = "Prism White TShirt",   price = 12, pictureUri = "http://catalogbaseurltobereplaced/images/products/12.png" }
            
        };
    }
}