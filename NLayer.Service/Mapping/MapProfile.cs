using AutoMapper;
using NLayer.Core.Dtos.CategoryDtos;
using NLayer.Core.Dtos.ProductDtos;
using NLayer.Core.Dtos.ProductFeatureDto;
using NLayer.Core.Entities;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<ProductCreateDto, Product>();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithProductsDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>();

            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
        }
    }
}
