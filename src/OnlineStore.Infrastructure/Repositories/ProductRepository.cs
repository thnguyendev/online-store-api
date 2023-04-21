using OnlineStore.Infrastructure.Context;
using OnlineStore.Infrastructure.Entities;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
