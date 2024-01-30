using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class CategoryRepository : BaseRepository<Category, ProductCatalogContext>
{
    public CategoryRepository(ProductCatalogContext context) : base(context)
    {
    }
}
