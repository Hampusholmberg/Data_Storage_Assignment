using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class DeliveryMethodRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveDeliveryMethodToDatabase()
    {
        DeliveryMethodEntity deliveryMethod = new()
        {
            DeliveryMethodName = "Test"
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(deliveryMethod);
    }

    [Fact]
    public void Delete_ShouldRemoveDeliveryMethodFromDatabase()
    {
        DeliveryMethodEntity deliveryMethod = new()
        {
            DeliveryMethodName = "Test"
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_OrderDbContext(deliveryMethod);
    }

    [Fact]
    public void GetAll_ShouldGetAllDeliveryMethodsFromDatabase()
    {
        var testList = new List<DeliveryMethodEntity>();

        for (int i = 0; i < 10; i++)
        {
            DeliveryMethodEntity deliveryMethod = new DeliveryMethodEntity
            {
                DeliveryMethodName= $"Test{i}",
            };

            testList.Add(deliveryMethod);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneDeliveryMethodFromDatabase()
    {
        DeliveryMethodEntity deliveryMethod = new()
        {
            DeliveryMethodName = "Test"
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext(deliveryMethod);
    }
}
