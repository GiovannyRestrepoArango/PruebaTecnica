using Microsoft.EntityFrameworkCore;
using PersonalSoft.Infrastructure.Data;
using PersonalSoft.Application.IRepositories;

namespace PersonalSoft.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected PersonalSoftDbContext _dbContext;
        bool disposed = false;

        public DbContext Context
        {
            get { return _dbContext; }
        }

        public GenericRepository(PersonalSoftDbContext context)
        {
            _dbContext = context;
        }

        public async Task Add(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> items)
        {
            await _dbContext.Set<T>().AddRangeAsync(items);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            _dbContext.Set<T>().RemoveRange(items);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public async Task<T?> GetById(int id)
        {
            var t = await _dbContext.Set<T>().FindAsync(id);
            if (t == null)
                return null;
            await _dbContext.Entry(t).ReloadAsync();
            return t;
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void UpdateRange(T[] entities)
        {
            _dbContext.UpdateRange(entities);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing && _dbContext != null)
            {
                _dbContext.Dispose();
            }
            disposed = true;
        }
    }
}
