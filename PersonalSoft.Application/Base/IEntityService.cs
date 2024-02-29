namespace PersonalSoft.Application.Base
{
    public interface IEntityService<T> where T : class
    {
        Task<bool> SaveChanges();

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
