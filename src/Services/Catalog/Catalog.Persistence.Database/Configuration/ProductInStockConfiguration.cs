using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration( EntityTypeBuilder<ProductInStock> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.ProductInStockId);
            //Product by default seed
            List<ProductInStock> products = new List<ProductInStock>();
            Random random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new ProductInStock
                {
                   
                        ProductInStockId = i,
                        ProductId = i,
                        Stock = random.Next(0, 100)
                });
            }
            entityTypeBuilder.HasData(products);
        }
    }
}
