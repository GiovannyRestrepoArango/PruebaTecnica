using Microsoft.EntityFrameworkCore;

namespace PersonalSoft.Application.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext GetContext();

        Task<bool> SaveChanges();
    }
}
