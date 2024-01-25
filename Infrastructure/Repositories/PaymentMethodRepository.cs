using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class PaymentMethodRepository : BaseRepository<PaymentMethodEntity, OrderDbContext>
{
    public PaymentMethodRepository(OrderDbContext context) : base(context)
    {
    }
}
