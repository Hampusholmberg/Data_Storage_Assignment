using Infrastructure.Entities;

namespace Infrastructure.Tests.Repositories;

public class PaymentMethodRepository_Tests
{
    BaseRepository_Tests genericTests = new BaseRepository_Tests();

    [Fact]
    public void Create_ShouldSavePaymentMethodToDatabase()
    {
        PaymentMethodEntity paymentMethod = new()
        {
            PaymentMethodName = "Test",
        };

        genericTests.Create_ShouldSaveEntityToDatabase_OrderDbContext(paymentMethod);
    }

    [Fact]
    public void Delete_ShouldRemovePaymentMethodFromDatabase()
    {
        PaymentMethodEntity paymentMethod = new()
        {
            PaymentMethodName = "Test",
        };

        genericTests.Delete_ShouldRemoveEntityFromDatabase_OrderDbContext(paymentMethod);
    }
}
