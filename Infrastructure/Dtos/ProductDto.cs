using Infrastructure.Entities;

namespace Infrastructure.Dtos;

public class ProductDto
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public string CategoryName { get; set; } = null!;
    public int CategoryId { get; set; }
    public string SubCategoryName { get; set; } = null!;
    public int SubCategoryId { get; set; }
    public string BrandName { get; set; } = null!;
    public int BrandId { get; set; }

    public static implicit operator ProductDto((Product product, Category category, SubCategory subCategory, Brand brand) source)
    {
        return new ProductDto
        {
            Title = source.product.Title,
            Description = source.product.Description,
            Price = source.product.Price,

            CategoryName = source.category.CategoryName,
            CategoryId = source.category.Id,

            SubCategoryName = source.subCategory.SubCategoryName,
            SubCategoryId = source.subCategory.Id,

            BrandName = source.brand.BrandName,
            BrandId = source.brand.Id,
        };
    }
}
