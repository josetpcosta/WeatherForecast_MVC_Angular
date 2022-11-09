namespace ENSPRONET.Services.Services.WeatherForecast;
using ENSPRONET.Domains.Domains;
public interface IWeatherForecastReadService
{
    Task<List<Domains.Domains.WeatherForecast>> List(int countryID);

    Task<Domains.Domains.WeatherForecast> GetTemperatureByID(int WeatherForecastID);
}
