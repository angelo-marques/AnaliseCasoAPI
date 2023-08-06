using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;
using static AnaliseCasoAPI.ModeloEntradaDados;

namespace AnaliseCasoAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        

        public async Task<ModeloEntradaDados> SolicitacaoAPI()
        {
         
            HttpClient httpClient = new();
            string url = "https://jsonplaceholder.typicode.com/users";

            httpClient.BaseAddress = new Uri(url);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var json = JsonConvert.SerializeObject(url, Formatting.Indented);
            var envio = new HttpRequestMessage(HttpMethod.Get, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            HttpResponseMessage resultado = httpClient.SendAsync(envio).Result;

            if (resultado != null)
            {
                var jsonResult = await resultado.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<List<ModeloEntradaDados>>(jsonResult).First();
            
                return response;
            }


            return null;
        }
      


    }

  
}