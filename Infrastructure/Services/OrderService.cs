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


    // Orders
    public OrderEntity CreateOrder(OrderEntity order)
    {
        try
        {
            order = _orderRepository.Create(order);
            return order;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); };
        return null!;
    }
    public bool DeleteOrder(OrderEntity order)
    {
        try
        {
            var result = _orderRepository.Delete(order);
            
            if (result)
                return true;
            else 
                return false;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
    public IEnumerable<OrderEntity> GetAllOrders()
    {
        try
        {
            var orders = _orderRepository.GetAll()!;
            return orders;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); };
        return null!;
    }
    public OrderEntity GetOrder(int id)
    {
        try
        {
            var order = _orderRepository.GetOne(x => x.Id == id)!;
            return order;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); };
        return null!;
    }
    public bool CreateOrderRow(OrderRowEntity orderRow)
    {
        try
        {
            _orderRowRepository.Create(orderRow);
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); };
        return false;
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
