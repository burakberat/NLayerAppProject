using NLayer.Core.Dtos;
using NLayer.Core.Dtos.ProductDtos;
using NLayer.Core.Entities;

namespace NLayer.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
