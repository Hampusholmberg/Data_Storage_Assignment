using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class AddressRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSaveAddressToDatabase()
    {

        AddressEntity address = new AddressEntity
        {
            StreetName = "Test",
            PostalCode = "Test",
            City = "Test",
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(address);
    }

    [Fact]
    public void Delete_ShouldRemoveAddressFromDatabase()
    {

        AddressEntity address = new AddressEntity
        {
            StreetName = "Test",
            PostalCode = "Test",
            City = "Test",
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_OrderDbContext(address);
    }

    [Fact]
    public void GetAll_ShouldGetAllAddressesFromDatabase()
    {
        var testList = new List<AddressEntity>();

        for (int i = 0; i < 10; i++)
        {
            AddressEntity address = new()
            {
                StreetName = $"Test{i}",
                PostalCode = $"Test{i}",
                City = $"Test{i}",
            };

            testList.Add(address);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOneAddressFromDatabase()
    {
        AddressEntity address = new()
        {
            StreetName = $"Test",
            PostalCode = $"Test",
            City = $"Test",
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext(address);
    }

    [Fact]
    public void Update_ShouldUpdateAddressInDatabase()
    {
        AddressEntity oldAddress = new()
        {
            StreetName = $"Test1",
            PostalCode = $"Test1",
            City = $"Test1",
        };
        AddressEntity newAddress = new()
        {
            StreetName = $"Test2",
            PostalCode = $"Test2",
            City = $"Test2",
        };

        genericTests.Update_ShouldUpdateAnEntity_OrderDbContext(oldAddress, newAddress);
    }
}
