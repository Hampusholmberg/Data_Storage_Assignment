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

    [Fact]
    public void GetAll_ShouldGetAllPaymentMethodsFromDatabase()
    {
        var testList = new List<PaymentMethodEntity>();

        for (int i = 0; i < 10; i++)
        {
            PaymentMethodEntity paymentMethod = new PaymentMethodEntity
            {
                PaymentMethodName = $"Test{i}",
            };

            testList.Add(paymentMethod);
        }

        genericTests.GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext(testList);
    }

    [Fact]
    public void GetOne_ShouldGetOnePaymentMethodFromDatabase()
    {
        PaymentMethodEntity paymentMethod = new PaymentMethodEntity
        {
            PaymentMethodName = $"Test",
        };

        genericTests.GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext(paymentMethod);
    }
}
