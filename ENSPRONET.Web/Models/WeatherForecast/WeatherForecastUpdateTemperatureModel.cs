namespace ENSPRONET.Web.Models.WeatherForecast;
using Domains.Domains;

public class WeatherForecastUpdateTemperatureModel
{
    public int TemperatureC { get; set; }
    //public int TemperatureF { get; set; }

    public WeatherForecast Map()
    {
        return new WeatherForecast()
        {
            //if
            TemperatureC = this.TemperatureC,
            //TemperatureF = 32 + (int)(TemperatureC / 0.5556),
            //Date = DateTime.Now
        };
    }
}
