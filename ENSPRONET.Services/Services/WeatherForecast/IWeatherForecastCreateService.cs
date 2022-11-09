namespace ENSPRONET.Services.Services.WeatherForecast;
using ENSPRONET.Domains.Domains;
public interface IWeatherForecastCreateService
{
    Task<int> Create(WeatherForecast weatherForecast, int countryId);
}
