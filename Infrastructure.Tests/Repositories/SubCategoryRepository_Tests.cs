using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class SubCategoryRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveSubCategoryToDatabase()
    {
        SubCategory subCategory = new SubCategory
        {
            SubCategoryName = "Test",
        };

        genericTests.Create_ShouldSaveEntityToDatabase_ProductCatalogContext(subCategory);
    }

    [Fact]
    public void Delete_ShouldRemoveSubCategoryFromDatabase()
    {
        SubCategory subCategory = new SubCategory
        {
            SubCategoryName = "Test",
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_ProductCatalogContext(subCategory);
    }

    [Fact]
    public void GetAll_ShouldGetAllSubCategoriesFromDatabase()
    {
        var testList = new List<SubCategory>();

        for (int i = 0; i < 10; i++)
        {
            SubCategory subCategory = new SubCategory
            {
                SubCategoryName = $"Test{i}",
            };

            testList.Add(subCategory);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_ProductCatalogContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneSubCategoryFromDatabase()
    {
        SubCategory subCategory = new SubCategory
        {
            SubCategoryName = "Test",
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_ProductCatalogContext(subCategory);
    }

    [Fact]
    public void Update_ShouldUpdateSubCategoryInDatabase()
    {
        SubCategory oldSubCategory = new()
        {
            SubCategoryName = $"Test1",
        };
        SubCategory newSubCategory = new()
        {
            SubCategoryName = $"Test2",
        };

        genericTests.Update_ShouldUpdateAnEntity_ProductCatalogContext(oldSubCategory, newSubCategory);
    }
}
