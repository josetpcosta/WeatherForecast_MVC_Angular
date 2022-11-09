namespace ENSPRONET.Services.Services.WeatherForecast;
using Domains.Domains;
public interface IWeatherForecastUpdateTemperatureService
{
    Task Update(int id, WeatherForecast weatherForecast);
}