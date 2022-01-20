using ASP_NET_Core101.Website.Models;
using ASP_NET_Core101.Website.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASP_NET_Core101.Website.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [HttpPatch]
        public ActionResult Patch([FromBody] RatingRequest request)
        {
            ProductService.AddRating(request.ProductId, request.Rating);

            return Ok();
        }

        public class RatingRequest
        {
            public string ProductId { get; set; }
            public int Rating { get; set; }
        }
    }
}