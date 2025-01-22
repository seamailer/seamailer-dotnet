using Microsoft.AspNetCore.Mvc;
using Seamailer.Contracts;

namespace Seamailer.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ISeaMailerClient _seaMailerClient;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISeaMailerClient seaMailerClient)
        {
            _logger = logger;
            _seaMailerClient = seaMailerClient;
        }

        [HttpGet(Name = "TestEmail")]
        public async Task<IActionResult> TestEmail()
        {
            var send = await _seaMailerClient.SendEmailAsync(new Models.Request.EmailRequest()
            {
                from = new Models.Request.From()
                {
                    email = "xxx@x.com"
                },
                to = new List<Models.Request.To>()
                    {
                        new Models.Request.To()
                        {
                            email =  "abc@xxx.com",
                            name = "Babatunde Esanju"
                        }
                    },
                htmlPart = "test mail",

            });

            if (send.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
