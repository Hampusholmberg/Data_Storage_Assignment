using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class CategoryRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveCategoryToDatabase()
    {
        Category category = new Category
        {
            CategoryName = "Test",
        };

        genericTests.Create_ShouldSaveEntityToDatabase_ProductCatalogContext(category);
    }

    [Fact]
    public void Delete_ShouldRemoveCategoryFromDatabase()
    {
        Category category = new Category
        {
            CategoryName = "Test",
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_ProductCatalogContext(category);
    }

    [Fact]
    public void GetAll_ShouldGetAllCategoriesFromDatabase()
    {
        var testList = new List<Category>();

        for (int i = 0; i < 10; i++)
        {
            Category category = new Category
            {
                CategoryName = $"Test{i}",
            };

            testList.Add(category);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_ProductCatalogContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneCategoryFromDatabase()
    {
        Category brand = new Category
        {
            CategoryName = "Test",
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_ProductCatalogContext(brand);
    }

    [Fact]
    public void Update_ShouldUpdateCategoryInDatabase()
    {
        Category oldCategory = new()
        {
            CategoryName = $"Test1",
        };
        Category newCategory = new()
        {
            CategoryName = $"Test2",
        };

        genericTests.Update_ShouldUpdateAnEntity_ProductCatalogContext(oldCategory, newCategory);
    }
}
