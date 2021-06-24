using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiAsync.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetContent")]
        public async Task<IActionResult> GetGoogleContent(CancellationToken token)
        {
            _logger.LogInformation("Istek Basladi");
            await Task.Delay(5000, token);

            var content = await new HttpClient().GetAsync("https://www.google.com", token);

            _logger.LogInformation("Istek Bitti");
            return Ok("asdasd");
        }
    }
}