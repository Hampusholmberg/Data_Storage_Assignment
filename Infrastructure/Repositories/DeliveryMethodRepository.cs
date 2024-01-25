using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class DeliveryMethodRepository : BaseRepository<DeliveryMethodEntity, OrderDbContext>
{
    public DeliveryMethodRepository(OrderDbContext context) : base(context)
    {
    }
}
