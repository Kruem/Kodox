using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(x => x.ProductId);
            entityTypeBuilder.Property(x => x.Name).IsRequired().HasMaxLength(500);

            //Product by default seed
            List<Product> products = new List<Product>();
            Random random =  new Random();

            for (int i = 1; i <=100; i++)
            {
                products.Add(new Product { 
                    ProductId = i,
                    Name = $"prodct {i}",
                    Description = $"description for product {i}",
                    Price = random.Next(100,1000),
                    
                });
            }
            entityTypeBuilder.HasData(products);
        }
    }
}
