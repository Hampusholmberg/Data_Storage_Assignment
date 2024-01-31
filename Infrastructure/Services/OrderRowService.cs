using Infrastructure.Entities;
using Infrastructure.Repositories;
using System.Diagnostics;

namespace Infrastructure.Services;

public class OrderRowService
{

    private readonly OrderRowRepository _orderRowRepository;

    public OrderRowService(OrderRowRepository orderRowRepository)
    {
        _orderRowRepository = orderRowRepository;
    }

    public OrderRowEntity CreateOrderRow(OrderRowEntity orderRow)
    {
        try
        {
            var result = _orderRowRepository.Create(orderRow);
            return result;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}