using ENSPRONET.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace ENSPRONET.Services.Services.WeatherForecast;

public class WeatherForecastService : IWeatherForecastReadService, IWeatherForecastCreateService, IWeatherForecastUpdateTemperatureService, IWeatherForecastDeleteTemperatureService
{
    private readonly ENSPRONETContext ENSPRONETContext;
    public WeatherForecastService(ENSPRONETContext ensproNetContext)
    {
        ENSPRONETContext = ensproNetContext;
    }

    public async Task<int> Create(Domains.Domains.WeatherForecast weatherForecast, int countryID)
    {
        if (weatherForecast == null || countryID == default(int))
            throw new ArgumentNullException("weatherForecast or contryID");

        var country = await ENSPRONETContext.Countries.Include(m => m.WeatherForecasts).FirstAsync(m => m.Id == countryID);

        country.WeatherForecasts.Add(weatherForecast);

        return await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task<List<Domains.Domains.WeatherForecast>> List(int countryID)
    {
        if (countryID == default(int))
            throw new ArgumentNullException("countryID");

        return await ENSPRONETContext.WeatherForecast.Where(m => m.Country.Id == countryID).ToListAsync();
    }

    public async Task<Domains.Domains.WeatherForecast> GetTemperatureByID(int WeatherForecastID)
    {
        if (WeatherForecastID == default(int))
            throw new ArgumentNullException("weatherforecastID");

        return await ENSPRONETContext.WeatherForecast.Include(c => c.Country).FirstAsync(w => w.Id == WeatherForecastID);
    }


    public async Task Update(int id, Domains.Domains.WeatherForecast weatherForecast)
    {
        if (id == default(int) || weatherForecast == null)
            throw new ArgumentNullException("weatherforecast");

        var weatherForecastSelected = await ENSPRONETContext.WeatherForecast.FirstAsync(m => m.Id == id);

        weatherForecastSelected.TemperatureC = weatherForecast.TemperatureC;
        weatherForecastSelected.TemperatureF = 32 + (int)(weatherForecastSelected.TemperatureC / 0.5556);
        //weatherForecastSelected.Date = weatherForecast.Date;

        ENSPRONETContext.Update(weatherForecastSelected);

        await ENSPRONETContext.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        if (id == default(int))
            throw new ArgumentNullException("id");

        var weatherForecastSelected = await ENSPRONETContext.WeatherForecast.FirstAsync(m => m.Id == id);

        ENSPRONETContext.Remove(weatherForecastSelected);

        await ENSPRONETContext.SaveChangesAsync();
    }
}
