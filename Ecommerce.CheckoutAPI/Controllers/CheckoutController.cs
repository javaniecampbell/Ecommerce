using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.CheckoutAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        

        private readonly ILogger<CheckoutController> _logger;

        public CheckoutController(ILogger<CheckoutController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Cart")]
        public IEnumerable<string> Get()
        {
            return Enumerable.Range(1, 5).Select(index => "A")
            .ToArray();
        }
    }
}