using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entities;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CategoryId = 1, Name = "Rotring", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 2, CategoryId = 1, Name = "Faber Castle", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, CategoryId = 1, Name = "Tuna", Price = 50, Stock = 50, CreatedDate = DateTime.Now },
                new Product { Id = 4, CategoryId = 2, Name = "Sefiller", Price = 100, Stock = 20, CreatedDate = DateTime.Now },
                new Product { Id = 5, CategoryId = 2, Name = "Kumarbaz", Price = 100, Stock = 20, CreatedDate = DateTime.Now });
        }
    }
}
