using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPIDemo.Models;

namespace ProductAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Hard-coded list for demo
        private static readonly List<Product> _products =
        [
            new(1, "Keyboard", 49.99m),
            new(2, "Mouse", 29.99m),
            new(3, "Headset", 89.99m)
        ];

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
            => Ok(_products);
    }
}
