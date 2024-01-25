using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class OrderRepository : BaseRepository<OrderEntity, OrderDbContext>
{
    public OrderRepository(OrderDbContext context) : base(context)
    {
    }
}
