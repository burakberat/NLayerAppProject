using NLayer.Core.Dtos.ProductDtos;
using NLayer.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Core.Entities;

namespace NLayer.Core.Services
{
    public interface IProductServiceWithDto : IServiceWithDto<Product, ProductDto>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(ProductUpdateDto dto);
        Task<CustomResponseDto<ProductDto>> AddAsync(ProductCreateDto dto);
    }
}
