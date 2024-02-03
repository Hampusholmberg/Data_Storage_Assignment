using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class BrandRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveBrandToDatabase()
    {

        Brand brand = new Brand
        {
            BrandName = "Test",
        };

        genericTests.Create_ShouldSaveEntityToDatabase_ProductCatalogContext(brand);
    }

    [Fact]
    public void Delete_ShouldRemoveBrandFromDatabase()
    {

        Brand brand = new Brand
        {
            BrandName = "Test",
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_ProductCatalogContext(brand);
    }

    [Fact]
    public void GetAll_ShouldGetAllBrandsFromDatabase()
    {
        var testList = new List<Brand>();

        for (int i = 0; i < 10; i++)
        {
            Brand brand = new()
            {
                BrandName = $"Test{i}",
            };

            testList.Add(brand);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_ProductCatalogContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneBrandFromDatabase()
    {
        Brand brand = new Brand
        {
            BrandName = "Test",
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_ProductCatalogContext(brand);
    }

    [Fact]
    public void Update_ShouldUpdateBrandInDatabase()
    {
        Brand oldBrand = new()
        {
            BrandName = $"Test1",
        };
        Brand newBrand = new()
        {
            BrandName = $"Test2",
        };

        genericTests.Update_ShouldUpdateAnEntity_ProductCatalogContext(oldBrand, newBrand);
    }
}
