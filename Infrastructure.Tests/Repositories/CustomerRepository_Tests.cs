using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class CustomerRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveCustomerToDatabase()
    {
        CustomerEntity customer = new CustomerEntity
        {
            FirstName = "Test",
            LastName = "Test",
            Email = "Test",
            AddressId = 1,
            Address = new AddressEntity
            {
                StreetName = "Test",
                PostalCode = "Test",
                City = "Test",
            }
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(customer);
    }

    [Fact]
    public void Delete_ShouldRemoveCustomerFromDatabase()
    {
        CustomerEntity customer = new CustomerEntity
        {
            FirstName = "Test",
            LastName = "Test",
            Email = "Test",
            AddressId = 1,
            Address = new AddressEntity
            {
                StreetName = "Test",
                PostalCode = "Test",
                City = "Test",
            }
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_OrderDbContext(customer);
    }
}
