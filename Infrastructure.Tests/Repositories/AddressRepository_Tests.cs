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
}
