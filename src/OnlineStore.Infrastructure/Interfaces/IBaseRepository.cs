using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Infrastructure.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        DbSet<T> GetDbSet();
    }
}
