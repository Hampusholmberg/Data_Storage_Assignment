using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Infrastructure.Repositories;

public class BaseRepository<TEntity, TContext> 
    where TEntity : class 
    where TContext : DbContext
{
    private readonly TContext _context;

    protected BaseRepository(TContext context)
    {
        _context = context;
    }


    // -------------- CREATE -------------- //

    /// <summary>
    /// Saves an entity to the database.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns the entity that was passed in the method.</returns>
    public virtual TEntity Create (TEntity entity) 
    {
        try
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }

    // ------------------------------------ //



    // --------------- READ --------------- //

    /// <summary>
    /// This method returns all objects of the table in the database. 
    /// </summary>
    /// <returns>List of the actual entity.</returns>
    public virtual IEnumerable<TEntity> GetAll()
    {
        try
        {
            return _context.Set<TEntity>().ToList();
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }

    /// <summary>
    /// This method returns one object of the table in the database.
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns>The actual Entity of the object.</returns>
    public virtual TEntity? GetOne(Expression <Func<TEntity, bool>> predicate)
    {
        try
        {
            TEntity? entity = _context.Set<TEntity>().FirstOrDefault(predicate);
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return null!;
    }

    // ------------------------------------ //



    // -------------- UPDATE -------------- //






    // ------------------------------------ //





    // -------------- DELETE -------------- //

    /// <summary>
    /// Deletes an entity from the database. The full entity of the object you wish to delete must be passed.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns>Returns true if successful, false if unsuccessful.</returns>
    public virtual bool Delete (TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
            return true;
        } 
        catch (Exception ex) { Debug.WriteLine("ERROR :: " + ex.Message); }
        return false;
    }

    // ------------------------------------ //

}