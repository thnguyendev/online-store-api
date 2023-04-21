using Microsoft.EntityFrameworkCore;
using OnlineStore.Core.Dtos;
using OnlineStore.Core.Interfaces;
using OnlineStore.Infrastructure.Interfaces;

namespace OnlineStore.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IImageRepository _imageRepository;

        public ProductService(IProductRepository productRepository, IImageRepository imageRepository)
        {
            _productRepository = productRepository;
            _imageRepository = imageRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            return await _productRepository.GetDbSet().Include(e => e.Images).Select(e => new ProductDto
            {
                Id = e.Id,
                Code= e.Code,
                Name = e.Name,
                Description = e.Description,
                Price = e.Price,
                ImageUrls = e.Images.Select(i => i.Url).ToArray(),
            }).ToArrayAsync();
        }
    }
}
