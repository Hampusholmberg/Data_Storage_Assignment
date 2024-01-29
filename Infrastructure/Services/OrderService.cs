using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly DeliveryMethodRepository _deliveryMethodRepository;
    private readonly PaymentMethodRepository _paymentMethodRepository;
    private readonly OrderRepository _orderRepository;
    private readonly OrderRowRepository _orderRowRepository;

    public OrderService(DeliveryMethodRepository deliveryMethodRepository, PaymentMethodRepository paymentMethodRepository, OrderRepository orderRepository, OrderRowRepository orderRowRepository)
    {
        _deliveryMethodRepository = deliveryMethodRepository;
        _paymentMethodRepository = paymentMethodRepository;
        _orderRepository = orderRepository;
        _orderRowRepository = orderRowRepository;
    }


    // Orders -- MUST IMPLEMENT TRY CATCH
    public OrderEntity CreateOrder(OrderEntity order)
    {
        order = _orderRepository.Create(order);
        return order;
    }
    public bool DeleteOrder(OrderEntity order)
    {
        try
        {
            _orderRepository.Delete(order);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
    public IEnumerable<OrderEntity> GetAllOrders()
    {
        var orders = _orderRepository.GetAll()!;
        return orders;
    }
    public OrderEntity GetOrder(int id)
    {
        var order = _orderRepository.GetOne(x => x.Id == id)!;
        return order;
    }
    public bool CreateOrderRow(OrderRowEntity orderRow)
    {
        _orderRowRepository.Create(orderRow);
        return true;
    }



    // Delivery Methods
    public IEnumerable<DeliveryMethodEntity> GetAllDeliveryMethods()
    {
        try
        {
            var deliveryMethods = _deliveryMethodRepository.GetAll();
            return deliveryMethods;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
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
    public IEnumerable<PaymentMethodEntity> GetAllPaymentMethods()
    {
        try
        {
            var paymentMethods = _paymentMethodRepository.GetAll();
            return paymentMethods;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
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
