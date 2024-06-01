using NLayer.Core.Dtos.ProductDtos;

namespace NLayer.Core.Dtos.CategoryDtos
{
    public class CategoryWithProductsDto : CategoryDto
    {
        public List<ProductDto> Products { get; set; }
    }
}
