using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class OrderRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveOrderToDatabase()
    {
        OrderEntity order = new()
        {
            Customer = new CustomerEntity
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test",
                Address = new AddressEntity
                {
                    StreetName = "Test",
                    City = "Test",
                    PostalCode = "Test",
                }
            },

            PaymentMethod = new PaymentMethodEntity
            {
                PaymentMethodName = "Test",
            },

            DeliveryMethod = new DeliveryMethodEntity
            {
                DeliveryMethodName = "Test",
            }
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(order);
    }

    [Fact]
    public void Delete_ShouldRemoveOrderFromDatabase()
    {
        OrderEntity order = new()
        {
            Customer = new CustomerEntity
            {
                FirstName = "Test",
                LastName = "Test",
                Email = "Test",
                Address = new AddressEntity
                {
                    StreetName = "Test",
                    City = "Test",
                    PostalCode = "Test",
                }
            },

            PaymentMethod = new PaymentMethodEntity
            {
                PaymentMethodName = "Test",
            },

            DeliveryMethod = new DeliveryMethodEntity
            {
                DeliveryMethodName = "Test",
            }
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_OrderDbContext(order);
    }
}
