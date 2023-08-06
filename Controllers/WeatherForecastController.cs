using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseCasoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }


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