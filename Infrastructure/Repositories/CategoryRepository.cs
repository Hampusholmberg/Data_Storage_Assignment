using Infrastructure.Contexts;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class CategoryRepository : BaseRepository<CategoryEntity, ProductCatalogContext>
{
    public CategoryRepository(ProductCatalogContext context) : base(context)
    {
    }
}
