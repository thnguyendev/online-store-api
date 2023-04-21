using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrastructure.Entities;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
