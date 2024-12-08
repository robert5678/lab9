using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using lab9.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace lab9.Components
{
    public class WeatherViewComponent : ViewComponent
    {
        private const string ApiKey = "daff82691c9bdde70fc12313275d1505";
        private const string BaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var weatherInfo = await GetWeatherAsync(city);
            return View(weatherInfo);
        }

        private async Task<WeatherInfo> GetWeatherAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync($"{BaseUrl}?q={city}&appid={ApiKey}&units=metric");
                dynamic weatherData = JsonConvert.DeserializeObject(response);

                return new WeatherInfo
                {
                    City = city,
                    Description = weatherData.weather[0].description,
                    Temperature = weatherData.main.temp
                };
            }
        }
    }
}
