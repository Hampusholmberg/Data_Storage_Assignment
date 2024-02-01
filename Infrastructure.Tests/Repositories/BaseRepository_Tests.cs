using Infrastructure.Contexts;
using Infrastructure.Entities;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Tests.Repositories;

public class BaseRepository_Tests
{
    private readonly OrderDbContext _orderDbContext = new(new DbContextOptionsBuilder<OrderDbContext>()
        .UseInMemoryDatabase($"{Guid.NewGuid()}")
        .Options);

    private readonly ProductCatalogContext _productContext = new(new DbContextOptionsBuilder<ProductCatalogContext>()
        .UseInMemoryDatabase($"{Guid.NewGuid()}")
        .Options);

    /// <summary>
    /// Generic testing of the "create"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="entity"></param>
    public void Create_ShouldSaveEntityToDatabase_OrderDbContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, OrderDbContext>(_orderDbContext);

        // Act
        var result = repository.Create(entity);
        var primaryKeyProperty = typeof(TEntity).GetProperties()
        .FirstOrDefault(x => x.GetCustomAttributes(typeof(KeyAttribute), false).Any())
        ?.GetValue(entity);

        // Assert
        using (OrderDbContext context = _orderDbContext)
        {
            Assert.Equal(entity, _orderDbContext.Set<TEntity>().Find(primaryKeyProperty));
        }
    }

    /// <summary>
    /// Generic testing of the "delete"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="entity"></param>
    public void Delete_ShouldRemoveEntityFromDatabase_OrderDbContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, OrderDbContext>(_orderDbContext);
        var addedEntity = repository.Create(entity);
        

        // Act

        var primaryKeyProperty = typeof(TEntity).GetProperties().FirstOrDefault(x => x.GetCustomAttributes(typeof(KeyAttribute), false).Any())?.GetValue(entity);
        var result = repository.Delete(entity);


        // Assert
        using (OrderDbContext context = _orderDbContext)
        {
            Assert.True(result);
            Assert.NotEqual(addedEntity, _orderDbContext.Set<TEntity>().Find(primaryKeyProperty));
        }
    }

}