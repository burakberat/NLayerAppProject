using NLayer.Core.Dtos.CategoryDtos;

namespace NLayer.Core.Dtos.ProductDtos
{
    public class ProductWithCategoryDto : ProductDto
    {
        public CategoryDto Category { get; set; }
    }
}
