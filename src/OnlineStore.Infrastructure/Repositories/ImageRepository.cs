using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrastructure.Entities;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ImageRepository : BaseRepository<Image>, IImageRepository
    {
        public ImageRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
