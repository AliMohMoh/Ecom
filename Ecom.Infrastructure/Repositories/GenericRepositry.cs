using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Repositories;

public class GenericRepositry<TEntity> : IGenericRepositry<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;

    public GenericRepositry(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<IReadOnlyList<TEntity>> GetAllAsync()
        => await _context.Set<TEntity>().AsNoTracking().ToListAsync();

    public async Task<IReadOnlyList<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _context.Set<TEntity>().AsQueryable();
        //query = includes.Aggregate(query, (current, include) => current.Include(include));
        foreach (var item in includes)
        {
            query = query.Include(item);
        }
        return await query.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        return entity;
    }

    public async Task<TEntity> GetByIdAsync(Guid id, params Expression<Func<TEntity, object>>[] includes)
    {
        var query = _context.Set<TEntity>().AsQueryable();
        foreach (var item in includes)
        {
            query = query.Include(item);
        }
        var entity = await query.FirstOrDefaultAsync(x => EF.Property<Guid>(x, "Id") == id);
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
       _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}
