using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Tests.Repositories;

public class ProductRepository_Tests
{
    // Seperate In Memory Database for the non-generic test of the "GetOne" product method
    private readonly ProductCatalogContext _context = new(new DbContextOptionsBuilder<ProductCatalogContext>()
        .UseInMemoryDatabase($"{Guid.NewGuid()}")
        .Options);

    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveProductToDatabase()
    {
        Product product = new Product
        {
            Title = "Test",
            Description = "Test",
            Price = 1,

            Brand = new Brand()
            {
                Id = 1,
                BrandName = "Test"
            },

            Category = new Category()
            {
                Id = 1,
                CategoryName = "Test"
            },

            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Test",
                CategoryId = 1
            },
        };

        genericTests.Create_ShouldSaveEntityToDatabase_ProductCatalogContext(product);
    }

    [Fact]
    public void Delete_ShouldRemoveProductFromDatabase()
    {
        Product product = new Product
        {
            Title = "Test",
            Description = "Test",
            Price = 1,

            Brand = new Brand()
            {
                Id = 1,
                BrandName = "Test"
            },

            Category = new Category()
            {
                Id = 1,
                CategoryName = "Test"
            },

            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Test",
                CategoryId = 1
            },
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_ProductCatalogContext(product);
    }

    [Fact]
    public void GetAll_ShouldGetAllProductsFromDatabase()
    {
        var testList = new List<Product>();

        for (int i = 0; i < 10; i++)
        {
            Product product = new Product
            {
                Title = $"Test{i}",
                Description = $"Test{i}",
                Price = 1,

                Brand = new Brand()
                {
                    Id = i+1,
                    BrandName = $"Test{i}",
                },

                Category = new Category()
                {
                    Id = i+1,
                    CategoryName = $"Test{i}",
                },

                SubCategory = new SubCategory()
                {
                    Id = i+1,
                    SubCategoryName = $"Test{i}",
                    CategoryId = i+1
                },
            };

            testList.Add(product);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_ProductCatalogContext(testList);
    }

    [Fact]
    public void Update_ShouldUpdateSubCategoryInDatabase()
    {

        Product oldProduct = new Product
        {
            Title = "Test1",
            Description = "Test1",
            Price = 1,

            Brand = new Brand()
            {
                Id = 1,
                BrandName = "Test"
            },

            Category = new Category()
            {
                Id = 1,
                CategoryName = "Test"
            },

            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Test",
                CategoryId = 1
            },
        };

        Product newProduct = new Product
        {
            Title = "Test2",
            Description = "Test2",
            Price = 2,

            Brand = new Brand()
            {
                Id = 1,
                BrandName = "Test"
            },

            Category = new Category()
            {
                Id = 1,
                CategoryName = "Test"
            },

            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Test",
                CategoryId = 1
            },
        };

        genericTests.Update_ShouldUpdateAnEntity_ProductCatalogContext(oldProduct, newProduct);
    }


    // NON GENERIC TESTS
    [Fact]
    public void GetOne_ShouldGetOneProductFromDatabase_NonGeneric()
    {

        // Arrange
        Product product = new Product
        {
            Title = "Test",
            Description = "Test",
            Price = 1,

            Brand = new Brand()
            {
                Id = 1,
                BrandName = "Test"
            },

            Category = new Category()
            {
                Id = 1,
                CategoryName = "Test"
            },

            SubCategory = new SubCategory()
            {
                Id = 1,
                SubCategoryName = "Test",
                CategoryId = 1
            },
        };
        var repository = new BaseRepository<Product, ProductCatalogContext>(_context);

        // Act
        var addedEntity = repository.Create(product);
        var result = repository.GetOne(x => x.ArticleNumber == addedEntity.ArticleNumber);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result, addedEntity);
    }
}
