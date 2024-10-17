using Domain.Entities.Base;
using Domain.Enums;

namespace Domain.IRepository.Base
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T entity);
        T Update(T entity);
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIdAsync(long id);
        T Delete(T entity);
        T UpdateState(long id, State state);
    }
}