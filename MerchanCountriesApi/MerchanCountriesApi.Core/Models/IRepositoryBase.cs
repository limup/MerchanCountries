using System.Linq.Expressions;

namespace MerchanCountriesApi.Core.Models
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAsync();

        Task AddManyAsync(IEnumerable<TEntity> entity);
        
        Task Update(TEntity entity);
    }
}