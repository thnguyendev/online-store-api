using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> GetDbSet() => _dbContext.Set<T>();
    }
}
