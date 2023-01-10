using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController: ControllerBase
    {
        [HttpGet("seed")]
        public async Task<IActionResult> Seed()
        {
            var defaultConfigurationString = "Server=localhost,1433;Database=IDS;UID=sa;Password=Local1234";
            SeedData.EnsureSeedData(defaultConfigurationString);
            return Ok();
        }
    }
}


