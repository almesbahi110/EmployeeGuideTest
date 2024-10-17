using Domain.Entities.Base;
using Domain.Enums;
using Domain.IRepository.Base;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>(); 
        }

        public async Task<T> InsertAsync(T entity)
        {
            var res = await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return res.Entity;
        }
        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(long id)
        {
            return await _dbSet.FindAsync(id);
        }
        public T Update(T entity)
        {
            var res = _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return res.Entity;
        }
        public T Delete(T entity)
        {
            _dbSet.Remove(entity);
             _dbContext.SaveChanges();
            return entity;
        }

        public T UpdateState(long id, State state)
        {
            var entity = _dbSet.Find(id);
            entity.State=state;
            var res = _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return res.Entity;
        }
    }
}