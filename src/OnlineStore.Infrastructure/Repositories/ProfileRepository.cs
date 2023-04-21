using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrastructure.Entities;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
