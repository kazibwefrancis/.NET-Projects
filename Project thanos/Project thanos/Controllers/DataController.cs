using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_thanos.Services;
using System.Text.Json;

namespace Project_thanos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly ExternalApiService _externalApiService;
        private readonly ILogger<DataController> _logger;

        public DataController(ExternalApiService externalApiService, ILogger<DataController> logger)
        {
            _externalApiService = externalApiService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromHeader(Name = "Authorization")] string? authorization)
        {
            // Replace with your actual API URLs
            string api1Url = "https://api.example.com/data1";
            string api2Url = "https://api.example.com/data2";

            string? bearerToken = null;
            if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer "))
            {
                bearerToken = authorization.Substring("Bearer ".Length);
            }

            var api1Data = await _externalApiService.GetApi1DataAsync(api1Url, bearerToken);
            var api2Data = await _externalApiService.GetApi2DataAsync(api2Url, bearerToken);

            var result = new
            {
                Api1 = api1Data != null ? JsonSerializer.Deserialize<object>(api1Data) : null,
                Api2 = api2Data != null ? JsonSerializer.Deserialize<object>(api2Data) : null
            };

            return Ok(result);
        }
    }
}
