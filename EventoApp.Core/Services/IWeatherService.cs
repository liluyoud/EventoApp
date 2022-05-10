using EventoApp.Core.Models;
using Refit;

namespace EventoApp.Core.Services
{
    public interface IWeatherService
    {
        [Get("/WeatherForecast")]
        Task<List<WeatherForecast>> GetWeathers();
    }
}
