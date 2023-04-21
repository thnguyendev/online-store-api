using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.Interfaces;

namespace OnlineStore.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) 
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
            => Ok(await _productService.GetProducts());
    }
}
