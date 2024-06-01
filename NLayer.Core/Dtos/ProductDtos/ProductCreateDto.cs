namespace NLayer.Core.Dtos.ProductDtos
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
