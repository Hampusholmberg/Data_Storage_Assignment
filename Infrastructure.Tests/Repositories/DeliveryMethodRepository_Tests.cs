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
}
