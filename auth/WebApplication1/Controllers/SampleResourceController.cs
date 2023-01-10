using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class SampleResourceController: ControllerBase
    {
        private readonly ISampleResourceService coffeeShopService;

        public SampleResourceController(ISampleResourceService coffeeShopService)
        {
            this.coffeeShopService = coffeeShopService; 
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var shops = new List<SampleResource>();
            return Ok(shops);
        }
    }
}
