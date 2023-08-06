using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseCasoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
       

     
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    WeatherForecast weatherForecast = new();
        //  var retrono =  weatherForecast.SolicitacaoAPI();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        [Route("WeatherForecast")]
        public IActionResult GetBuscar()
        {
            WeatherForecast weatherForecast = new();
            var dados = weatherForecast.SolicitacaoAPI().Result;
            var retorno = _mapper.Map<SaidaDados>(dados);
           
            return Ok(retorno);
          
        }
    }
}