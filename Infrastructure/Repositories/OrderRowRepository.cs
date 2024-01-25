using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class OrderRowRepository : BaseRepository<OrderRowEntity, OrderDbContext>
{
    public OrderRowRepository(OrderDbContext context) : base(context)
    {
    }
}
