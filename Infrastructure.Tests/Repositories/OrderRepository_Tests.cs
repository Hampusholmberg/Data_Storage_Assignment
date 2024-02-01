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

    [Fact]
    public void GetAll_ShouldGetAllOrdersFromDatabase()
    {
        var testList = new List<OrderEntity>();

        for (int i = 0; i < 10; i++)
        {
            OrderEntity order = new()
            {
                Customer = new CustomerEntity
                {
                    FirstName = $"Test{i}",
                    LastName = $"Test{i}",
                    Email = $"Test{i}",
                    Address = new AddressEntity
                    {
                        StreetName = $"Test{i}",
                        City = $"Test{i}",
                        PostalCode = $"Test{i}",
                    }
                },

                PaymentMethod = new PaymentMethodEntity
                {
                    PaymentMethodName = $"Test{i}",
                },

                DeliveryMethod = new DeliveryMethodEntity
                {
                    DeliveryMethodName = $"Test{i}",
                }
            };

            testList.Add(order);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneOrderFromDatabase()
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

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext(order);
    }
}
