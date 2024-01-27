using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly DeliveryMethodRepository _deliveryMethodRepository;
    private readonly PaymentMethodRepository _paymentMethodRepository;

    public OrderService(DeliveryMethodRepository deliveryMethodRepository, PaymentMethodRepository paymentMethodRepository)
    {
        _deliveryMethodRepository = deliveryMethodRepository;
        _paymentMethodRepository = paymentMethodRepository;
    }


    // Delivery Methods
    public bool CreateDeliveryMethod(DeliveryMethodEntity deliveryMethod)
    {
        try
        {
            _deliveryMethodRepository.Create(deliveryMethod);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
    public bool DeleteDeliveryMethod(DeliveryMethodEntity deliveryMethod)
    {
        try
        {
            _deliveryMethodRepository.Delete(deliveryMethod);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }



    // Payment Methods
    public bool CreatePaymentMethod(PaymentMethodEntity paymentMethod)
    {
        try
        {
            _paymentMethodRepository.Create(paymentMethod);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
    public bool DeletePaymentMethod(PaymentMethodEntity paymentMethod)
    {
        try
        {
            _paymentMethodRepository.Delete(paymentMethod);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}
