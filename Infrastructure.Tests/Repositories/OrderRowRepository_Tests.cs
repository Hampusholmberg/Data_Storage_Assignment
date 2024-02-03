using Castle.Core.Resource;
using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Tests.Repositories;

public class OrderRowRepository_Tests

{
    // NON GENERIC TESTS
    private readonly OrderDbContext _context = new(new DbContextOptionsBuilder<OrderDbContext>()
    .UseInMemoryDatabase($"{Guid.NewGuid()}")
    .Options);

    [Fact]
    public void Create_ShouldSaveOrderRowToDatabase()
    {
        // Arrange
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
        var repository = new BaseRepository<OrderRowEntity, OrderDbContext>(_context);

        // Act
        var result = repository.Create(orderRow);

        // Assert
        Assert.Equal(orderRow, result);
    }

    [Fact]
    public void Delete_ShouldRemoveOrderRowFromDatabase()
    {
        // Arrange
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
        var repository = new BaseRepository<OrderRowEntity, OrderDbContext>(_context);

        // Act
        repository.Create(orderRow);
        var result = repository.Delete(orderRow);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void GetAll_ShouldGetAllOrderRowsFromDatabase()
    {
        // Arrange
        var repository = new BaseRepository<OrderRowEntity, OrderDbContext>(_context);

        var testList = new List<OrderRowEntity>();

        for (int i = 0; i < 10; i++)
        {
            OrderRowEntity orderRow = new()
            {
                Id = i+1,
                OrderId = 1,
                ProductId = i+1,
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

            testList.Add(orderRow);

        }

        foreach (OrderRowEntity orderRow in testList)
        {
            repository.Create(orderRow);
        }

        // Act
        var result = repository.GetAll().ToList();

        // Arrange
        Assert.Equal(testList.Count, result.Count);
    }

    [Fact]
    public void GetOne_ShouldGetOneOrderRowFromDatabase()
    {
        // Arrange
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
        var repository = new BaseRepository<OrderRowEntity, OrderDbContext>(_context);

        // Act
        var addedOrderRow = repository.Create(orderRow);

        var result = repository.GetOne(x =>
            x.OrderId == orderRow.OrderId &&
            x.Id == orderRow.Id);

        // Assert
        Assert.Equal(addedOrderRow, result);
    }
}
