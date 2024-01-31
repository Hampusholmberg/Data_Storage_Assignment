using Infrastructure.Dtos;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Numerics;

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

    // PRODUCTS
    public bool CreateProduct(Product product)
    {
        if (!_productRepository.Exists(
            x => x.Title == product.Title
        ))
        {
            try
            {
                _productRepository.Create(product);
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
        return false!;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        try
        {
            return _productRepository.GetAll();
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public Product GetProduct(int id)
    {
        try
        {
            var result = _productRepository.GetOne(x => x.ArticleNumber == id);
         
            if (result != null)
            {
                return result;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public bool DeleteProduct (Product product) 
    {
        try
        {
            var result = _productRepository.Delete(product);
            return result;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }


    // CATEGORIES
    public bool CreateCategory(Category category)
    {
        if (!_categoryRepository.Exists(
            x => x.CategoryName == category.CategoryName
        ))
        {
            try
            {
                _categoryRepository.Create(category);
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
        return false;
    }
    public IEnumerable<Category> GetAllCategories()
    {
        try
        {
            return _categoryRepository.GetAll();
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public Category GetCategory(int id)
    {
        try
        {
            var result = _categoryRepository.GetOne(x => x.Id == id);

            if (result != null)
            {
                return result;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public bool DeleteCategory(Category category)
    {
        try
        {
            var result = _categoryRepository.Delete(category);
            return result;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }


    // SUBCATEGORIES
    public bool CreateSubCategory(SubCategory subCategory)
    {
        if (!_subCategoryRepository.Exists(
            x => x.SubCategoryName == subCategory.SubCategoryName
        ))
        {
            try
            {
                var result = _subCategoryRepository.Create(subCategory);
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
        return false;
    }
    public IEnumerable<SubCategory> GetAllSubCategories()
    {
        try
        {
            return _subCategoryRepository.GetAll();
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }

    /// <summary>
    /// This overload of the GetAllSubcategories will return all the sub categories that has the passed Category ID.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public IEnumerable<SubCategory> GetAllSubCategories(int categoryId)
    {
        try
        {
            var subCategories = _subCategoryRepository.GetAll();
            List<SubCategory> updatedList = new List<SubCategory>();

            foreach (var subCategory in subCategories) 
            {
                if (subCategory.CategoryId == categoryId)
                    updatedList.Add(subCategory); 
            }
            return updatedList;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public SubCategory GetSubCategory(int id)
    {
        try
        {
            var result = _subCategoryRepository.GetOne(x => x.Id == id);

            if (result != null)
            {
                return result;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public bool DeleteSubCategory(SubCategory subCategory)
    {
        try
        {
            var result = _subCategoryRepository.Delete(subCategory);
            return result;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }


    // BRANDS
    public bool CreateBrand(Brand brand)
    {
        if (!_brandRepository.Exists(
            x => x.BrandName == brand.BrandName
        ))
        {
            try
            {
                _brandRepository.Create(brand);
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
        return false;
    }
    public IEnumerable<Brand> GetAllBrands()
    {
        try
        {
            return _brandRepository.GetAll();
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public Brand GetBrand(int id)
    {
        try
        {
            var result = _brandRepository.GetOne(x => x.Id == id);

            if (result != null)
            {
                return result;
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public bool DeleteBrand(Brand brand)
    {
        try
        {
            var result = _brandRepository.Delete(brand);
            return result;

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}