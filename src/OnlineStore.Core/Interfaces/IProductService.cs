using OnlineStore.Core.Dtos;

namespace OnlineStore.Core.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
