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

    [Fact]
    public void Update_ShouldUpdateCustomerInDatabase()
    {
        CustomerEntity oldCustomer = new()
        {
            FirstName = $"Test1",
            LastName = $"Test1",
            Email = $"Test1",
            
            Address =  new AddressEntity
            {
                Id = 1,
                StreetName = "Test1",
                PostalCode = "Test1",
                City = "Test1",
            }
        };
        CustomerEntity newCustomer = new()
        {
            FirstName = $"Test2",
            LastName = $"Test2",
            Email = $"Test2",

            Address = new AddressEntity
            {
                Id = 2,
                StreetName = "Test2",
                PostalCode = "Test2",
                City = "Test2",
            }
        };

        genericTests.Update_ShouldUpdateAnEntity_OrderDbContext(oldCustomer, newCustomer);
    }

}
