using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Infrastructure.Repositories;
public class ProductRepository : BaseRepository<Product, ProductCatalogContext>
{
    private readonly ProductCatalogContext _context;
    public ProductRepository(ProductCatalogContext context) : base(context)
    {
        _context = context;
    }

    public override IEnumerable<Product> GetAll()
    {
        try
        {
            return _context.Products
                .Include(x => x.Category)
                .Include(x => x.SubCategory)
                .Include(x => x.Brand)
                .ToList();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }
}