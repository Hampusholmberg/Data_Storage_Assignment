using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class ProductService
{
    private readonly ProductRepository _productRepository;
    private readonly CategoryRepository _categoryRepository;
    private readonly SubCategoryRepository _subCategoryRepository;
    private readonly BrandRepository _brandRepository;

    public ProductService(ProductRepository productRepository, CategoryRepository categoryRepository, SubCategoryRepository subCategoryRepository, BrandRepository brandRepository)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _subCategoryRepository = subCategoryRepository;
        _brandRepository = brandRepository;
    }






}