using Microsoft.EntityFrameworkCore;

namespace PersonalSoft.Application.IRepositories
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        DbContext Context { get; }

        Task<T?> GetById(int id);

        IQueryable<T> GetAll();

        Task Add(T entity);

        Task AddRange(IEnumerable<T> items);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> items);

        void Update(T entity);

        void UpdateRange(T[] entities);
    }
}
