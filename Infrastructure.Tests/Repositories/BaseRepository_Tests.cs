using Infrastructure.Contexts;
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


    // -------------- ORDER DB -------------- //

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
        var primaryKeyProperty = typeof(TEntity).GetProperties().FirstOrDefault(x => x.GetCustomAttributes(typeof(KeyAttribute), false).Any())?.GetValue(entity);

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

    /// <summary>
    /// Generic testing of the "get all"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_OrderDbContext<TEntity>(List <TEntity> entities) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, OrderDbContext>(_orderDbContext);
        
        foreach (var entity in entities)
        {
            repository.Create(entity);
        }

        // Act
        var testlist = repository.GetAll();

        // Assert
        using (OrderDbContext context = _orderDbContext)
        {
            Assert.Equal(testlist.Count(), entities.Count());
        }
    }

    /// <summary>
    /// Generic testing of the "get one"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void GetOne_ShouldReturnAnEntityBasedOnExpression_OrderDbContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, OrderDbContext>(_orderDbContext);

        // Act
        var addedEntity = repository.Create(entity);
        var primaryKeyValue = _orderDbContext.Entry(addedEntity).Property("Id").CurrentValue;
        var result = repository.GetOne(x => EF.Property<int>(x, "Id") == (int)primaryKeyValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result, addedEntity);
    }

    /// <summary>
    /// Generic testing of the "get one"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void Update_ShouldUpdateAnEntity_OrderDbContext<TEntity>(TEntity oldEntity, TEntity newEntity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, OrderDbContext>(_orderDbContext);

        // Act
        oldEntity = repository.Create(oldEntity);
        var updatedEntity = repository.Update(newEntity);

        // Assert
        Assert.NotEqual(oldEntity, updatedEntity);
    }



    // ------------- PRODUCT DB ------------- //

    /// <summary>
    /// Generic testing of the "create"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="entity"></param>
    public void Create_ShouldSaveEntityToDatabase_ProductCatalogContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, ProductCatalogContext>(_productContext);

        // Act
        var result = repository.Create(entity);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result, entity);
    }

    /// <summary>
    /// Generic testing of the "delete"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="entity"></param>
    public void Delete_ShouldRemoveEntityFromDatabase_ProductCatalogContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, ProductCatalogContext>(_productContext);
        var addedEntity = repository.Create(entity);


        // Act
        var result = repository.Delete(entity);


        // Assert
        using (ProductCatalogContext context = _productContext)
        {
            Assert.True(result);
        }
    }

    /// <summary>
    /// Generic testing of the "get all"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void GetAll_ShouldReturnAListWithAllTheObjectOfTheSelectedEntity_ProductCatalogContext<TEntity>(List<TEntity> entities) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, ProductCatalogContext>(_productContext);

        foreach (var entity in entities)
        {
            repository.Create(entity);
        }

        // Act
        var testlist = repository.GetAll();

        // Assert
        using (ProductCatalogContext context = _productContext)
        {
            Assert.Equal(testlist.Count(), entities.Count());
        }
    }

    /// <summary>
    /// Generic testing of the "get one"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void GetOne_ShouldReturnAnEntityBasedOnExpression_ProductCatalogContext<TEntity>(TEntity entity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, ProductCatalogContext>(_productContext);

        // Act
        var addedEntity = repository.Create(entity);
        var primaryKeyValue = _productContext.Entry(addedEntity).Property("Id").CurrentValue;
        var result = repository.GetOne(x => EF.Property<int>(x, "Id") == (int)primaryKeyValue);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result, addedEntity);
    }

    /// <summary>
    /// Generic testing of the "get one"-method in the BaseRepository. Call it in the different repository tests and pass the entity to be tested on.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public void Update_ShouldUpdateAnEntity_ProductCatalogContext<TEntity>(TEntity oldEntity, TEntity newEntity) where TEntity : class
    {
        // Arrange
        var repository = new BaseRepository<TEntity, ProductCatalogContext>(_productContext);

        // Act
        oldEntity = repository.Create(oldEntity);
        var updatedEntity = repository.Update(newEntity);

        // Assert
        Assert.NotEqual(oldEntity, updatedEntity);
    }
}