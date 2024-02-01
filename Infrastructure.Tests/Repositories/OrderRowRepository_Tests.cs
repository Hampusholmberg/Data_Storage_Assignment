using Castle.Core.Resource;
using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class OrderRowRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();


    // FIX THIS: entity has composite key 
    [Fact]
    public void Create_ShouldSaveOrderRowToDatabase()
    {
        OrderRowEntity orderRow = new()
        {
            Id = 1,
            OrderId = 1,
            ProductId = 1,
            Quantity = 1,
            RowPrice = 1,

            Order = new OrderEntity
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
            }
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(orderRow);
    }
}
