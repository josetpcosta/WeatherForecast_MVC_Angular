using System;

namespace ENSPRONET.Services.Services.WeatherForecast;
using Domains.Domains;

public interface IWeatherForecastDeleteTemperatureService
{
    Task Delete(int id);
}
