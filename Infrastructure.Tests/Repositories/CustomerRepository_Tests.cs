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

    [Fact]
    public void GetAll_ShouldGetAllCustomersFromDatabase()
    {
        var testList = new List<CustomerEntity>();

        for (int i = 0; i < 10; i++)
        {
            CustomerEntity customer = new CustomerEntity
            {
                FirstName = $"Test{i}",
                LastName = $"Test{i}",
                Email = $"Test{i}",
                AddressId = i,
                Address = new AddressEntity
                {
                    StreetName = $"Test{i}",
                    PostalCode = $"Test{i}",
                    City = $"Test{i}",
                }
            };

            testList.Add(customer);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneCustomerFromDatabase()
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

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext(customer);
    }

}
