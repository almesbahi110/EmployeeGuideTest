using Application.model.Base;
using Domain.Enums;
using System.Threading.Tasks;

namespace Application.IService.Base
{
    public interface IBaseService<T> where T : BaseDtoEntity
    {
        Task<T> InsertAsync(T entity);
        Task<T> Update(long id, T entity);
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIdAsync(long id);
        Task<T> Delete(long id);
        Task<T> UpdateState(long id, State state);
    }
}
