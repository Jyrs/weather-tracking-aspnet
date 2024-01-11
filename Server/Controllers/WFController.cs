using Microsoft.AspNetCore.Mvc;
using WeatherApp.AppCore.Models;

namespace WeatherApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WFController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WFController> _logger;

        public WFController(ILogger<WFController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Weather> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Weather
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

     



    }
}