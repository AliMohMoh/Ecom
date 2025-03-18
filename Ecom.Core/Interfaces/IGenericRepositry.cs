using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Interfaces;

public interface IGenericRepositry<TEntity> where TEntity : class
{
    Task<IReadOnlyList<TEntity>> GetAllAsync();
    Task<IReadOnlyList<TEntity>> GetAllAsync(params Expression<Func<TEntity, object>>[] includes);
    Task<TEntity> GetByIdAsync(Guid id);
    Task<TEntity> GetByIdAsync(Guid id, params Expression<Func<TEntity, object>>[] includes);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);
    Task<int> CountAsync();
}
