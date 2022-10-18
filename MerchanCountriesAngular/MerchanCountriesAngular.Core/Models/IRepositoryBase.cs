using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MerchanCountriesAngular.Core.Models;

namespace MerchanCountriesAngular.Core.Models
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAsync();
    }
}