using Microsoft.AspNetCore.Mvc;

namespace Project_thanos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DummyDataController : ControllerBase
    {
        private static readonly Random _random = new();

        [HttpGet]
        public IActionResult Get()
        {
            var data = new
            {
                smartLife = new
                {
                    contribution = _random.Next(10000, 50000),
                    member = "John Doe",
                    date = DateTime.UtcNow.ToString("yyyy-MM-dd")
                },
                pas = new
                {
                    contribution = _random.Next(10000, 50000),
                    member = "Jane Smith",
                    date = DateTime.UtcNow.ToString("yyyy-MM-dd")
                }
            };
            return Ok(data);
        }
    }
}
